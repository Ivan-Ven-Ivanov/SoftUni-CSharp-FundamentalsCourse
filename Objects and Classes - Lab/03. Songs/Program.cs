using System;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < songsCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("_")
                    .ToArray();

                string typeList = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song(typeList, name, time);
                songs.Add(song);
            }

            string lastCommand = Console.ReadLine();
            if (lastCommand == "all")
            {
                foreach(Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredSongs = songs.Where(x => x.TypeList == lastCommand)
                    .ToList();
                foreach(Song song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }

    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}