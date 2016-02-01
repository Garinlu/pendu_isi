using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Pendu
{
    class Partie
    {
        private String echecList;
        private int echecNumber;
        private ArrayList listEchec;
        

        public Partie()
        {
            echecNumber = 0;
            echecList="";
            listEchec = new ArrayList();
        }


      
        public void addEchec(Char c)
        {
            listEchec.Add(c);
            echecNumber++;
            echecList = echecList + c;
        }


        public int getnoEchec()
        {
            return echecNumber;
        }

        public String getEchecList()
        {
            return echecList;
        }

        public ArrayList getlistEchec()
        {
            return listEchec;
        }
    }
}
