using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Ej1();
            //Ej2();            
            //Ej3();            
            //Ej4();
            //Ej5();
            //Ej6();
            //Ej7();
            //Ej8();
            //Ej9();
            // falta Ej10();
            // falta Ej11();
            // falta Ej12();
            //Ej13();
            //Ej14();
            //Ej15();
            //Ej16();
            //Ej17();
            // falta Ej18();
            //Ej19();
            //Ej20();
            Console.ReadLine();
        }

        static void Ej1()
        {
            int numero = 1;
            int ultTresRegistro = 104;
            string cartel = "";
            do
            {
                if (Funciones.EsMultiplo(numero, 3) && Funciones.EsMultiplo(numero, 5))
                {
                    cartel = cartel + "\n" + numero + " - FooBar";
                }
                else
                {
                    if (Funciones.EsMultiplo(numero, 3))
                    {
                        cartel = cartel + "\n" + numero + " - Foo";
                    }
                    else if (Funciones.EsMultiplo(numero, 5))
                    {
                        cartel = cartel + "\n" + numero + " - Bar";
                    }
                    else
                    {
                        cartel = cartel + "\n" + numero;
                    }
                }                
                numero = numero + 1;
            }
            while (numero <= ultTresRegistro);
            Console.WriteLine(cartel);
        }

        static void Ej2()
        {
            int numero = 1;
            int ultTresRegistro = 104;
            string cartel = "";
            do
            {
                if (Funciones.EsPrimo(numero) && Funciones.EsMultiplo(numero, 3))
                {
                    cartel = cartel + "\n" + numero + " - Es primo y divisible por 3";
                }
                else
                {
                    if (Funciones.EsMultiplo(numero, 3))
                    {
                        cartel = cartel + "\n" + numero + " Es divisible por 3";
                    }
                    else if (Funciones.EsPrimo(numero))
                    {
                        cartel = cartel + "\n" + numero + " - Es primo";
                    }
                    else
                    {
                        cartel = cartel + "\n" + numero;
                    }
                }
                numero = numero + 1;
            }
            while (numero <= ultTresRegistro);
            Console.WriteLine(cartel);
        }

        static void Ej3()
        {
            string palabra = Validaciones.Validaciones.ValidarStrNoVac("Ingrese una palabra");
            string palabraInvertida= Funciones.InvertirLetrasPalabra(palabra);
            if(palabra==palabraInvertida)
            { Console.WriteLine("Es palídromo"); }
            else
            { Console.WriteLine("No es palídromo"); }
        }

        static void Ej4()
        {
            string palabra1 = Validaciones.Validaciones.ValidarStrNoVac("Ingrese una palabra");
            string palabra2 = Validaciones.Validaciones.ValidarStrNoVac("Ingrese una palabra");
            string palabra1Ordenada = Funciones.OrdenarLetrasPalabra(palabra1); 
            string palabra2Ordenada = Funciones.OrdenarLetrasPalabra(palabra2);
            if (palabra1Ordenada == palabra2Ordenada)
            {
                Console.WriteLine("Es un anagrama");
            }
            else
            {
                Console.WriteLine("No es un anagrama");
            }
        }

        static void Ej5()
        {
            string palabra = Validaciones.Validaciones.ValidarStrNoVac("Ingrese un número");
            string palabraInvertida = Funciones.InvertirLetrasPalabra(palabra);
            Console.WriteLine(palabraInvertida); 
        }

        static void Ej6()
        {
            int numero1 = Validaciones.Validaciones.ValidarInt("Ingrese un número");
            int numero2 = Validaciones.Validaciones.ValidarInt("Ingrese otro número");
            int resultado = (numero1 + numero2) * (numero1 - numero2);
            Console.WriteLine(resultado);
        }

        static void Ej7()
        {
            const double cantNumeros = 5;
            List<double> numeros = new List<double>();
            for (double i = 0; i < cantNumeros; i++)
            {
                double numero = Validaciones.Validaciones.ValidarDouble("Ingrese otro número");
                numeros.Add(numero);
            }

            double menor = numeros.Min();
            double mayor = numeros.Max();
            double medio = Funciones.CalcularDoubleDelMedio(numeros);
            Console.WriteLine($"El mayor es: {mayor} \nEl menor es: {menor} \nEl del medio es: {medio}");
        }

        static void Ej8()
        {
            DateTime fecha1 = DateTime.Today;
            DateTime fecha2 = Validaciones.Validaciones.PedirFecha("Ingrese una fecha:");
            int cantDias = Funciones.ContarDiasIntervalo(fecha1, fecha2);
            Console.WriteLine($"La diferencia de fechas es de {cantDias} días");
        }

        static void Ej9()
        {
            string usuario = "VALERIA";
            string ingreso = Validaciones.Validaciones.ValidarStrNoVac("Ingrese su nombre");
            if (ingreso!=usuario)
            {
                Console.WriteLine("No te conozco");
            }
            else
            {
                Console.WriteLine($"¡Hola, {usuario}!");
            }
        }

        static void Ej10()
        {
        }
        static void Ej11()
        {
        }
        static void Ej12()
        {
            DateTime fecha1 = Validaciones.Validaciones.PedirFecha("Ingrese una fecha");
            DateTime fecha2 = Validaciones.Validaciones.PedirFecha("Ingrese otra fecha");
            Console.WriteLine(CalcularAñosMesesDias(fecha1, fecha2));
        }

        public static string CalcularAñosMesesDias(DateTime fecha1, DateTime fecha2)
        {
            string valor = "";

            return valor;
        }
        static void Ej13()
        {
            int numero = Validaciones.Validaciones.ValidarInt("Ingrese un número");
            double factorial = Funciones.GetFactorial(numero);
            Console.WriteLine($"El factorial de {numero} es: {factorial}");
        }
        static void Ej14()
        {
            int numero = (int)Validaciones.Validaciones.ValidarUint("Ingrese un número");
            string tabla = "";
            for (int contador = 0; contador<=10; contador++)
            {
                tabla = tabla + $"{numero} X {contador} = {numero*contador}\n";
            }
            Console.WriteLine(tabla);
        }
        static void Ej15()
        {
            string usuario = "VALERIA";
            string ingreso;
            int intentos = 0;
            do
            {
                ingreso = Validaciones.Validaciones.ValidarStrNoVac("Ingrese su clave");

                if (ingreso == usuario)
                {
                    Console.WriteLine($"Bienvenido, {usuario}");
                }
                else if (ingreso !=usuario && intentos == 2)
                {
                    Console.WriteLine("Clave bloqueada");
                }
                else
                {
                    Console.WriteLine("Acceso denegado, la contraseña no es correcta");
                }

                intentos++;
            }
            while (ingreso != usuario && intentos < 3);
        }
        static void Ej16()
        {
            string numero = Validaciones.Validaciones.ValidarDouble("Ingrese un número").ToString();
            int cantDigitos = Funciones.ContarCantidadCaracteres(numero);
            Console.WriteLine($"Número ingresado: {numero} - Tiene {cantDigitos} digitos");
        }

        static void Ej17()
        {
            List<empleado> empleados = new List<empleado>();
            int cantEmpleados = 1;
            for (int cantidad = 0; cantidad < cantEmpleados; cantidad++)
            {
                string nombre = Validaciones.Validaciones.ValidarStrNoVac("Ingrese nombre del empleado");
                double sueldo = Validaciones.Validaciones.ValidarDoubleMayorACero("Ingrese sueldo");
                empleado unEmpleado = new empleado(nombre, sueldo);
                empleados.Add(unEmpleado);
            }
            double sueldoMax = 0;
            string nombreMax = "";
            foreach (empleado empleado in empleados)
            {
                if (empleado.Sueldo > sueldoMax)
                {
                    sueldoMax = empleado.Sueldo;
                    nombreMax = empleado.Nombre;
                }
            }
            Console.WriteLine($"El sueldo mayor es: ${0:n}, del empleado: {nombreMax}", sueldoMax);
        }
        class empleado
        {
            string _nombre;
            double _sueldo;
            public empleado(string nombre, double sueldo)
            {
                this._nombre = nombre;
                this._sueldo = sueldo;
            }

            public string Nombre { get => _nombre; }
            public double Sueldo { get => _sueldo; }
        }

        static void Ej18()
        {
        }
        static void Ej19()
        {
            List<string> palabras = new List<string>(); 
            int cantPalabras = (int)Validaciones.Validaciones.ValidarUint("Ingrese cantidad de palabras a ingresar");
            for(int ingresos= 0; ingresos<cantPalabras;ingresos++)
            {
                string palabra = Validaciones.Validaciones.ValidarStrNoVac("Ingrese una palabra");
                palabras.Add(palabra);
            }
            string cartel="";
            foreach(string palabra in palabras)
            {
                int cantCaracteres = Funciones.ContarCantidadCaracteres(palabra);
                cartel = cartel + $"Palabra: {palabra} Largo: {cantCaracteres} caracteres\n"; 
            }
            Console.WriteLine(cartel);
        }
        static void Ej20()
        {
            int numero = (int)Validaciones.Validaciones.ValidarUint("Ingrese un número");
            double factorial = Funciones.GetFactorial(numero);
            int cantidadPrimos = 0;
            for(int contador = 0; contador<=numero; contador++)
            {
                if (Funciones.EsPrimo(contador)==true)
                {
                    Console.WriteLine(contador);
                    cantidadPrimos++;
                }
            }
            Console.WriteLine($"Hasta el {numero} hay {cantidadPrimos} números primos, y el factorial de {numero} es {factorial}");
        }



    }
}
