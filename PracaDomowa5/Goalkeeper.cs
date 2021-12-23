using System;
using System.Collections.Generic;
using System.Text;

namespace PracaDomowa5
{
    class Goalkeeper : FootballPlayer, Shoutable
    {
        
        public Goalkeeper(string n,string s,int y, double h, double w)
        {
            name = n;
            surname = s;
            yearOfBirth = y;
            height = h;
            weight = w;
        }
      
        public override string GetPosition()
        {
            return "Bramkarz";
        }

        public string GetShout()
        {
            return "Jeeeeeeeeeeeeeeeeeeeeee";
        }
    }
}
