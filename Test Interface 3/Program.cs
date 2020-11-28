using System;

namespace Test_Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Music ");
            
            Phone m1 = new Phone("Booby Roy", "Anjun Dutt", 2000, 100);
            m1.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("Change Title");
            m1.changeTitle("Bobby Roy");
            m1.play(true);
            Console.WriteLine();
            Console.WriteLine("next track");
            m1.setVolume(5);
            Phone m2 = new Phone("Booby Roy", "Bobby Helms", 2020, 300);
            Phone m3 = new Phone("Booby Roy", "Booby Roy, 2020, 300);
            Phone m4 = new Phone("Booby Roy", "Booby Roy", 2020, 300);
            Phone list = new Phone();
            list.AddMusicFile(m2, m1, m3, m4);
            Console.WriteLine();
            Console.WriteLine("Next Music Info|");
            list.playNext();
            Console.WriteLine();
            Console.WriteLine("Previous Music Info");
            list.playPrevious();
            
            
            
            list.ShowAllMusicFile();
            
        }
    }
}
