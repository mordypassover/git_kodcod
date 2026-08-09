using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogPlatformApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JoineDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Content = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PublishedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsPublished = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    CommenterName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Text = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Email", "FullName", "JoineDate" },
                values: new object[,]
                {
                    { 1, "sarah.j@example.com", "Sarah Johnson", new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "m.chen@example.com", "Michael Chen", new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "emma.w@example.com", "Emma Williams", new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "david.m@example.com", "David Martinez", new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "lisa.a@example.com", "Lisa Anderson", new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Content", "CreatedAt", "IsPublished", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, "A comprehensive guide to building modern web applications...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Getting Started with ASP.NET Core" },
                    { 2, 1, "Deep dive into EF Core relationships and migrations...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Understanding Entity Framework" },
                    { 3, 1, "Learn how to design clean and maintainable APIs...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "REST API Best Practices" },
                    { 4, 1, "Master async/await patterns for better performance...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Async Programming in C#" },
                    { 5, 1, "Understanding DI containers and service lifetimes...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dependency Injection Explained" },
                    { 6, 1, "Work in progress on complex query patterns...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Draft: Advanced LINQ Queries" },
                    { 7, 2, "Containerize your applications with Docker...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Docker for .NET Developers" },
                    { 8, 2, "Building scalable distributed systems...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microservices Architecture" },
                    { 9, 2, "Orchestrating containers in production...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kubernetes Basics" },
                    { 10, 2, "Automating your deployment pipeline...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "CI/CD with GitHub Actions" },
                    { 11, 2, "Exploring Istio and service mesh...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Draft: Service Mesh Patterns" },
                    { 12, 3, "Modern React development with hooks...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "React Hooks Tutorial" },
                    { 13, 3, "Adding type safety to your JavaScript...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "TypeScript for Beginners" },
                    { 14, 3, "Managing complex application state...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "State Management with Redux" },
                    { 15, 3, "Building modern web apps with Next.js...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Next.js Full Stack Apps" },
                    { 16, 3, "Modern layout techniques for responsive design...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "CSS Grid and Flexbox" },
                    { 17, 4, "Getting started with pandas and numpy...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Python Data Science Basics" },
                    { 18, 4, "Building neural networks from scratch...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Machine Learning with TensorFlow" },
                    { 19, 4, "Writing efficient database queries...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "SQL Query Optimization" },
                    { 20, 4, "Choosing the right database for your needs...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "NoSQL vs SQL Databases" },
                    { 21, 4, "Working with Apache Spark...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Draft: Big Data Processing" },
                    { 22, 5, "Implementing Scrum in your team...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agile Development Practices" },
                    { 23, 5, "Improving code quality through reviews...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code Review Best Practices" },
                    { 24, 5, "Balancing features and maintainability...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Technical Debt Management" },
                    { 25, 5, "Growing from developer to tech lead...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Team Leadership Skills" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
