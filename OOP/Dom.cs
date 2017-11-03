using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Dom
    {
        protected string nazov, typ, poschodie;
        private int obytneMiestnosti;
        private float uzitkovaPlocha, zastavanaPlocha;

        public Dom (string nazov, string typ, string poschodie,
                    int obytneMiestnosti, float uzitkovaPlocha, 
                    float zastavanaPlocha)
        {
            this.nazov = nazov;
            this.typ = typ;
            this.poschodie = poschodie;
            this.obytneMiestnosti = obytneMiestnosti;
            this.uzitkovaPlocha = uzitkovaPlocha;
            this.zastavanaPlocha = zastavanaPlocha;
        }

       

        public void PoskytniInformace()
        {
            Console.WriteLine("Parametre domu: ");
            Console.WriteLine("Nazov: {0} \nTyp: {1} \nPoschodie: {2} ", nazov,typ,poschodie);
        }

        public float ZistiVyuzitelnostZastavanejPlochy()
        {
            return zastavanaPlocha / uzitkovaPlocha  * 100;
        }
    }




}
