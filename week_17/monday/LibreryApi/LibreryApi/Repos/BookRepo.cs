using LibreryApi.Data;
using LibreryApi.models;
using Microsoft.EntityFrameworkCore;

namespace LibreryApi.Repos
{
    public class BookRepo : IBookRepo
    {
        ApplicationDbContext _context;

        public BookRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> getAllAsync()
        {
            return await _context.books.ToListAsync();
        }

        public async Task<Book> getById(int id)
        {
            return await _context.books.FindAsync(id);
        }
        public async Task<Book> addAsync(Book book)
        {
            _context.books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }
        public async Task<bool> updateAsync(int id, Book book)
        {
            var existing = await _context.books.FindAsync(id);
            if (existing == null)
                return false;

            existing.Title = book.Title;
            existing.Author = book.Author;
            existing.ISBN = book.ISBN;
            existing.PublishedYear = book.PublishedYear;
            existing.AvailableCopies = book.AvailableCopies;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> deleteAsync(int id)
        {
            var existing = await getById(id);
            if (existing == null)
            {
                return false;
            }
            _context.books.Remove(existing);

            await _context.SaveChangesAsync();
            return true;
        }

    }
}
