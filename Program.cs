using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace DetGameTho
{
    class Program
    {
        static int[,] i_map = new int[100, 100];
        static int i_curpos_x = new int();
        static int i_curpos_y = new int();
        static int i_lastid = new int();
        static Locations[] loc1 = new Locations[999];
        static Random random = new Random();

        static void Main(string[] args)
        {
            //INIT
            i_lastid = 0;
            i_curpos_x = 50;
            i_curpos_y = 50;
            Console.WriteLine("Willkommen zum TestRPG!");
            Abfrage: // GOTO ABFRAGE
            Console.WriteLine("Gebe V ein um nach Vorne zu gehen, gebe Z ein um Zurück zu gehen, L um nach Links zu gehen und R um nach Rechts zu gehen.");
            ConsoleKeyInfo info = Console.ReadKey();
            Console.Clear(); //Bisheriger Text wird gecleart
            //Richtungsabfrage und Bewegung
            if (info.KeyChar == 'V')
            #region VORWÄRTS
            {
                Thread.Sleep(500);
                i_curpos_y++;
                if (i_map[i_curpos_x, i_curpos_y] == 0)  //Wenn Ort noch nicht besucht, dann neue Location mit neuer ID anlegen
                {
                    int nextid = i_lastid++;
                    loc1[nextid] = new Locations(nextid);
                    i_map[i_curpos_x, i_curpos_y] = loc1[nextid].ID;
                }
                //Console.WriteLine(Convert.ToString(i_map[i_curpos_x, i_curpos_y]));
                //Console.WriteLine(Convert.ToString(i_curpos_x + " " + i_curpos_y));
                Console.WriteLine(loc1[(i_map[i_curpos_x,i_curpos_y])].Name);
                Console.WriteLine(loc1[(i_map[i_curpos_x, i_curpos_y])].Discription);
                Console.WriteLine(" ");
                goto Abfrage;
            }
            #endregion
            if (info.KeyChar == 'Z')
            #region ZURÜCK
            {
                Thread.Sleep(500);
                i_curpos_y--;
                if (i_map[i_curpos_x, i_curpos_y] == 0)
                {
                    int nextid = i_lastid++;
                    loc1[nextid] = new Locations(nextid);
                    i_map[i_curpos_x, i_curpos_y] = loc1[nextid].ID;
                }
                //Console.WriteLine(Convert.ToString(i_map[i_curpos_x, i_curpos_y]));
                //Console.WriteLine(Convert.ToString(i_curpos_x+" "+i_curpos_y));
                Console.WriteLine(loc1[(i_map[i_curpos_x, i_curpos_y])].Name);
                Console.WriteLine(loc1[(i_map[i_curpos_x, i_curpos_y])].Discription);
                Console.WriteLine(" ");
                goto Abfrage;
            }
            #endregion
            if (info.KeyChar == 'L')
            #region LINKS
            {
                Thread.Sleep(500);
                i_curpos_x--;
                if (i_map[i_curpos_x, i_curpos_y] == 0)
                {
                    int nextid = i_lastid++;
                    loc1[nextid] = new Locations(nextid);
                    i_map[i_curpos_x, i_curpos_y] = loc1[nextid].ID;
                }
                //Console.WriteLine(Convert.ToString(i_map[i_curpos_x, i_curpos_y]));
                //Console.WriteLine(Convert.ToString(i_curpos_x + " " + i_curpos_y));
                Console.WriteLine(loc1[(i_map[i_curpos_x, i_curpos_y])].Name);
                Console.WriteLine(loc1[(i_map[i_curpos_x, i_curpos_y])].Discription);
                Console.WriteLine(" ");
                goto Abfrage;
            }
            #endregion
            if (info.KeyChar == 'R')
            #region RECHTS
            {
                Thread.Sleep(500);
                i_curpos_x++;
                if (i_map[i_curpos_x, i_curpos_y] == 0)
                {
                    int nextid = i_lastid++;
                    loc1[nextid] = new Locations(nextid);
                    i_map[i_curpos_x, i_curpos_y] = loc1[nextid].ID;
                }
                //Console.WriteLine(Convert.ToString(i_map[i_curpos_x, i_curpos_y]));
                //Console.WriteLine(Convert.ToString(i_curpos_x + " " + i_curpos_y));
                Console.WriteLine(loc1[(i_map[i_curpos_x, i_curpos_y])].Name);
                Console.WriteLine(loc1[(i_map[i_curpos_x, i_curpos_y])].Discription);
                Console.WriteLine(" ");
                goto Abfrage;
            }
            #endregion

            Console.WriteLine("Ungültiger Befehl!");
            goto Abfrage;
        }

        public void LocationsEinlesen()
        {
            
        }
    }
}
