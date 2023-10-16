using Prestamos;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;

Libro lbr1 = new Libro();
lbr1.TituloLibro = "Azul";
lbr1.autor = "Ruben Dario";
lbr1.Nejemplares = 20;

Libro lbr2 = new Libro("La metamorfosis", "Franz Kaftka", 20, 0);

int op = 0;
bool band = true;

do
{
    lbr1.Menu();
    lbr1.Pedir("Ingrese la opcion a realizar: ", ref op);
    Console.Clear();
    switch (op)
    {
        case 1:
            Console.Clear();
            lbr1.Libros();
            lbr1.Pedir("Que libro desea: ", ref op);
            switch (op)
            {
                case 1:
                    if(lbr1.Nejemplares == 0)
                        Console.WriteLine("Libro Azul agotado.");
                    else
                    {
                        lbr1.Nejemplares--;
                        lbr1.NejemplaresPrestados++;
                    }                    
                    break;
                case 2:
                    if(lbr2.Nejemplares == 0)
                        Console.WriteLine("Libro Metamorfosis Agotado");
                    else
                    {
                        lbr2.Nejemplares--;
                        lbr2.NejemplaresPrestados++;
                    }                    
                    break;
                case 3: Environment.Exit(0); break;
                default: Console.WriteLine("Opcion no valida."); break;
            }
            break;
        case 2:
            Console.Clear();
            lbr2.Libros();
            lbr2.Pedir("Que libro desea: ", ref op);
            switch (op)
            {
                case 1:
                    if(lbr1.Nejemplares == 20)
                        Console.WriteLine("No se ha realizado ningun prestamo de este libro.");
                    else
                    {
                        lbr1.Nejemplares++;
                        lbr1.NejemplaresPrestados--;
                    }                    
                    break;
                case 2:
                    if (lbr2.Nejemplares == 20)
                        Console.WriteLine("No se ha realizado ningun prestamo de este libro.");
                    else
                    {
                        lbr2.Nejemplares++;
                        lbr2.NejemplaresPrestados--;
                    }
                    break;
                case 3: Environment.Exit(0); break;
                default: Console.WriteLine("Opcion no valida."); break;
            }
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("Dispinibilidad de los libros......");
            Console.WriteLine("Azul: {0}",lbr1.Nejemplares);
            Console.WriteLine("La Metamorfosiss: {0}", lbr2.Nejemplares);
            Console.ReadKey();
            break;
        case 4:
            band = false;
            Console.Clear();
            break;
        default:
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Opcion incorrecta");
            Console.WriteLine("--------------------------");
            break;
    }


} while (band);
