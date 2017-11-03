using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dom mujDom = new Dom("Aktiv 1", "aktivny", "nie", 3, 70.9f, 35.8f);
            mujDom.PoskytniInformace();
            Console.WriteLine("Percento zastavanej plochy je: {0}",mujDom.ZistiVyuzitelnostZastavanejPlochy());

            Dom susedovDom = new Dom("Aktiv 2", "aktivny", "nie", 4, 100.9f, 35.8f);
            susedovDom.PoskytniInformace();
            Console.WriteLine("Percento zastavanej plochy je: {0}", susedovDom.ZistiVyuzitelnostZastavanejPlochy());

            Chata chata = new Chata("Chata 1","Pasivne", "10",50,200.5f,100,"ano a velka");
            
            chata.PoskytniInformace();
            chata.PopisChaty();


            Console.ReadLine();
        }
    }
}
