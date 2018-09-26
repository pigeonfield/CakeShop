using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Models
{
    public class MockCakeRepository : ICakeRepository
    {
        private List<Cake> _cakes;

        public MockCakeRepository()
        {
            if (_cakes == null)
            {
                InitializeCakes();
            }
        }

        private void InitializeCakes()
        {
            _cakes = new List<Cake>
            {
                new Cake {Id = 1, Name = "Steve Jobs", ShortDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.",
                Price = 12.99M, ImageUrl = "www.url.com", ImageThumbnailUrl = "http://cdn.playbuzz.com/cdn/2c8194b2-2af0-4627-aaf8-50cb902faaf7/5bade0d2-8656-4fd5-929c-02821b67b7c4_560_420.jpg", IsCakeOfTheWeek = false},
                new Cake {Id = 2, Name = "Witcher", ShortDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.",
                Price = 8.99M, ImageUrl = "www.url.com", ImageThumbnailUrl = "http://cdn.playbuzz.com/cdn/2c8194b2-2af0-4627-aaf8-50cb902faaf7/5bade0d2-8656-4fd5-929c-02821b67b7c4_560_420.jpg", IsCakeOfTheWeek = true},
                new Cake {Id = 3, Name = "The Silmarillion", ShortDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.",
                Price = 10.99M, ImageUrl = "www.url.com", ImageThumbnailUrl = "http://cdn.playbuzz.com/cdn/2c8194b2-2af0-4627-aaf8-50cb902faaf7/5bade0d2-8656-4fd5-929c-02821b67b7c4_560_420.jpg", IsCakeOfTheWeek = false},
                new Cake {Id = 4, Name = "Harry Potter", ShortDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.",
                Price = 20.99M, ImageUrl = "www.url.com", ImageThumbnailUrl = "http://cdn.playbuzz.com/cdn/2c8194b2-2af0-4627-aaf8-50cb902faaf7/5bade0d2-8656-4fd5-929c-02821b67b7c4_560_420.jpg", IsCakeOfTheWeek = false},
            };
        }

        public IEnumerable<Cake> GetAllCakes()
        {
            return _cakes;
        }

        public Cake GetCakeById(int cakeId)
        {
            return _cakes.FirstOrDefault(b => b.Id == cakeId);
        }


    }
}
