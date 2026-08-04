using LibreryApi.models;

namespace LibreryApi.Repos;

public interface IBookRepo
{
    Task<List<Book>> getAllAsync();

    Task<Book> getById(int id);
    Task<Book> addAsync(Book book);

    Task<bool> updateAsync(int id, Book book);

    Task<bool> deleteAsync(int id);


}
