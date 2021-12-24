using System;
using System.Collections.Generic;
using System.Text;

namespace PracaDomowa5
{
    class Midfielder : FootballPlayer, Shoutable
    {
        public Midfielder(string n, string s, int y, double h, double w)
        {
            name = n;
            surname = s;
            yearOfBirth = y;
            height = h;
            weight = w;
        }

        public override string GetPosition()
        {
            return "Obronca"; ;
        }

        public string GetShout()
        {
            return "alealeale";
        }
    }
}
