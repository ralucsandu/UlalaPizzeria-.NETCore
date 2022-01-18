using backendProiect.Entities;
using backendProiect.Models;
using backendProiect.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Managers
{
    public class ImagesManager : IImagesManager
    {
        private readonly IImagesRepository imagesRepository;
        public ImagesManager(IImagesRepository imagesRepository)
        {
            this.imagesRepository = imagesRepository;
        }
        public List<Image> GetImages()
        {
            return imagesRepository.GetImagesIQueryable().ToList();
        }
        public List<int> GetImageIdsList()
        {
            var images = imagesRepository.GetImagesIQueryable();
            var idList = images.Select(x => x.ImageId)
                .ToList();

            return idList;
        }
        public Image GetImageById(int id)
        {
            var image = imagesRepository.GetImagesIQueryable()
                .FirstOrDefault(x => x.ImageId == id);
            return image;
        }

        public void CreateImage(ImageModel imageModel)
        {
            var newImage = new Image
            {
                ImageId = imageModel.ImageId,
                URL = imageModel.URL,
                FoodId = imageModel.FoodId
            };

            imagesRepository.CreateImage(newImage);
        }

        public void UpdateImage(ImageModel imageModel)
        {
            var image = GetImageById(imageModel.ImageId);
            image.URL = imageModel.URL;
            imagesRepository.UpdateImage(image);
        }

        public void DeleteImage(int ImageId)
        {
            var image = GetImageById(ImageId);
            imagesRepository.DeleteImage(image);
        }
    }
}
