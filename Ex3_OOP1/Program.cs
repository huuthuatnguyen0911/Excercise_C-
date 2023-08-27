using System;
using System.Collections.Generic;

class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Song> songs = new List<Song>();

        for (int i = 0; i < n; i++)
        {
            string[] songData = Console.ReadLine().Split('_');
            string typeList = songData[0];
            string name = songData[1];
            string time = songData[2];
            songs.Add(new Song { TypeList = typeList, Name = name, Time = time });
        }

        string filterType = Console.ReadLine();

        foreach (Song song in songs)
        {
            if (filterType == "all" || song.TypeList == filterType)
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}
