using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DetGameTho
{
    class Locations
    {
        public int ID;
        public string Name;
        public string Discription;
        private int Status; //99 = Default
        private Random locrandom = new Random();
        private string[,] LocNames = new string[100, 2];
        

        //Constructor

        public Locations()
        {
            ID = 0;
            Name = "Null";
            Discription = "Null";
            Status = 99;
        }

        public Locations(int id)
        {
            ID = id;
            int i = 0;
            // Randomberechnung
            string filePath = System.IO.Path.GetFullPath("Locs.txt");
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    i++;
                }
                using (StreamReader sr2 = new StreamReader(filePath))
                    for (int u = 0; u <= i; u++)
                    {
                        LocNames[u, 0] = sr2.ReadLine();
                    }
                filePath = System.IO.Path.GetFullPath("LocsDiscription.txt");
                using (StreamReader sr3 = new StreamReader(filePath))
                {
                    for (int u = 0; u <= i; u++)
                    {
                        LocNames[u, 1] = sr3.ReadLine();
                    }
                }

            }
            int rd = locrandom.Next(0, i);
            Name = LocNames[rd,0];
            Discription = LocNames[rd, 1];
            
        }

    }
}
