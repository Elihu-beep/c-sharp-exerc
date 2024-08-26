using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T30_Interface
{
    //Voitaisiin käyttää pelikehityksessä hyvin yksinkertaisena esimerkkinä näin
   public interface IWeapon
    {
        void Fire();
        void Reload();
    }

    public class PlasmaGun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine("PlasmaGun firing");
        }

        public void Reload()
        {
            Console.WriteLine("Reloading PlasmaGun");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IWeapon plasmaGun = new PlasmaGun();
            plasmaGun.Fire();
            plasmaGun.Reload();
        }
    }
}