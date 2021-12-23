using System;
using System.Collections.Generic;
using System.Text;

namespace PracaDomowa5
{
    abstract class FootballPlayer
    {
        protected string name;
        protected string surname;
        protected int yearOfBirth;
        protected double height;
        protected double weight;

        public virtual string GetName()
        {
            return name;
        }
        public virtual string GetSurname()
        {
            return surname;
        }
        public virtual int GetYearOfBirth()
        {
            return yearOfBirth;
        }
        public virtual double GetHeight()
        {
            return height;
        }
        public virtual double GetWeight()
        {
            return weight;
        }
        public virtual void SetWeight(int w)
        {
            weight = w;
        }
        abstract public string GetPosition();
        



    }
}
