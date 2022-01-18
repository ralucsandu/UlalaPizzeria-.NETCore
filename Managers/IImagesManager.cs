using backendProiect.Entities;
using backendProiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Managers
{
    public interface IImagesManager
    {
        List<Image> GetImages();
        List<int> GetImageIdsList();
        Image GetImageById(int id);
        void CreateImage(ImageModel imageModel);
        void UpdateImage(ImageModel imageModel);
        void DeleteImage(int ImageId);
    }
}
