using System;
using System.Collections.Generic;
using System.IO;

namespace MovieCapstone
{
    public class MovieRepo
    {

        public async void ReadMovieFile()
        {
            List<string> list = new List<string>();
            String filename = "/Users/hemory/Desktop/MovieList.txt";
            Char[] buffer;

            using (var sr = new StreamReader(filename))
            {
                buffer = new Char[(int)sr.BaseStream.Length];
                await sr.ReadAsync(buffer, 0, (int)sr.BaseStream.Length);
            }

            Console.WriteLine(new String(buffer));
        }

        public void WriteMovieFile()
        {
            Console.WriteLine("Add Movie using the following context: Genre: {INSERT GENRE}  Title: {INSERT TITLE} Actor: {INSERT ACTOR}");
            var movieEntry = Console.ReadLine().ToUpper();
            using (StreamWriter writer = new StreamWriter("/Users/hemory/Desktop/MovieList.txt", true))
            {
                writer.WriteLine(movieEntry);
            }




        }
    }
}

