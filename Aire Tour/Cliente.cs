using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AireTour
{
    internal class Cliente
    {
        private int id { get; set; }
        private string? name { get; set; }
        private int des { get; set; }
        private int cla { get; set; }
        private int est { get; set; }
        private int dia { get; set; }
        private int gen { get; set; }
        public void mostCli(int value)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Digite su número de identificación");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" ");
            Console.Write("» ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Escriba su nombre completo");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("» ");
            name = Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Escoja el número del destino del vuelo:");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Bogotá");
            Console.WriteLine("2) Medellín");
            Console.WriteLine("3) Florencia");
            Console.WriteLine("4) Pitalito");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("» ");
            des = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Escoja el número de la clase de vuelo en el que viaja:");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Clase A");
            Console.WriteLine("2) Clase B");
            Console.WriteLine("3) Clase C");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("» ");
            cla = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Escoja el número del estrato socioeconómico que pertenece:");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Uno");
            Console.WriteLine("2) Dos");
            Console.WriteLine("3) Tres");
            Console.WriteLine("4) Cuatro");
            Console.WriteLine("5) Cinco");
            Console.WriteLine("6) Seis");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("» ");
            est = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Escoja el número del día que desea realizar el vuelo:");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Lunes");
            Console.WriteLine("2) Martes");
            Console.WriteLine("3) Miercoles");
            Console.WriteLine("4) Jueves");
            Console.WriteLine("5) Viernes");
            Console.WriteLine("6) Sabado");
            Console.WriteLine("7) Domingo");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("» ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Escriba el número de su género");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Femenino");
            Console.WriteLine("2) Masculino");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("» ");
            gen = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            int val = 0;
            switch (des)
            {
                case 1:
                    if (cla == 1)
                    {
                        val = 300000;
                        Console.ReadKey();
                    }
                    else if (cla == 2) 
                    {
                        val = 225000;
                    }
                    else if (cla == 3)
                    {
                        val = 150000;
                    }
                    break;

                case 2:
                    if (cla == 1)
                    {
                        val = 420000;
                    }
                    else if (cla == 2)
                    {
                        val = 315000;
                    }
                    else if (cla == 3)
                    {
                        val = 210000;
                    }
                    break;

                case 3:
                    if (cla == 1)
                    {
                        val = 270000;
                    }
                    else if (cla == 2)
                    {
                        val = 202500;
                    }
                    else if (cla == 3)
                    {
                        val = 135000;
                    }
                    break;

                case 4:
                    if (cla == 1)
                    {
                        val = 250000;
                    }
                    else if (cla == 2)
                    {
                        val = 187500;
                    }
                    else if (cla == 3)
                    {
                        val = 125000;
                    }
                    break;
            }

            double desEst = 0.0;
            if (est == 1 || est == 2)
                desEst = 0.10;
            else if (est == 3 || est == 4)
                desEst = 0.07;
            else if (est == 5 || est == 6)
                desEst = 0.05;

            double desDia = 0.0;
            if (dia <= 3)
                desDia = 0.10;
            else if (dia == 4 || dia == 5)
                desDia = 0.05;

            double desGen = 0.0;
            if (gen == 1)
            {
                desGen = 0.03;
            }
            else{
                desGen = 0.0;
            }

            double valDes = val * (desEst + desDia + desGen);
            double valTot = val - valDes;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    RESUMEN DEL VUELO");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Identificación: " + id);
            Console.WriteLine("Nombre completo: " + name);
            Console.WriteLine($"Género: {(gen == 1 ? "Femenino" : "Masculino")}");
            Console.WriteLine($"Destino: {(des == 1 ? "Bogotá" : (des == 2 ? "Medellín" : (des == 3 ? "Florencia" : "Pitalito")))}");
            Console.WriteLine($"Clase: {(cla == 1 ? "A" : (cla == 2 ? "B" : "C"))}");
            Console.WriteLine("Estrato: " + est);
            Console.WriteLine($"Día de la semana: {(dia == 1 ? "Lunes" : (dia == 2 ? "Martes" : (dia == 3 ? "Miércoles" : (dia == 4 ? "Jueves" : (dia == 5 ? "Viernes" : (dia == 6 ? "Sábado" : "Domingo"))))))}");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Valor sin descuento: $" + val);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Descuento total: $" + valDes);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Valor a pagar: $" + valTot);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Digite cualquier tecla para salir");
            Console.Write("...");
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--------------------------");
            Console.WriteLine("Gracias por usar AIRE TOUR");
            Console.WriteLine("--------------------------");
            Console.ForegroundColor = ConsoleColor.White;

        }

    }

}
