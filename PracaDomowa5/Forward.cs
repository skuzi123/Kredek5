using System;
using System.Collections.Generic;
using System.Text;

namespace PracaDomowa5
{
    class Forward : FootballPlayer, Shoutable
    {
        public Forward(string n, string s, int y, double h, double w)
        {
            name = n;
            surname = s;
            yearOfBirth = y;
            height = h;
            weight = w;
        }

        public override string GetPosition()
        {
            return "Napastnik";
        }

        public string GetShout()
        {
            return "LEWANDOWSKI ORZEL Z POLSKIIIIIII";
        }
    }
}
