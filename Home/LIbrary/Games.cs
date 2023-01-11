using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H
{
    public interface IGame
    {
        public void PlayGame(List<Team> teams);

    }
    public class Beach : IGame
    {

        public void PlayGame(List<Team> teams)
        {
            Random rand = new Random();
            int r = rand.Next(0, teams.Count);

            teams[r].AddScore();
            teams[((r + 1) % teams.Count)].TakeOfScore();
            Console.WriteLine($"На этапе Пляж Победила Команда: {teams[r].Title}");
            Console.WriteLine($"На этапе Пляж Проиграла Команда: {teams[((r + 1) % teams.Count)].Title}");
        }
    }
    public class Mousetrap : IGame
    {
        public void PlayGame(List<Team> teams)
        {
            Random rand = new Random();
            int r = rand.Next(0, teams.Count);

            teams[r].AddScore();
            teams[((r + 1) % teams.Count)].TakeOfScore();
            Console.WriteLine($"На этапе Мышеловка Победила Команда: {teams[r].Title}");
            Console.WriteLine($"На этапе Мышеловка Проиграла Команда: {teams[((r + 1) % teams.Count)].Title}");
        }
    }
    public class Sea : IGame
    {
        public void PlayGame(List<Team> teams)
        {
            Random rand = new Random();
            int r = rand.Next(0, teams.Count);

            teams[r].AddScore();
            teams[((r + 1) % teams.Count)].TakeOfScore();
            Console.WriteLine($"На этапе Море Победила Команда: {teams[r].Title}");
            Console.WriteLine($"На этапе Море Проиграла Команда: {teams[((r + 1) % teams.Count)].Title}");
        }
    }
    public class Fishing : IGame
    {
        public void PlayGame(List<Team> teams)
        {
            Random rand = new Random();
            int r = rand.Next(0, teams.Count);

            teams[r].AddScore();
            teams[((r + 1) % teams.Count)].TakeOfScore();
            Console.WriteLine($"На этапе Рыбалка Победила Команда: {teams[r].Title}");
            Console.WriteLine($"На этапе Рыбалка Проиграла Команда: {teams[((r + 1) % teams.Count)].Title}");
        }
    }
    public class Postmen : IGame
    {
        public void PlayGame(List<Team> teams)
        {
            Random rand = new Random();
            int r = rand.Next(0, teams.Count);

            teams[r].AddScore();
            teams[((r + 1) % teams.Count)].TakeOfScore();
            Console.WriteLine($"На этапе Почтальоны Победила Команда: {teams[r].Title}");
            Console.WriteLine($"На этапе Почтальоны Проиграла Команда: {teams[((r + 1) % teams.Count)].Title}");
        }
    }
    public class Hill : IGame
    {
        public void PlayGame(List<Team> teams)
        {
            Random rand = new Random();
            int r = rand.Next(0, teams.Count);

            teams[r].AddScore();
            teams[((r + 1) % teams.Count)].TakeOfScore();
            Console.WriteLine($"На этапе Горка Победила Команда: {teams[r].Title}");
            Console.WriteLine($"На этапе Горка Проиграла Команда: {teams[((r + 1) % teams.Count)].Title}");
        }
    }
    public class Life : IGame
    {
        public void PlayGame(List<Team> teams)
        {
            Random rand = new Random();
            int r = rand.Next(0, teams.Count);

            teams[r].AddScore();
            teams[((r + 1) % teams.Count)].TakeOfScore();
            Console.WriteLine($"На этапе Жизнь Победила Команда: {teams[r].Title}");
            Console.WriteLine($"На этапе Жизнь Проиграла Команда: {teams[((r + 1) % teams.Count)].Title}");
        }
    }
}
