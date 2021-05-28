using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project8_refresher_
{
    interface IBird
    {
    


        double RandomDouble();
       


        string Color { get; }
        string Species { get; }




        string ChangeColor(string newColor);



        void Call();

        void Call(string call);



        bool Equals(object obj);


        int GetHashCode();
      

    }
}
