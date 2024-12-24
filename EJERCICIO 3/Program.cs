using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJERCICIO_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int OPCION = 0;
            double CLAVE = 123;
            double PIN;
            int DINEROCUENTA = 3000000;
            int CT1 = 10000,CT2=30000,CT3=50000,CT4=100000,CT5=200000,CT6=300000,CT7=400000,CT8=600000;
           

            Console.WriteLine("BIENVENIDO AL BANCO LEBLANT ");
            Console.WriteLine("    SU BANCO AMIGO ");
            Console.WriteLine("   INGRESE SU CLAVE ");
            PIN = Convert.ToDouble(Console.ReadLine());
       

            double billetes50k = ((DINEROCUENTA*0.5)/50000)+20;
            double billetes20k = ((DINEROCUENTA*0.3)/20000)+20;
            double billetes10k = 10; 

           

            while (CLAVE == PIN )
            {


                    while (OPCION != 9 )
                    {
                        Console.Clear();
                        Console.WriteLine("BIENVENIDO AL BANCO LEBLANT");
                        Console.WriteLine("     ESTADO DE CUENTA      ");
                        Console.WriteLine("DINERO DISPONIBLE= " + DINEROCUENTA);
                        Console.WriteLine("           RETIROS         ");
                        Console.Write("1         10,000           ");
                        Console.WriteLine("2         30,000           ");
                        Console.Write("3         50,000           ");
                        Console.WriteLine("4         100,000           ");
                        Console.Write("5         200,000          ");
                        Console.WriteLine("6         300,000           ");
                        Console.Write("7         400,000          ");
                        Console.WriteLine("8         600,000           ");
                        Console.WriteLine("9 CANCELAR ");
                        Console.WriteLine("numero de billetes en cajero ");
                        Console.WriteLine("N°50,000 :" + billetes50k);
                        Console.WriteLine("N°20,000 :" + billetes20k);
                        Console.WriteLine("N°10,000 :" + billetes10k);
                        Console.WriteLine("INGRES SU OPCION");
                        OPCION = Convert.ToInt32(Console.ReadLine());
                        


                        if ( OPCION!=9 )
                        {switch (OPCION)
                            {

                                case 1:
                               
                                 if (CT1 <= DINEROCUENTA || DINEROCUENTA >= CT8)
                                    {
                                        if (billetes10k != 0)
                                        {
                                           
                                         
                                                Console.WriteLine("1         10,000           ");
                                                DINEROCUENTA = DINEROCUENTA - CT1;
                                                billetes10k = billetes10k - 1;
                                          

                                        }else { Console.WriteLine(" sin billetes en maquina "); }
                                        
                                    }else { Console.WriteLine("dinero insuficiente "); }
                                    Console.ReadKey();
                                    
                                    
                                    break;
                                   
                                 

                                case 2:
                                   
                                if (CT2 <= DINEROCUENTA || DINEROCUENTA >= CT8)
                                    {
                                        if (billetes10k != 0)
                                        {

                                            Console.WriteLine("1         30,000           ");
                                            DINEROCUENTA = DINEROCUENTA - CT2;


                                            if ( 1 <= billetes20k && 1 <= billetes10k)
                                            {
                                                 billetes20k = billetes20k - 1;
                                                 billetes10k = billetes10k - 1;
                                            }
                                            else if (0 == billetes20k && 3 <= billetes10k)
                                            {
                                                billetes20k = billetes20k - 0;
                                                billetes10k = billetes10k - 3;
                                            }
                                        }
                                        else { Console.WriteLine(" sin billetes en maquina "); }
                                        
                                    }
                                    else { Console.WriteLine(" fondos insuficientes "); }
                                    Console.ReadKey();
                                    break;




                                case 3:
                                   

                                 if (CT3 <= DINEROCUENTA || DINEROCUENTA >= CT8)
                                    {
                                        if (billetes10k != 0)
                                        {
                                           
                                        Console.WriteLine("1         50,000           ");
                                        DINEROCUENTA = DINEROCUENTA - CT3;


                                            if ( 2 <= billetes20k && 1 <= billetes10k)
                                            {
                                                billetes20k = billetes20k - 2;
                                                billetes10k = billetes10k - 1;
                                            }

                                            else if (1 <= billetes20k && 4 <= billetes10k)
                                            {
                                                billetes20k = billetes20k - 1;
                                                billetes10k = billetes10k - 4;
                                            }
                                            else if (0 <= billetes20k && 5 <= billetes10k)
                                            {
                                                billetes20k = billetes20k - 0;
                                                billetes10k = billetes10k - 5;
                                            }
                                            
                                            
                                        }
                                        else { Console.WriteLine(" sin billetes en maquina "); }
                                        
                                    }
                                    else { Console.WriteLine(" fondos insuficientes "); }
                                    Console.ReadKey();
                                    break;
                                    
                                



                                
                                case 4:    
                                    
                                 if (CT4 <= DINEROCUENTA || DINEROCUENTA >= CT8)
                                    {
                                        if (billetes10k != 0)
                                        {
                                            Console.WriteLine("1         100,000           ");
                                            DINEROCUENTA = DINEROCUENTA - CT4;


                                            if (1 <= billetes50k && 2 <= billetes20k && 1 <= billetes10k)
                                            {
                                                billetes50k = billetes50k - 1;
                                                billetes20k = billetes20k - 2;
                                                billetes10k = billetes10k - 1;
                                            }

                                            else if (0 == billetes50k && 4 <= billetes20k && 2<= billetes10k)
                                            {
                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 4;
                                                billetes10k = billetes10k - 2;
                                            }
                                            else if (0 == billetes50k && 3 <= billetes20k && 4 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 3;
                                                billetes10k = billetes10k - 4;
                                            }
                                            else if (0 == billetes50k && 2 <= billetes20k && 6 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 2;
                                                billetes10k = billetes10k - 6;
                                            }
                                            else if (0 == billetes50k && 1 <= billetes20k && 8 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 1;
                                                billetes10k = billetes10k - 8;
                                            }
                                            else if (0 == billetes50k && 0 == billetes20k && 10 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 0;
                                                billetes10k = billetes10k - 10;
                                            }
                                            
                                        }
                                        else { Console.WriteLine(" sin billetes en maquina "); }
                                        
                                    }
                                    else { Console.WriteLine(" fondos insuficientes "); }
                                    Console.ReadKey();
                                    break;




                                case 5:

                                    if (CT5 <= DINEROCUENTA || DINEROCUENTA >= CT8)
                                    {
                                        if (billetes10k != 0)
                                        {
                                            Console.WriteLine("1         200,000           ");
                                            DINEROCUENTA = DINEROCUENTA - CT5;


                                            if (3 <= billetes50k && 2 <= billetes20k && 1 <= billetes10k)
                                            {
                                                billetes50k = billetes50k - 3;
                                                billetes20k = billetes20k - 2;
                                                billetes10k = billetes10k - 1;
                                            }

                                            else if (2 <= billetes50k && 4 <= billetes20k && 2 <= billetes10k)
                                            {
                                                billetes50k = billetes50k - 2;
                                                billetes20k = billetes20k - 4;
                                                billetes10k = billetes10k - 2;
                                            }
                                            else if (1 <= billetes50k && 6 <= billetes20k && 3 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 1;
                                                billetes20k = billetes20k - 6;
                                                billetes10k = billetes10k - 3;
                                            }
                                            else if (0 == billetes50k && 8 <= billetes20k && 4 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 8;
                                                billetes10k = billetes10k - 4;
                                            }
                                            else if (0 == billetes50k && 7 <= billetes20k && 6 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 7;
                                                billetes10k = billetes10k - 6;
                                            }
                                            else if (0 == billetes50k && 6 <= billetes20k && 8 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 6;
                                                billetes10k = billetes10k - 8;
                                            }
                                            else if (0 == billetes50k && 5 <= billetes20k && 10 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 5;
                                                billetes10k = billetes10k - 10;
                                            }
                                            else if (0 == billetes50k && 4 <= billetes20k && 12 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 4;
                                                billetes10k = billetes10k - 12;
                                            }
                                            else if (0 == billetes50k && 3 <= billetes20k && 14 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 3;
                                                billetes10k = billetes10k - 14;
                                            }
                                            else if (0 == billetes50k && 2 <= billetes20k && 16 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 2;
                                                billetes10k = billetes10k - 16;
                                            }
                                            else if (0 == billetes50k && 1 <= billetes20k && 18 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 1;
                                                billetes10k = billetes10k - 18;
                                            }
                                            else if (0 == billetes50k && 0 == billetes20k && 20 <= billetes10k)
                                            {

                                                billetes10k = billetes10k - 20;
                                            }
                                            
                                        }
                                        else { Console.WriteLine(" sin billetes en maquina "); }
                                        
                                    }
                                    else { Console.WriteLine(" fondos insuficientes "); }
                                    Console.ReadKey();
                                    break;


                                case 6:
                                    

                                if (CT6 <= DINEROCUENTA || DINEROCUENTA >= CT8)
                                    {
                                        if (billetes10k != 0)
                                        {
                                            Console.WriteLine("1         300,000           ");
                                            DINEROCUENTA = DINEROCUENTA - CT6;


                                            if (5 <= billetes50k && 2 <= billetes20k && 1 <= billetes10k)
                                            {
                                                billetes50k = billetes50k - 5;
                                                billetes20k = billetes20k - 2;
                                                billetes10k = billetes10k - 1;
                                            }

                                            else if (4 <= billetes50k && 4 <= billetes20k && 2 <= billetes10k)
                                            {
                                                billetes50k = billetes50k - 4;
                                                billetes20k = billetes20k - 4;
                                                billetes10k = billetes10k - 2;
                                            }
                                            else if (3 <= billetes50k && 6 <= billetes20k && 3 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 3;
                                                billetes20k = billetes20k - 6;
                                                billetes10k = billetes10k - 3;
                                            }
                                            else if (2 <= billetes50k && 8 <= billetes20k && 4 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 2;
                                                billetes20k = billetes20k - 8;
                                                billetes10k = billetes10k - 4;
                                            }
                                            else if (1 <= billetes50k && 10 <= billetes20k && 5 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 1;
                                                billetes20k = billetes20k - 10;
                                                billetes10k = billetes10k - 5;
                                            }
                                            else if (0 == billetes50k && 12 <= billetes20k && 6 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 12;
                                                billetes10k = billetes10k - 6;
                                            }
                                            else if (0 == billetes50k && 11 <= billetes20k && 8 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 11;
                                                billetes10k = billetes10k - 8;
                                            }
                                            else if (0 == billetes50k && 10 <= billetes20k && 10 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 10;
                                                billetes10k = billetes10k - 10;
                                            }
                                            else if (0 == billetes50k && 9 <= billetes20k && 12 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 9;
                                                billetes10k = billetes10k - 12;
                                            }
                                            else if (0 == billetes50k && 8 <= billetes20k && 15 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 8;
                                                billetes10k = billetes10k - 14;
                                            }
                                            else if (0 == billetes50k && 7 <= billetes20k && 16 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 7;
                                                billetes10k = billetes10k - 16;
                                            }
                                            else if (0 == billetes50k && 6 <= billetes20k && 18 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 6;
                                                billetes10k = billetes10k - 18;
                                            }
                                            else if (0 == billetes50k && 5 <= billetes20k && 20 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 5;
                                                billetes10k = billetes10k - 20;
                                            }
                                            else if (0 == billetes50k && 4 <= billetes20k && 22 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 4;
                                                billetes10k = billetes10k - 22;
                                            }
                                            else if (0 == billetes50k && 3 <= billetes20k && 24 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 3;
                                                billetes10k = billetes10k - 24;
                                            }
                                            else if (0 == billetes50k && 2 <= billetes20k && 26 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 2;
                                                billetes10k = billetes10k - 26;
                                            }
                                            else if (0 == billetes50k && 1 <= billetes20k && 28 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 1;
                                                billetes10k = billetes10k - 28;
                                            }

                                            else if (0 == billetes50k && 0 == billetes20k && 30 <= billetes10k)
                                            {

                                            billetes10k = billetes10k - 30;
                                            }

                                        }
                                        else { Console.WriteLine(" sin billetes en maquina "); }
                                     
                                    }
                                else { Console.WriteLine(" fondos insuficientes "); }
                                Console.ReadKey();

                                    break;




                                case 7:

                                   if (CT7 <= DINEROCUENTA || DINEROCUENTA >= CT8)
                                    {
                                        if (billetes10k != 0)

                                        {Console.WriteLine("7         400,000           ");
                                            DINEROCUENTA = DINEROCUENTA - CT7;
                                            if (7 <= billetes50k && 2 <= billetes20k && 1 <= billetes10k)
                                        {
                                            billetes50k = billetes50k - 7;
                                            billetes20k = billetes20k - 2;
                                            billetes10k = billetes10k - 1;
                                        }

                                            if (6 <= billetes50k && 4 <= billetes20k && 2 <= billetes10k)
                                        {
                                            billetes50k = billetes50k - 6;
                                            billetes20k = billetes20k - 4;
                                            billetes10k = billetes10k - 2;
                                        }
                                        else if (5 <= billetes50k && 6 <= billetes20k && 3 <= billetes10k)
                                        {

                                            billetes50k = billetes50k - 5;
                                            billetes20k = billetes20k - 6;
                                            billetes10k = billetes10k - 3;
                                        }
                                        else if (4 <= billetes50k && 8 <= billetes20k && 4 <= billetes10k)
                                        {

                                            billetes50k = billetes50k - 4;
                                            billetes20k = billetes20k - 8;
                                            billetes10k = billetes10k - 4;
                                        }
                                        else if (3 <= billetes50k && 10 <= billetes20k && 5 <= billetes10k)
                                        {

                                            billetes50k = billetes50k - 3;
                                            billetes20k = billetes20k - 10;
                                            billetes10k = billetes10k - 5;
                                        }
                                        else if (2 <= billetes50k && 12 <= billetes20k && 6 <= billetes10k)
                                        {

                                            billetes50k = billetes50k - 2;
                                            billetes20k = billetes20k - 12;
                                            billetes10k = billetes10k - 6;
                                        }
                                        else if (1 <= billetes50k && 14 <= billetes20k && 7 <= billetes10k)
                                        {

                                            billetes50k = billetes50k - 1;
                                            billetes20k = billetes20k - 14;
                                            billetes10k = billetes10k - 7;
                                        }
                                            else if (0 == billetes50k && 16 <= billetes20k && 8 <= billetes10k)
                                        {

                                            billetes50k = billetes50k - 0;
                                            billetes20k = billetes20k - 16;
                                            billetes10k = billetes10k - 8;


                                        }
                                            else if (0 == billetes50k && 15 <= billetes20k && 10 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 15;
                                                billetes10k = billetes10k - 10;
                                            }
                                            else if (0 == billetes50k && 14 <= billetes20k && 12 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 14;
                                                billetes10k = billetes10k - 12;
                                            }
                                            else if (0 == billetes50k && 13 <= billetes20k && 14 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 13;
                                                billetes10k = billetes10k - 14;

                                            }
                                            else if (0 == billetes50k && 12 <= billetes20k && 16 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 12;
                                                billetes10k = billetes10k - 16;


                                            }
                                            else if (0 == billetes50k && 11 <= billetes20k && 18 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 11;
                                                billetes10k = billetes10k - 18;


                                            }
                                            else if (0 == billetes50k && 10 <= billetes20k && 20 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 10;
                                                billetes10k = billetes10k - 20;


                                            }
                                            else if (0 == billetes50k && 9 <= billetes20k && 22 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 9;
                                                billetes10k = billetes10k - 22;

                                            }
                                            else if (0 == billetes50k && 8 <= billetes20k && 24 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 8;
                                                billetes10k = billetes10k - 24;

                                            }
                                            else if (0 == billetes50k && 7 <= billetes20k && 26 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 7;
                                                billetes10k = billetes10k - 26;

                                            }
                                            else if (0 == billetes50k && 6 <= billetes20k && 28 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 6;
                                                billetes10k = billetes10k - 28;

                                            }
                                            else if (0 == billetes50k && 5 <= billetes20k && 30 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 5;
                                                billetes10k = billetes10k - 30;

                                            }
                                            else if (0 == billetes50k && 4 <= billetes20k && 32 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 4;
                                                billetes10k = billetes10k - 32;

                                            }
                                            else if (0 == billetes50k && 3 <= billetes20k && 34 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 3;
                                                billetes10k = billetes10k - 34;

                                            }
                                            else if (0 == billetes50k && 2 <= billetes20k && 36 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 2;
                                                billetes10k = billetes10k - 36;

                                            }
                                            else if (0 == billetes50k && 1 <= billetes20k && 38 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 1;
                                                billetes10k = billetes10k - 38;

                                            }
                                            else if (0 == billetes50k && 0 == billetes20k && 40 <= billetes10k)
                                            {

                                                billetes10k = billetes10k - 40;
                                            }
                                            
                                        }
                                        else { Console.WriteLine(" sin billetes en maquina "); }
                                        
                                    }
                                    else { Console.WriteLine(" fondos insuficientes "); }
                                    Console.ReadKey();
                                    break;



                               

                                case 8:

                                    if (CT8 <= DINEROCUENTA || DINEROCUENTA >= CT8)
                                    {
                                        if (billetes10k != 0)
                                        {
                                            Console.WriteLine("8         600,000           ");
                                            DINEROCUENTA = DINEROCUENTA - CT8;


                                            if (11 <= billetes50k && 2 <= billetes20k && 1 <= billetes10k)
                                            {
                                                billetes50k = billetes50k - 11;
                                                billetes20k = billetes20k - 2;
                                                billetes10k = billetes10k - 1;
                                            }
                                            else if (10 <= billetes50k && 4 <= billetes20k && 2 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 10;
                                                billetes20k = billetes20k - 4;
                                                billetes10k = billetes10k - 2;
                                            }
                                            else if (9 <= billetes50k && 6 <= billetes20k && 3 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 9;
                                                billetes20k = billetes20k - 6;
                                                billetes10k = billetes10k - 3;
                                            }
                                            else if (8 <= billetes50k && 8 <= billetes20k && 4 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 8;
                                                billetes20k = billetes20k - 8;
                                                billetes10k = billetes10k - 4;
                                            }
                                            else if (7 <= billetes50k && 10 <= billetes20k && 5 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 7;
                                                billetes20k = billetes20k - 10;
                                                billetes10k = billetes10k - 5;
                                            }
                                            else if (6 <= billetes50k && 12 <= billetes20k && 6 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 6;
                                                billetes20k = billetes20k - 12;
                                                billetes10k = billetes10k - 6;
                                            }
                                            else if (5 <= billetes50k && 14 <= billetes20k && 7 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 5;
                                                billetes20k = billetes20k - 14;
                                                billetes10k = billetes10k - 7;
                                            }
                                            else if (4 <= billetes50k && 16 <= billetes20k && 8 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 4;
                                                billetes20k = billetes20k - 16;
                                                billetes10k = billetes10k - 8;
                                            }
                                            else if (3 <= billetes50k && 18 <= billetes20k && 9 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 3;
                                                billetes20k = billetes20k - 18;
                                                billetes10k = billetes10k - 9;
                                            }
                                            else if (2 <= billetes50k && 20 <= billetes20k && 10 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 2;
                                                billetes20k = billetes20k - 20;
                                                billetes10k = billetes10k - 10;
                                            }
                                            else if (1 <= billetes50k && 22 <= billetes20k && 11 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 1;
                                                billetes20k = billetes20k - 22;
                                                billetes10k = billetes10k - 11;
                                            }
                                            else if (0 == billetes50k && 24 <= billetes20k && 12 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 24;
                                                billetes10k = billetes10k - 12;
                                            }
                                            else if (0 == billetes50k && 23 <= billetes20k && 14 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 23;
                                                billetes10k = billetes10k - 14;
                                            }
                                            else if (0 == billetes50k && 22 <= billetes20k && 16 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 22;
                                                billetes10k = billetes10k - 16;
                                            }
                                            else if (0 == billetes50k && 21 <= billetes20k && 18 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 21;
                                                billetes10k = billetes10k - 18;
                                            }
                                            else if (0 == billetes50k && 20 <= billetes20k && 20 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 20;
                                                billetes10k = billetes10k - 20;
                                            }
                                            else if (0 == billetes50k && 19 <= billetes20k && 22 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 19;
                                                billetes10k = billetes10k - 22;
                                            }
                                            else if (0 == billetes50k && 18 <= billetes20k && 24 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 18;
                                                billetes10k = billetes10k - 24;
                                            }
                                            else if (0 == billetes50k && 17 <= billetes20k && 26 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 17;
                                                billetes10k = billetes10k - 26;
                                            }
                                            else if (0 == billetes50k && 16 <= billetes20k && 28 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 16;
                                                billetes10k = billetes10k - 28;
                                            }
                                            else if (0 == billetes50k && 15 <= billetes20k && 30 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 15;
                                                billetes10k = billetes10k - 30;
                                            }
                                            else if (0 == billetes50k && 14 <= billetes20k && 32 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 14;
                                                billetes10k = billetes10k - 32;
                                            }
                                            else if (0 == billetes50k && 13 <= billetes20k && 34 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 13;
                                                billetes10k = billetes10k - 34;
                                            }
                                            else if (0 == billetes50k && 12 <= billetes20k && 36 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 12;
                                                billetes10k = billetes10k - 36;
                                            }
                                            else if (0 == billetes50k && 11 <= billetes20k && 38 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 11;
                                                billetes10k = billetes10k - 38;
                                            }
                                            else if (0 == billetes50k && 10 <= billetes20k && 40 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 10;
                                                billetes10k = billetes10k - 40;
                                            }
                                            else if (0 == billetes50k && 9 <= billetes20k && 42 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 9;
                                                billetes10k = billetes10k - 42;
                                            }
                                            else if (0 == billetes50k && 8 <= billetes20k && 44 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 8;
                                                billetes10k = billetes10k - 44;
                                            }
                                            else if (0 == billetes50k && 7 <= billetes20k && 46 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 7;
                                                billetes10k = billetes10k - 46;
                                            }
                                            else if (0 == billetes50k && 6 <= billetes20k && 48 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 6;
                                                billetes10k = billetes10k - 48;
                                            }
                                            else if (0 == billetes50k && 5 <= billetes20k && 50 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 5;
                                                billetes10k = billetes10k - 50;
                                            }
                                            else if (0 == billetes50k && 4 <= billetes20k && 52 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 4;
                                                billetes10k = billetes10k - 52;
                                            }
                                            else if (0 == billetes50k && 3 <= billetes20k && 54 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 3;
                                                billetes10k = billetes10k - 54;
                                            }
                                            else if (0 == billetes50k && 2 <= billetes20k && 56 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 2;
                                                billetes10k = billetes10k - 56;
                                            }
                                            else if (0 == billetes50k && 1 <= billetes20k && 58 <= billetes10k)
                                            {

                                                billetes50k = billetes50k - 0;
                                                billetes20k = billetes20k - 1;
                                                billetes10k = billetes10k - 58;
                                            }
                                            else if (0 == billetes50k && 0 == billetes20k && 60 <= billetes10k)
                                            {

                                                billetes10k = billetes10k - 60;
                                            }
                                            
                                        }
                                        else { Console.WriteLine(" sin billetes en maquina "); }
                                    }
                                    else { Console.WriteLine(" fondos insuficientes "); }
                                    Console.ReadKey();
                                    break; }
                        }
                        else { Console.WriteLine("transacion cancelada "); }
                        PIN = 000;
                    }
                }
            if (PIN == 000)
            {
                Console.WriteLine("adios ");
                Console.ReadKey();
            }
            else if (CLAVE!=PIN)
            {
                Console.WriteLine(" pin incorrecto ");
                Console.WriteLine("transacion cancelada ");
                Console.WriteLine("adios ");
              
                Console.ReadKey();
            }
              
            }
        }
    }




