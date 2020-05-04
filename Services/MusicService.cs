using System.Collections.Generic;
using System;
using System.Linq;
using Data;
using Data.Models;

namespace Services
{
    public class MusicService : IMusicService
    {
        private readonly MusicContext _db;

        public MusicService(MusicContext db)
        {
            _db = db;
        }
        public List<Music> GetAllMusic()
        {
            return _db.Musics.ToList();
        }

        public Music GetMusic(int musicId)
        {
            return _db.Musics.Find(musicId);
        }

        public void AddMusic(Music music)
        {
            _db.Add(music);
            _db.SaveChanges();
        }

        public void DeleteMusic(int musicId)
        {
            var musicToDelete = _db.Musics.Find(musicId);
            if (musicToDelete != null)
            {
                _db.Remove(musicToDelete);
                _db.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Cannot delete Book that doesnot exist");
            }

        }

    }
}