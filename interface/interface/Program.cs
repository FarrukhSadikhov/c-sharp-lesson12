using System;

namespace inter
{
    interface IInstrument
    {
        static string KEY = "До мажор";
        void Play();
    }
    class Guitar : IInstrument
    {
        private int guitarstrun;
        public int GuitarStrun
        {
            get { return guitarstrun; }
            set { guitarstrun = value; }
        }
        public void Play()
        {
            if (GuitarStrun == 4)
            {
                Console.WriteLine($"Играет {GuitarStrun} струнная классическая басс гитара {IInstrument.KEY}");
            }
            else if (GuitarStrun == 5)
            {
                Console.WriteLine($"Играет {GuitarStrun} струнная басс гитара {IInstrument.KEY}");
            }
            else if (GuitarStrun == 6)
            {
                Console.WriteLine($"Играет {GuitarStrun} струнная классичкская гитара  {IInstrument.KEY}");
            }
            else if (GuitarStrun == 7)
            {
                Console.WriteLine($"Играет {GuitarStrun} струнная русская гитара  {IInstrument.KEY} ");
            }
            else if (GuitarStrun == 8)
            {
                Console.WriteLine($"Играет {GuitarStrun} струнная электро гитара  {IInstrument.KEY} ");
            }
            else if (GuitarStrun == 12)
            {
                Console.WriteLine($"Играет акустичксая гитара {GuitarStrun} {IInstrument.KEY}");
            }         
        }
    }
    class Drum : IInstrument
    {
        private int size;
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public void Play()
        {
            Console.WriteLine($"Играет барабан {Size} см размером {IInstrument.KEY}");
        }
    }
    class Trumped : IInstrument
    {
        private int diametr;
        public int Diametr 
        {
            get { return diametr; }
            set { diametr = value; }
        }
        public void Play()
        {
            Console.WriteLine($"Играет труба диаметром {Diametr} см {IInstrument.KEY}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число струн 'классическая басс 4''басс 5''классичecская 6''русская 7''электро 8''акустичecкая 12' гитары ");
            Guitar guitar = new Guitar();
            guitar.GuitarStrun = ValidationGuitar();
            Console.WriteLine("Введите размер барабана от 20см до 120см");
            Drum drum = new Drum();
            drum.Size = ValidationDrum();
            Console.WriteLine("Введите диаметр трубы от 10см до 40 см");
            Trumped trumped = new Trumped();
            trumped.Diametr = ValidationTrumped();            
            IInstrument[] instruments = {guitar, drum, trumped };
            for (int i = 0; i < instruments.Length; i++)
            {
                instruments[i].Play();
            }
            Console.ReadKey();
        }
        public static int ValidationGuitar()
        {
            int n;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out n))
                {
                    if (n >= 4 && n <= 8 )
                    {
                        return n;
                    }
                    else if (n == 12)
                    {
                        return n;
                    }
                    else 
                    {
                        Console.WriteLine("Такое гитары нет!");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка!!!Введите корректные данные");
                }
            }
            while (true);
        }
        public static int ValidationDrum()
        {
            int n;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out n))
                {
                    if (n >=20 && n <=120 )
                    {
                        return n;
                    }                                   
                    else
                    {
                        Console.WriteLine("Такого барабана нет!");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка!!!Введите корректные данные");
                }
            }
            while (true);
        }
        public static int ValidationTrumped()
        {
            int n;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out n))
                {
                    if (n >= 10 && n <= 40)
                    {
                        return n;
                    }
                    else
                    {
                        Console.WriteLine("Такой трубы нет!");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка!!!Введите корректные данные");
                }
            }
            while (true);
        }
    }
    
}
