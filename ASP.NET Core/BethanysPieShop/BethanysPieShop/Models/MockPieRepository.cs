﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            _pies = new List<Pie>
            {
            new Pie { Id = 1, Name = "A", Price = 49.95M, ShortDescription = "Short", LongDescription = "Long", ImageUrl = @"..\images\pies\1.jpg", ImageThumbnailUrl = @"..\images\pies\1.jpg", IsPieOfTheWeek = true},
            new Pie { Id = 2, Name = "B", Price = 39.49M, ShortDescription = "Short", LongDescription = "Long", ImageUrl = @"..\images\pies\2.jpg", ImageThumbnailUrl = @"..\images\pies\2.jpg", IsPieOfTheWeek = false },
            new Pie { Id = 3, Name = "C", Price = 42.45M, ShortDescription = "Short", LongDescription = "Long", ImageUrl = @"..\images\pies\3.jpg", ImageThumbnailUrl = @"..\images\pies\3.jpg", IsPieOfTheWeek = false },
            new Pie { Id = 4, Name = "D", Price = 18.99M, ShortDescription = "Short", LongDescription = "Long", ImageUrl = @"..\images\pies\4.jpg", ImageThumbnailUrl = @"..\images\pies\4.jpg", IsPieOfTheWeek = false }

            };
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
