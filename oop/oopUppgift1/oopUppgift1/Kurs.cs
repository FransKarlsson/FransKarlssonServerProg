using System;
using System.Collections.Generic;
using System.Text;

namespace oopUppgift1
{
    class Kurs
    {
        public string namn;
        public string KursID;
        public string startDatum;
        public string slutDatum;

        public Kurs(string aNamn, string aKursID, string aStartDatum, string aSlutDatum)
        {
            namn = aNamn;
            KursID = aKursID;
            startDatum = aStartDatum;
            slutDatum = aSlutDatum;
        }
        public void Description()
        {
            Console.WriteLine($"{this.namn}. This courses ID is {KursID}, it started {startDatum} and it wil end {slutDatum} \n");
        }
    }
}
