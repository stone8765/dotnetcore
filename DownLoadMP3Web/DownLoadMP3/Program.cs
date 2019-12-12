using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownLoadMP3
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicEntities db = new MusicEntities();
            int start = 1;
            if (args.Length > 0)
            {
                if (!int.TryParse(args[0], out start))
                {
                    start = 1;
                }
            }
            else
            {
                start = db.Music.Max(e => e.Id);
            }

            int max = 1000000;
            if (args.Length > 1)
            {
                if (!int.TryParse(args[1], out max))
                {
                    max = 1000000;
                }
            }

            for (var i = start; i < max; i++)
            {
                if (!db.Music.AsNoTracking().Any(e => e.Id == i))
                {
                    var music = DownLoadHelper.GetMusicById(i);
                    if (string.IsNullOrWhiteSpace(music.Name))
                    {
                        break;
                    }
                    db.Music.Add(music);
                    db.SaveChanges();
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("完成");

            Console.Read();
        }
    }
}
