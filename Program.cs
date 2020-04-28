using System;

namespace Laboratornaya_4
{
    class Program
    {
        static void Main(string[] args)
        {
            File f = new File("file_1.doc",256);
            Console.WriteLine(f.ToString());
            Mp3 m = new Mp3("Music.mp3", 12);
            Console.WriteLine(m.ToString());
            Archive a = new Archive("Lab4.rar", 3);
            Console.WriteLine(a.ToString());
            Directory d = new Directory("Windows");
            Console.WriteLine(d.ToString());
            d.create(f);
            d.create(f);
            d.create(m);
            d.create(a);
            d.create(m);
            d.create(m);
            Console.WriteLine(d.ToString());
            Console.WriteLine("Volume directory: "+d.GetVolume());
            int x = d.KolAudio();
            Console.WriteLine("Kolichestvo audio: " + x);
            f.RunFile();

            Directory d1 = new Directory("D1");
            d1.create(f);
            Console.WriteLine(d1.ToString());
            d.create(d1);
            Console.WriteLine(d.ToString());




        }
    }
}
