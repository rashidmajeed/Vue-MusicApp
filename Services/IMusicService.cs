using System.Collections.Generic;
using Data.Models;

namespace Services
{
    public interface IMusicService
    {
        public List<Music> GetAllMusic();
        public Music GetMusic(int musicId);
        public void AddMusic(Music music);
        public void DeleteMusic(int musicId);
    }
}