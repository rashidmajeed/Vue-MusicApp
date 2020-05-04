using System;
using API.RequestModels;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;

namespace API.Controllers
{
    [ApiController]
    public class MusicController : ControllerBase
    {
        private readonly ILogger<MusicController> _logger;
        private readonly IMusicService _musicservice;

        public MusicController(ILogger<MusicController> logger, IMusicService musicservice)
        {
            _logger = logger;
            _musicservice = musicservice;
        }

        [HttpGet("api/music")]
        public ActionResult GetAllMusic()
        {
            var music = _musicservice.GetAllMusic();
            return Ok(music);
        }

        [HttpGet("api/music/{id}")]
        public ActionResult GetMusic(int id)
        {
            var music = _musicservice.GetMusic(id);
            return Ok(music);
        }

        [HttpPost("api/music")]
        public ActionResult CreateMusic([FromBody] NewMusicRequest musicRequest)
        {
          if(!ModelState.IsValid){
            return BadRequest("Model state is not valid..");
          }
            var now = DateTime.UtcNow;
            var newMusic = new Music {
              Name = musicRequest.Name,
              Description = musicRequest.Description,
              Duration = musicRequest.Duration,
              Image_Url = musicRequest.Image_Url,
              Audio_Url = musicRequest.Audio_Url,
              Thumb = musicRequest.Thumb,
              CreatedBy = musicRequest.CreatedBy,
              CreatedOn = now
            };
           _musicservice.AddMusic(newMusic);
            return Ok($"Music is Created: {newMusic.Name}");
        }

         [HttpDelete("api/music/{id}")]
        public ActionResult DeleteMusic(int id)
        {
            _musicservice.GetMusic(id);
            return Ok($"Music is Deleted: {id}");
        }
    }
}
