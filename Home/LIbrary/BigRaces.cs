using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H
{
    public class BigRaces
    {
        string name;
        List<Team> teams;
        public void PrintAllComands()
        {
            foreach (Team t in teams)
            {
                Console.WriteLine(t.Title);
            }
        }
        public BigRaces(string name, List<Team> teams, IGame game)
        {
            this.name = name;
            this.teams = teams;
            Game = game;
        }
        private void DeleteComand(Team n)
        {
            teams.Remove(n);
        }
        public IGame Game { private get; set; }
        public void SayAboutWiners()
        {
            string s = "Победители:\n";
            for (int i = 0; i < teams.Count; i++)
            {
                s += $"{teams[i].Title}\n";
            }
            Console.WriteLine(s);
        }
        public void Play()
        {
            Game.PlayGame(teams);
            Console.WriteLine();
        }
        public void Part()
        {
            double max = double.MinValue;
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].GetScore > max)
                    max = teams[i].GetScore;
            }

            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].GetScore != max)
                    teams.Remove(teams[i]);
            }
        }
    }
}
