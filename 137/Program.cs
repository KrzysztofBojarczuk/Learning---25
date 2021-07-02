using System;
using System.IO;

namespace _137
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                try
                {

                    int user = InpuDate();

                    OutpuDate(user);
                    Console.WriteLine("Jesli chcesz zakończyć program wpisz Tak / tak. Jeśli chcesz dalej kontynować wciśjnij inny przycisk:");
                    string end = Console.ReadLine();
                    if (end.Equals("tak", StringComparison.CurrentCultureIgnoreCase))
                    {
                        break;
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }

        }

        private static void OutpuDate(int user)
        {
            Console.WriteLine("Czy chciałbyś odczydać dane?");
            Console.WriteLine("Jesli tak wpisz Tak / tak. Jeśli nie wciśjnij inny przycisk: ");
            string end = Console.ReadLine();
            if (end == "Tak" || end == "tak" || end == "tAk")
            {
                StreamReader outDate = new StreamReader("Cars.text");
                int index = 0;
                while (index < user && !outDate.EndOfStream)
                {


                    int age = int.Parse(outDate.ReadLine());
                    string make = outDate.ReadLine();
                    int speed = int.Parse(outDate.ReadLine());

                    Console.WriteLine((index + 1)+ $" Wiek samochodu: {age}. Marka samochodu: {make}. Prędkość samochodu: {speed}");


                }
                outDate.Close();
            }
        }

        private static int InpuDate()
        {
            Console.WriteLine("Ile samochodów chcesz wpisac do programu: ");
            int user = int.Parse(Console.ReadLine());

            StreamWriter inputDate = File.CreateText("Cars.text");
            for (int i = 0; i < user; i++)
            {

                Console.WriteLine("Pojazd nr: " + (i +1)+ " Wprowadź rok produkcji pojazdu: ");
                int age = int.Parse(Console.ReadLine());

                inputDate.WriteLine(age);
                Console.WriteLine("Pojazd nr: " + (i + 1) + " Wprowadź marke pojazdu: ");
                string make = Console.ReadLine();
                inputDate.WriteLine(make);
                Console.WriteLine("Pojazd nr: " + (i + 1) + " Wprowadź bieżącą prędkość samochodu: ");
                int speed = int.Parse(Console.ReadLine());
                inputDate.WriteLine(speed);

                Car car = new Car(age, make, speed);

            }
            inputDate.Close();
            return user;
        }
    }
}
