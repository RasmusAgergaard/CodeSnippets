using System.Linq;

namespace BethanysPieShop.Models
{
    public static class DbInitialzer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Pies.Any())
            {
                context.AddRange
                (
                    new Pie { Id = 1, Name = "A", Price = 49.95M, ShortDescription = "Short", LongDescription = "Long", ImageUrl = @"..\images\pies\1.jpg", ImageThumbnailUrl = @"..\images\pies\1.jpg", IsPieOfTheWeek = true },
                    new Pie { Id = 2, Name = "B", Price = 39.49M, ShortDescription = "Short", LongDescription = "Long", ImageUrl = @"..\images\pies\2.jpg", ImageThumbnailUrl = @"..\images\pies\2.jpg", IsPieOfTheWeek = false },
                    new Pie { Id = 3, Name = "C", Price = 42.45M, ShortDescription = "Short", LongDescription = "Long", ImageUrl = @"..\images\pies\3.jpg", ImageThumbnailUrl = @"..\images\pies\3.jpg", IsPieOfTheWeek = false },
                    new Pie { Id = 4, Name = "D", Price = 18.99M, ShortDescription = "Short", LongDescription = "Long", ImageUrl = @"..\images\pies\4.jpg", ImageThumbnailUrl = @"..\images\pies\4.jpg", IsPieOfTheWeek = false },
                    new Pie { Id = 5, Name = "E", Price = 49.95M, ShortDescription = "Short", LongDescription = "Long", ImageUrl = @"..\images\pies\1.jpg", ImageThumbnailUrl = @"..\images\pies\1.jpg", IsPieOfTheWeek = false },
                    new Pie { Id = 6, Name = "F", Price = 39.49M, ShortDescription = "Short", LongDescription = "Long", ImageUrl = @"..\images\pies\2.jpg", ImageThumbnailUrl = @"..\images\pies\2.jpg", IsPieOfTheWeek = false },
                    new Pie { Id = 7, Name = "G", Price = 42.45M, ShortDescription = "Short", LongDescription = "Long", ImageUrl = @"..\images\pies\3.jpg", ImageThumbnailUrl = @"..\images\pies\3.jpg", IsPieOfTheWeek = false },
                    new Pie { Id = 8, Name = "H", Price = 18.99M, ShortDescription = "Short", LongDescription = "Long", ImageUrl = @"..\images\pies\4.jpg", ImageThumbnailUrl = @"..\images\pies\4.jpg", IsPieOfTheWeek = false }
                );

                context.SaveChanges();
            }
        }
    }
}
