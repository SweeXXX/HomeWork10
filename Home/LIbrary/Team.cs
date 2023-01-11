using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H
{

    public class Team
    {
        double score;
        string name;
        string country;
        internal Team(string name, string country)
        {
            this.name = name;
            this.country = country;
        }
        internal void AddScore(double n = 5)
        {
            score += n;
        }
        internal void TakeOfScore(double n = 5)
        {
            score -= n;
        }
        internal double GetScore { get { return score; } }
        public string Title
        {
            get { return $"\"{name}\" - {country}: {score}"; }
        }
    }
}
