using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;

namespace EjerciciosRepaso
{
    public class Funciones
    {
        public static bool EsMultiplo (int numero, int multiplo)
        {
            if(numero%multiplo==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double CalcularDoubleDelMedio(List<double> numeros)
        {
            numeros.Sort();
            int posicionDelMedio = (numeros.Count() / 2) + (numeros.Count() % 2) - 1;
            double numeroIntermedio = numeros[posicionDelMedio];
            return numeroIntermedio;
        }

        public static string OrdenarLetrasPalabra(string palabra)
        {
            char[] letrasPalabra = palabra.ToArray();
            Array.Sort(letrasPalabra);
            string palabraOrdenada = new String(letrasPalabra);
            return palabraOrdenada;
        }

        public static string InvertirLetrasPalabra(string palabra)
        {
            string palabraInvertida = "";
            foreach (char letra in palabra)
            {
                palabraInvertida = letra + palabraInvertida;
            }
            return palabraInvertida;
        }

        public static bool EsPrimo(int numero)
        {
            if (numero == 1 || numero ==0)
            {
                return false;
            }
            else
            {
                for (int divisor = 2; divisor < numero; divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        return false;
                    }
                }
            }            
            return true;
        }

        public static int ContarDiasIntervalo(DateTime fecha1, DateTime fecha2)
        {
            TimeSpan intervalo = (fecha1 - fecha2);
            int valor = intervalo.Days;
            return valor;
        }
        public static int ContarCantidadCaracteres (string numero)
        {
            List<char> digitos = new List<char>();
            digitos = numero.ToList();
            int cantDigitos = digitos.Count();
            return cantDigitos;
        }
        
        public static double GetFactorial(int numero)
        {
            double factorial = 1;
            for (int contador= 2; contador <= numero; contador++)
            {
                factorial = factorial * contador;
            }
            return factorial;
        }




    }
}
