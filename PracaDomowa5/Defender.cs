using System;
using System.Collections.Generic;
using System.Text;

namespace PracaDomowa5
{
    class Defender : FootballPlayer,Shoutable
    {
        private bool redCard;
        public Defender(string n, string s, int y, double h, double w)
        {
            name = n;
            surname = s;
            yearOfBirth = y;
            height = h;
            weight = w;
            redCard = false;
        }
        public virtual string GetRedCard()
        {
            if (redCard == false)
            {
                return "otrzymal czerwona kartke";
            }
            else
                return "nie otrzymal czerwonej kartki";
           
        }
        public virtual void SetRedCard(bool r)
        {
            redCard = r;
        }
        public override string GetPosition()
        {
            return "Obronca";
        }

        public string GetShout()
        {
            return "Juuuuuhuuuuuuuu";
        }
    }
}
