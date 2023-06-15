using System;
using System.Collections.Generic;
using System.Linq;

namespace rmpPract1._3.types
{
    public class Playlist
    {
        private List<Song> list;
        private int currentIndex;

        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }

        public string getAllSongs()
        {
            string allCompositions = "Список композиций:\n";
            foreach (Song song in list)
            {
                allCompositions += $"{song.Title} ({song.Author})\n";
            }

            return allCompositions;
        }

        public void addSong(Song song)
        {
            list.Add(song);
        }
        
        // public string removeSong(int index)
        // {
        //     if (index < list.Count())
        //     {
        //         list.RemoveAt(index);
        //         return "Запись удалена";
        //     }
        //
        //     return "Запись не найдена";
        // }

        public string removeSong(string songTitle)
        {
            int i = 0;
            foreach (Song item in list)
            {
                if (item.Title == songTitle.Replace(" ", ""))
                {
                    list.RemoveAt(i);
                    return "Запись удалена";
                }
                i++;
            }

            return "Запись не найдена";
        }

        public string clearPlaylist()
        {
            list.Clear();
            return "Плейлист очищен";
        }

        public void nextSong()
        {
            if (list.Count > 0)
            {
                currentIndex++;
                if (currentIndex >= list.Count) currentIndex = 0;
            }
            else
            {
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
            }
        }
        
        public void backSong()
        {
            if (list.Count > 0)
            {
                currentIndex--;
                if (currentIndex <= 0) currentIndex = list.Count - 1;
            }
            else
            {
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");

            }
        }

        public Song selectSong(int index)
        {
            if (list.Count > 0 && index < list.Count - 1) return list[index];
            else
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }

        public Song refresh()
        {
            currentIndex = 0;
            Song song = currentSong();
            return song;
        }
        
        public Song currentSong()
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }
        
    }
}