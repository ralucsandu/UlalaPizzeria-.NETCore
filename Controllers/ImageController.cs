using backendProiect.Entities;
using backendProiect.Managers;
using backendProiect.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImagesManager manager;
        public ImageController(IImagesManager imagesManager)
        {
            this.manager = imagesManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetImages()
        {
            var images = manager.GetImages();
            return Ok(images);
        }
        [HttpGet("select-image-id")]
        public async Task<IActionResult> GetImageIds()
        {
            var idList = manager.GetImageIdsList();
            return Ok(idList);
        }

        [HttpPost]
        public async Task<IActionResult> CreateImage([FromBody] ImageModel imageModel)
        {
            manager.CreateImage(imageModel);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateImage([FromBody] ImageModel imageModel)
        {
            manager.UpdateImage(imageModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImage([FromRoute] int id)
        {
            manager.DeleteImage(id);
            return Ok();
        }
    }
}
