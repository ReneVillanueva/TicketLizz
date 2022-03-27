using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Ticketsss
{
    internal class Ficheros
    {
        public double Precio { get; set; }

        public Ficheros()
        {
            this.Precio = 0;

        }

        public void AgregarTextoAfichero(string producto, double cantidad, double Pr2)
        {


            StreamWriter fichero;
            string nombreFichero = "\\Ticket.txt";
            fichero = File.AppendText(nombreFichero);
            fichero.WriteLine("Producto: " + producto + " Cant: " + cantidad + " Precio individual: " + Pr2);
            fichero.WriteLine("Total= " + Precio);
            this.Precio += Pr2;
            fichero.Close();

        }
        public void LeerDocumento()
        {
            StreamReader fichero;
            string nombreFichero = "\\Ticket.txt";
            string linea;

            fichero = File.OpenText(nombreFichero);
            do
            {
                linea = fichero.ReadLine();
                Console.WriteLine(linea);

            } while (linea != null);
            fichero.Close();
            Console.ReadKey();
        }
    }
}