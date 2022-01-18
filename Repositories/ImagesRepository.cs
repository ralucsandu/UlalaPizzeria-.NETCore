using backendProiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Repositories
{
    public class ImagesRepository : IImagesRepository
    {
        private backendProiectContext db;
        public ImagesRepository(backendProiectContext db)
        {
            this.db = db;
        }

        public IQueryable<Image> GetImagesIQueryable()
        {
            var images = db.Images;
            return images;
        }

        public void CreateImage(Image image)
        {
            db.Images.Add(image);
            db.SaveChanges();
        }

        public void DeleteImage(Image image)
        {
            db.Images.Remove(image);
            db.SaveChanges();
        }
        public void UpdateImage(Image image)
        {
            db.Images.Update(image);
            db.SaveChanges();
        }
    }
}
