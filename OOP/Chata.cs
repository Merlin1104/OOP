using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Chata : Dom
    {
        private string spolocenskaMistnost;

        public Chata (string nazov, string typ, string poschodie, int obytneMiestnosti, float uzitkovaPlocha, float zastavanaPlocha, string spolocenskaMistnost) 
                      :base(nazov,typ,poschodie,obytneMiestnosti,uzitkovaPlocha,zastavanaPlocha)
        {
            this.spolocenskaMistnost = spolocenskaMistnost;

        }

        public void PopisChaty()
        {
            
            Console.WriteLine("Spolocenska miestnost: {0} ",spolocenskaMistnost);
        }

        public new void PoskytniInformace()
        {
            Console.WriteLine("Parametre domu: ");
            Console.WriteLine("Nazov: {0} \nTyp: {1} \nPoschodie: {2} ", nazov, typ, poschodie);
        }
    }

}
