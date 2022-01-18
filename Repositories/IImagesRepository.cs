using backendProiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Repositories
{
    public interface IImagesRepository
    {
        IQueryable<Image> GetImagesIQueryable();
        void CreateImage(Image image);
        void UpdateImage(Image image);
        void DeleteImage(Image image);
    }
}
