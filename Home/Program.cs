using System;

namespace H
{
    class Program
    {
        static void Main(string[] args)
        {
            object ob = new object();   
            ob.GetType();
            Team Russian = new Team("TryParse", "Russian");
            Team England = new Team("FastEat", "France");
            Team Ukraine = new Team("Свет должен быть внутри, а не на улице)", "Ukraine");
            Team China = new Team("Люблю Мышей!", "China");
            //Добавил Команд0чки
            List<Team> teams = new List<Team>() { Russian,England, Ukraine, China};
            Console.ReadKey();

            BigRaces Ganian = new BigRaces("Оливье Ганьян", teams, new Beach()); //Ганьян начинает Игрульку "Пляж"
            Ganian.Play();
            Console.ReadKey();

            Ganian.Game = new Mousetrap(); Ganian.Play(); //Ганьян начинает Игрульку "Мышеловка"
            Console.ReadKey();

            Ganian.Game = new Sea(); Ganian.Play();//Ганьян начинает Игрульку "Море"
            Console.ReadKey();
            Ganian.GetType();
            
            Ganian.Game = new Fishing(); Ganian.Play();//Ганьян начинает Игрульку "Рыбалка"
            Console.ReadKey();

            Ganian.Game = new Postmen(); Ganian.Play();//Ганьян начинает Игрульку "Почтальоны"
            Console.ReadKey();

            Ganian.Game = new Hill(); Ganian.Play();//Ганьян начинает Игрульку "Горка"
            Console.ReadKey();

            Console.WriteLine("Результаты команд на данный момент:\n");
            Ganian.PrintAllComands();

            Console.WriteLine("Полуфинал окончен. Наступает Финал!!!");
            Console.ReadKey();
            Ganian.Part();//Полуфинал окончен
            Ganian.Game = new Life(); Ganian.Play();//Ганьян начинает Игрульку "Жизнь"
            Console.ReadKey();
            Ganian.Part(); //Game Over
            Ganian.SayAboutWiners();//Winer'ЫЫЫЫЫЫЫЫЫЫЫЫЫ
        }
    }



}