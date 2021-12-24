using System;

namespace PracaDomowa5
{
    class Program
    {
        static void Main(string[] args)
        {
            FootballPlayer footballPlayer = new Goalkeeper("Adam","Paliwodka",1994,196,91);
            FootballPlayer footballPlayer2 = new Defender("Bartosz","Fajrant",2002,189,77);
            /*Console.WriteLine($"{footballPlayer.GetPosition()} {footballPlayer.GetName()} {footballPlayer.GetSurname()} urodzony w {footballPlayer.GetYearOfBirth()}roku o wzroscie {footballPlayer.GetHeight()}cm i wadze {footballPlayer.GetWeight()}kg dolaczyl do szeregow naszego klubu");
            Console.WriteLine($"{footballPlayer2.GetWeight()}");
            footballPlayer2.SetWeight(87);
            Console.WriteLine($"{footballPlayer2.GetWeight()}");*/
            FootballPlayer footballPlayer1 = AddFootballPlayer();
            GetInfoFootballPlayer(footballPlayer1);
        }
        public static FootballPlayer AddFootballPlayer()
        {
            Console.WriteLine("Podaj pozycje zawodnika, ktorego chcesz przedstawic(G,D,M,F): ");
            string fposition = Console.ReadLine();
            Console.WriteLine("Podaj imie: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            string fsurname = Console.ReadLine();
            Console.WriteLine("Podaj rok urodzenia: ");
            int fyear = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost: ");
            double fheight = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wage: ");
            double fweight = Double.Parse(Console.ReadLine());

            FootballPlayer newFootballPlayer;

            switch(fposition)
            {
                case "G":
                    {
                        newFootballPlayer = new Goalkeeper(fname,fsurname,fyear,fheight,fweight);
                        break;
                    }
                case "D":
                    {                                           
                        newFootballPlayer = new Defender(fname, fsurname, fyear, fheight, fweight);
                        break;
                      }
                case "M":
                    {
                        newFootballPlayer = new Midfielder(fname, fsurname, fyear, fheight, fweight);
                        break;
                    }
                case "F":
                    {
                        newFootballPlayer = new Forward(fname, fsurname, fyear, fheight, fweight);
                        break;
                    }

                default:
                    {
                        newFootballPlayer = null;
                        break;
                    }
            }

            return newFootballPlayer;
        }
        public static void GetInfoFootballPlayer(FootballPlayer footballPlayer)
        {
            if(footballPlayer is Goalkeeper)
            {
                Console.WriteLine($"{footballPlayer.GetPosition()} {footballPlayer.GetName()} {footballPlayer.GetSurname()} urodzony w {footballPlayer.GetYearOfBirth()}roku o wzroscie {footballPlayer.GetHeight()}cm i wadze {footballPlayer.GetWeight()}kg dolaczyl do szeregow naszego klubu");
                Goalkeeper goalkeeper = (Goalkeeper)footballPlayer;
                Console.WriteLine($"{goalkeeper.GetShout()}");
            }
            else if(footballPlayer is Defender)
            {
                Console.WriteLine($"{footballPlayer.GetPosition()} {footballPlayer.GetName()} {footballPlayer.GetSurname()} urodzony w {footballPlayer.GetYearOfBirth()}roku o wzroscie {footballPlayer.GetHeight()}cm i wadze {footballPlayer.GetWeight()}kg dolaczyl do szeregow naszego klubu");
                Defender defender = (Defender)footballPlayer;
                Console.WriteLine($"{defender.GetShout()}");
            }
            else if(footballPlayer is Midfielder)
            {
                Console.WriteLine($"{footballPlayer.GetPosition()} {footballPlayer.GetName()} {footballPlayer.GetSurname()} urodzony w {footballPlayer.GetYearOfBirth()}roku o wzroscie {footballPlayer.GetHeight()}cm i wadze {footballPlayer.GetWeight()}kg dolaczyl do szeregow naszego klubu");
                Midfielder midfielder = (Midfielder)footballPlayer;
                Console.WriteLine($"{midfielder.GetShout()}");
            }
            else if(footballPlayer is Forward)
            {
                Console.WriteLine($"{footballPlayer.GetPosition()} {footballPlayer.GetName()} {footballPlayer.GetSurname()} urodzony w {footballPlayer.GetYearOfBirth()}roku o wzroscie {footballPlayer.GetHeight()}cm i wadze {footballPlayer.GetWeight()}kg dolaczyl do szeregow naszego klubu");
                Forward forward = (Forward)footballPlayer;
                Console.WriteLine($"{forward.GetShout()}");
            }
            else
            {
                Console.WriteLine("Nie ma zawodnika na takiej pozycji");
            }
        }
    }
}
