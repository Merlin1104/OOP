using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Dom
    {
        private string nazov, typ, poschodie;
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
    }




}
