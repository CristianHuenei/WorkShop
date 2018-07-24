using Composite.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            SectorAdministracion admin = new SectorAdministracion();
            SectorCajas cajas = new SectorCajas();
            SectorRRHH rrhh = new SectorRRHH();
            SectorContaduria contaduria = new SectorContaduria();

            banco.Agregar(admin);
            banco.Agregar(cajas);
            banco.Agregar(rrhh);
            banco.Agregar(contaduria);


            Empleado gerentaAdmin = new Empleado("Gerenta Admin", "Gerenta", 39000);
            Empleado asistenteAdmin = new Empleado("Asistente1", "Asistente", 20000);
            admin.Agregar(gerentaAdmin);
            admin.Agregar(asistenteAdmin);

            Empleado cajero1 = new Empleado("Cajero1", "Cajero", 35000);
            Empleado cajero2 = new Empleado("Cajero2", "Cajero", 35000);
            Empleado cajero3 = new Empleado("Cajero3", "Cajero Jr.", 25000);
            cajas.Agregar(cajero1);
            cajas.Agregar(cajero2);
            cajas.Agregar(cajero3);


            Empleado gerenta1 = new Empleado("Gerenta RR.HH.", "Gerenta", 55000);
            Empleado asistente1 = new Empleado("Asistente1", "Asistente RR. HH.", 20000);
            Empleado asistente2 = new Empleado("Asistente2", "Asistente RR. HH.", 20000);
            rrhh.Agregar(gerenta1);
            rrhh.Agregar(asistente1);
            rrhh.Agregar(asistente2);

            Empleado contador1 = new Empleado("Contador1", "Contador", 47000);
            contaduria.Agregar(contador1);

            Console.WriteLine("El banco tiene una carga salarial de: ${0}", banco.GetSueldo());
            Console.ReadLine();
        }
    }
}
