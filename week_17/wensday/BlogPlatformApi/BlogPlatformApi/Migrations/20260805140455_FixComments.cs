using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogPlatformApi.Migrations
{
    /// <inheritdoc />
    public partial class FixComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommenterName", "CreatedAt", "PostId", "Text" },
                values: new object[,]
                {
                    { 1, "John Doe", new DateTime(2024, 1, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), 1, "Great introduction! Very helpful for beginners." },
                    { 2, "Jane Smith", new DateTime(2024, 1, 11, 14, 15, 0, 0, DateTimeKind.Unspecified), 1, "Could you cover middleware in the next post?" },
                    { 3, "Bob Wilson", new DateTime(2024, 1, 12, 9, 20, 0, 0, DateTimeKind.Unspecified), 1, "This helped me get started with my first project!" },
                    { 4, "Alice Brown", new DateTime(2024, 1, 13, 16, 45, 0, 0, DateTimeKind.Unspecified), 1, "Clear explanations, thank you!" },
                    { 5, "Charlie Davis", new DateTime(2024, 1, 14, 11, 10, 0, 0, DateTimeKind.Unspecified), 1, "Looking forward to more ASP.NET content." },
                    { 6, "Emily White", new DateTime(2024, 2, 6, 8, 30, 0, 0, DateTimeKind.Unspecified), 2, "EF Core migrations can be tricky, thanks for this!" },
                    { 7, "Frank Miller", new DateTime(2024, 2, 7, 13, 20, 0, 0, DateTimeKind.Unspecified), 2, "What about many-to-many relationships?" },
                    { 8, "Grace Lee", new DateTime(2024, 2, 8, 10, 15, 0, 0, DateTimeKind.Unspecified), 2, "Very detailed explanation of relationships." },
                    { 9, "Henry Taylor", new DateTime(2024, 2, 9, 15, 40, 0, 0, DateTimeKind.Unspecified), 2, "This solved my foreign key issues!" },
                    { 10, "Ivy Chen", new DateTime(2024, 3, 13, 9, 10, 0, 0, DateTimeKind.Unspecified), 3, "REST principles explained perfectly." },
                    { 11, "Jack Robinson", new DateTime(2024, 3, 14, 14, 25, 0, 0, DateTimeKind.Unspecified), 3, "How do you handle versioning?" },
                    { 12, "Kelly Martinez", new DateTime(2024, 3, 15, 11, 50, 0, 0, DateTimeKind.Unspecified), 3, "Bookmarked for future reference!" },
                    { 13, "Leo Garcia", new DateTime(2024, 4, 21, 10, 5, 0, 0, DateTimeKind.Unspecified), 4, "Async/await finally makes sense!" },
                    { 14, "Mia Anderson", new DateTime(2024, 4, 22, 13, 30, 0, 0, DateTimeKind.Unspecified), 4, "Great examples of common pitfalls." },
                    { 15, "Noah Thomas", new DateTime(2024, 4, 23, 9, 45, 0, 0, DateTimeKind.Unspecified), 4, "Could you cover Task.WhenAll?" },
                    { 16, "Olivia Jackson", new DateTime(2024, 4, 24, 16, 20, 0, 0, DateTimeKind.Unspecified), 4, "This improved my app's performance significantly." },
                    { 17, "Paul Harris", new DateTime(2024, 5, 9, 8, 15, 0, 0, DateTimeKind.Unspecified), 5, "DI was confusing until I read this." },
                    { 18, "Quinn Martin", new DateTime(2024, 5, 10, 12, 40, 0, 0, DateTimeKind.Unspecified), 5, "Service lifetimes explained clearly!" },
                    { 19, "Rachel Thompson", new DateTime(2024, 5, 11, 15, 10, 0, 0, DateTimeKind.Unspecified), 5, "Very practical examples." },
                    { 20, "Sam White", new DateTime(2024, 1, 26, 9, 20, 0, 0, DateTimeKind.Unspecified), 7, "Docker has been on my learning list, perfect timing!" },
                    { 21, "Tina Lopez", new DateTime(2024, 1, 27, 14, 35, 0, 0, DateTimeKind.Unspecified), 7, "Multi-stage builds are a game changer." },
                    { 22, "Uma Patel", new DateTime(2024, 1, 28, 10, 50, 0, 0, DateTimeKind.Unspecified), 7, "How do you handle secrets in containers?" },
                    { 23, "Victor Kim", new DateTime(2024, 1, 29, 16, 15, 0, 0, DateTimeKind.Unspecified), 7, "Great Docker tutorial!" },
                    { 24, "Wendy Clark", new DateTime(2024, 3, 6, 11, 10, 0, 0, DateTimeKind.Unspecified), 8, "Microservices architecture explained well." },
                    { 25, "Xavier Rodriguez", new DateTime(2024, 3, 7, 13, 25, 0, 0, DateTimeKind.Unspecified), 8, "What about service discovery?" },
                    { 26, "Yara Lewis", new DateTime(2024, 3, 8, 15, 40, 0, 0, DateTimeKind.Unspecified), 8, "This helped me design my system." },
                    { 27, "Zack Walker", new DateTime(2024, 4, 16, 9, 30, 0, 0, DateTimeKind.Unspecified), 9, "Kubernetes is complex but this helps!" },
                    { 28, "Amy Hall", new DateTime(2024, 4, 17, 12, 15, 0, 0, DateTimeKind.Unspecified), 9, "Deployments and services explained clearly." },
                    { 29, "Ben Allen", new DateTime(2024, 4, 18, 14, 50, 0, 0, DateTimeKind.Unspecified), 9, "Looking forward to advanced K8s topics." },
                    { 30, "Cara Young", new DateTime(2024, 5, 23, 10, 20, 0, 0, DateTimeKind.Unspecified), 10, "GitHub Actions workflow examples are great!" },
                    { 31, "Dan King", new DateTime(2024, 5, 24, 13, 45, 0, 0, DateTimeKind.Unspecified), 10, "How do you handle deployment secrets?" },
                    { 32, "Eva Wright", new DateTime(2024, 5, 25, 11, 10, 0, 0, DateTimeKind.Unspecified), 10, "Automated my entire pipeline thanks to this!" },
                    { 33, "Fred Scott", new DateTime(2024, 5, 26, 15, 30, 0, 0, DateTimeKind.Unspecified), 10, "CI/CD made simple." },
                    { 34, "Gina Green", new DateTime(2024, 2, 9, 9, 15, 0, 0, DateTimeKind.Unspecified), 12, "React hooks changed everything!" },
                    { 35, "Hank Adams", new DateTime(2024, 2, 10, 12, 30, 0, 0, DateTimeKind.Unspecified), 12, "useState and useEffect explained perfectly." },
                    { 36, "Iris Baker", new DateTime(2024, 2, 11, 14, 45, 0, 0, DateTimeKind.Unspecified), 12, "Custom hooks tutorial next please!" },
                    { 37, "Jake Nelson", new DateTime(2024, 3, 19, 10, 10, 0, 0, DateTimeKind.Unspecified), 13, "TypeScript makes JavaScript so much better." },
                    { 38, "Kate Carter", new DateTime(2024, 3, 20, 13, 20, 0, 0, DateTimeKind.Unspecified), 13, "Type safety is a lifesaver!" },
                    { 39, "Liam Mitchell", new DateTime(2024, 3, 21, 11, 35, 0, 0, DateTimeKind.Unspecified), 13, "Generics explained clearly." },
                    { 40, "Maya Perez", new DateTime(2024, 3, 22, 15, 50, 0, 0, DateTimeKind.Unspecified), 13, "Switching all my projects to TS now." },
                    { 41, "Nick Roberts", new DateTime(2024, 4, 26, 9, 25, 0, 0, DateTimeKind.Unspecified), 14, "Redux Toolkit makes state management easier." },
                    { 42, "Olga Turner", new DateTime(2024, 4, 27, 12, 40, 0, 0, DateTimeKind.Unspecified), 14, "What about Zustand as an alternative?" },
                    { 43, "Pete Phillips", new DateTime(2024, 4, 28, 14, 15, 0, 0, DateTimeKind.Unspecified), 14, "Great Redux tutorial!" },
                    { 44, "Rita Campbell", new DateTime(2024, 5, 31, 10, 5, 0, 0, DateTimeKind.Unspecified), 15, "Next.js is amazing for full stack apps." },
                    { 45, "Steve Parker", new DateTime(2024, 6, 1, 13, 20, 0, 0, DateTimeKind.Unspecified), 15, "Server components are the future!" },
                    { 46, "Tara Evans", new DateTime(2024, 6, 2, 11, 45, 0, 0, DateTimeKind.Unspecified), 15, "SEO benefits are huge." },
                    { 47, "Umar Edwards", new DateTime(2024, 6, 3, 15, 10, 0, 0, DateTimeKind.Unspecified), 15, "Deploying to Vercel is so easy!" },
                    { 48, "Vera Collins", new DateTime(2024, 6, 13, 9, 30, 0, 0, DateTimeKind.Unspecified), 16, "CSS Grid is so powerful!" },
                    { 49, "Will Stewart", new DateTime(2024, 6, 14, 12, 15, 0, 0, DateTimeKind.Unspecified), 16, "Flexbox vs Grid comparison would be great." },
                    { 50, "Xena Morris", new DateTime(2024, 6, 15, 14, 40, 0, 0, DateTimeKind.Unspecified), 16, "Responsive layouts made easy!" },
                    { 51, "Yuri Rogers", new DateTime(2024, 2, 15, 10, 20, 0, 0, DateTimeKind.Unspecified), 17, "Pandas is essential for data science." },
                    { 52, "Zoe Reed", new DateTime(2024, 2, 16, 13, 35, 0, 0, DateTimeKind.Unspecified), 17, "DataFrame operations explained well." },
                    { 53, "Adam Cook", new DateTime(2024, 2, 17, 11, 50, 0, 0, DateTimeKind.Unspecified), 17, "Great intro to Python data science!" },
                    { 54, "Beth Morgan", new DateTime(2024, 3, 29, 9, 10, 0, 0, DateTimeKind.Unspecified), 18, "TensorFlow tutorial is comprehensive." },
                    { 55, "Carl Bell", new DateTime(2024, 3, 30, 12, 25, 0, 0, DateTimeKind.Unspecified), 18, "Neural networks finally make sense!" },
                    { 56, "Dana Murphy", new DateTime(2024, 3, 31, 14, 40, 0, 0, DateTimeKind.Unspecified), 18, "Could you cover CNNs next?" },
                    { 57, "Eric Bailey", new DateTime(2024, 4, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), 18, "ML is less intimidating now." },
                    { 58, "Faye Rivera", new DateTime(2024, 4, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), 19, "Query optimization tips are gold!" },
                    { 59, "Greg Cooper", new DateTime(2024, 4, 12, 13, 45, 0, 0, DateTimeKind.Unspecified), 19, "Indexes explained clearly." },
                    { 60, "Hope Richardson", new DateTime(2024, 4, 13, 15, 20, 0, 0, DateTimeKind.Unspecified), 19, "My queries are 10x faster now!" },
                    { 61, "Ian Cox", new DateTime(2024, 5, 19, 9, 15, 0, 0, DateTimeKind.Unspecified), 20, "Great comparison of database types." },
                    { 62, "Jill Howard", new DateTime(2024, 5, 20, 12, 30, 0, 0, DateTimeKind.Unspecified), 20, "When to use MongoDB vs PostgreSQL?" },
                    { 63, "Kyle Ward", new DateTime(2024, 5, 21, 14, 45, 0, 0, DateTimeKind.Unspecified), 20, "This helped me choose the right DB." },
                    { 64, "Lynn Torres", new DateTime(2024, 5, 22, 16, 10, 0, 0, DateTimeKind.Unspecified), 20, "Very informative article!" },
                    { 65, "Mark Peterson", new DateTime(2024, 3, 9, 10, 20, 0, 0, DateTimeKind.Unspecified), 22, "Scrum practices explained well." },
                    { 66, "Nina Gray", new DateTime(2024, 3, 10, 13, 35, 0, 0, DateTimeKind.Unspecified), 22, "Our team adopted these practices!" },
                    { 67, "Owen Ramirez", new DateTime(2024, 3, 11, 15, 50, 0, 0, DateTimeKind.Unspecified), 22, "Agile methodology made simple." },
                    { 68, "Pam James", new DateTime(2024, 4, 13, 9, 25, 0, 0, DateTimeKind.Unspecified), 23, "Code reviews are so important!" },
                    { 69, "Quinn Watson", new DateTime(2024, 4, 14, 12, 40, 0, 0, DateTimeKind.Unspecified), 23, "Great tips for constructive feedback." },
                    { 70, "Ross Brooks", new DateTime(2024, 4, 15, 14, 15, 0, 0, DateTimeKind.Unspecified), 23, "Our code quality improved significantly." },
                    { 71, "Sara Kelly", new DateTime(2024, 4, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 23, "Every developer should read this." },
                    { 72, "Tony Sanders", new DateTime(2024, 5, 21, 10, 10, 0, 0, DateTimeKind.Unspecified), 24, "Technical debt is real!" },
                    { 73, "Uma Price", new DateTime(2024, 5, 22, 13, 25, 0, 0, DateTimeKind.Unspecified), 24, "Balancing features and refactoring is hard." },
                    { 74, "Vince Bennett", new DateTime(2024, 5, 23, 15, 40, 0, 0, DateTimeKind.Unspecified), 24, "Practical advice for managing debt." },
                    { 75, "Wanda Wood", new DateTime(2024, 6, 9, 9, 30, 0, 0, DateTimeKind.Unspecified), 25, "Leadership skills are crucial!" },
                    { 76, "Xavier Barnes", new DateTime(2024, 6, 10, 12, 15, 0, 0, DateTimeKind.Unspecified), 25, "Transitioning to tech lead soon, this helps!" },
                    { 77, "Yolanda Ross", new DateTime(2024, 6, 11, 14, 40, 0, 0, DateTimeKind.Unspecified), 25, "Great insights on team leadership." },
                    { 78, "Zane Henderson", new DateTime(2024, 6, 12, 16, 20, 0, 0, DateTimeKind.Unspecified), 25, "Every tech lead should read this." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 78);
        }
    }
}
