using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CalcSigInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            string mes;

            WriteLine("********** Programa interpretador de signos **********");
            WriteLine("");
            Write("Por favor, informe o dia em que você nasceu: ");
            dia = ReadLine();
            WriteLine("");
            Write("Agora, informe de que mês: ");
            mes = ReadLine();
            WriteLine("");
            WriteLine("******************************************************");
            WriteLine("");

            int diaInt = 0;
            int mesInt = 0;

            try
            {
                diaInt = Convert.ToInt32(dia);
                mesInt = Convert.ToInt32(mes);
            }
            catch (FormatException e)
            {
                WriteLine(e.Message);
                ReadKey();
                Environment.Exit(1);
            }

            InterpretadorSignos interpretador = new InterpretadorSignos();
            Signo signo = interpretador.Interpretar(diaInt, mesInt);

            if(signo != null)
            {
                //WriteLine("Seu signo é " + signo.nome +", " + signo.caracteristicas);
                WriteLine($"Seu signo é {signo.nome}, {signo.caracteristicas}.");
            }
            else
            {
                WriteLine("Dados inseridos incorretamente, por favor, tente novamente.");
            }
            ReadKey();
        }
    }
}
