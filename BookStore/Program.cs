using BookStore.BookStorebl.Interfaces;
using BookStore.BookStorebl.Services;
using BookStore.DL.Interfaces;
using BookStore.DL.Repository;
using BookStorebl.Interfaces;
using BookStorebl.Services;

namespace BookStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<IBookRepository, BookRepository>();
            builder.Services.AddSingleton<IAuthorServices, AuthorServise>();

            builder.Services.AddSingleton<IBookServices, BookService>();
            builder.Services.AddSingleton<IAuthorRepository, AuthorRepository>();
            builder.Services.AddSingleton<ILibraryServices, LibraryServices>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}