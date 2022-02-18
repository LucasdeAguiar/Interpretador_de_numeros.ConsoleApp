using System;

namespace MaquinaDoBanco.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


             string strTexto  =               "     __  __      __  __  __  __  __  __ \n"+
                                              "   | __| __||__||__ |__    ||__||__||  |\n"+
                                              "   ||__  __|   | __||__|   ||__| __||__|\n";
                

           
            System.IO.StringReader leitorTexto = new System.IO.StringReader(strTexto);

            string strPrimeiraLinha = leitorTexto.ReadLine();
            string strSegundaLinha  = leitorTexto.ReadLine();
            string strTerceiraLinha = leitorTexto.ReadLine();

            char[] crPrimeiraLinha = strPrimeiraLinha.ToCharArray();
            char[] crSegundaLinha = strSegundaLinha.ToCharArray();
            char[] crTerceiraLinha = strTerceiraLinha.ToCharArray();
            

            

            verificaNumero(crPrimeiraLinha,crSegundaLinha,crTerceiraLinha);

        }

        public static void verificaNumero(char[] vetorLinha, char[] vetorLinha2, char[] vetorLinha3){ //debug aqui
           
            
                for (int i = 0; i < 40; i=i+4)
                {
                   //Verificando se é 1
                    if (vetorLinha2[i+3] == '|' && vetorLinha3[i+3] == '|' && vetorLinha[i + 2] == ' ' && vetorLinha2[i+2] == ' ')
                    {
                    Console.Write("1");

                    }
                    else
                    //Verificando se é 2
                    if (vetorLinha2[i] == ' ' && vetorLinha2[i + 3] == '|' && vetorLinha3[i] == '|' && vetorLinha3[i + 3] == ' ')
                    {
                        Console.Write("2");
                   

                    }
                    else
                    //Verificando se é 3
                    if (vetorLinha2[i + 3] == '|' && vetorLinha3[i + 3] == '|' && vetorLinha2[i] == ' ' && vetorLinha2[i + 1] == '_')
                    {
                        Console.Write("3");
                    

                }
                    else
                    //verificando se é 4
                    if (vetorLinha2[i] == '|' && vetorLinha2[i+3] == '|' && vetorLinha3[i] == ' ' && vetorLinha3[i+3] == '|' && vetorLinha[i+2] == ' ')
                    {
                    Console.Write("4");
                }
                    //Verificando se é 5
                    if (vetorLinha2[i] == '|' && vetorLinha2[i + 3] == ' ' && vetorLinha3[i] == ' ')
                    {
                        Console.Write("5");
                   


                }
                    else
                    //Verificando se é 6
                    if (vetorLinha2[i] == '|' && vetorLinha2[i + 3] == ' ' && vetorLinha3[i] == '|')
                    {
                        Console.Write("6");
                   

                }
                    else
                    //Verificando se é 7
                    if (vetorLinha2[i] == ' ' && vetorLinha2[i + 3] == '|' && vetorLinha3[i] == ' ' && vetorLinha3[i + 3] == '|' && vetorLinha[i + 2] == '_' && vetorLinha3[i+2] == ' ')
                    {
                        Console.Write("7");
                

                }
                    else
                    //Verificando se é 8
                    if (vetorLinha2[i] == '|' && vetorLinha2[i + 3] == '|' && vetorLinha3[i] == '|' && vetorLinha3[i + 3] == '|' && vetorLinha2[i + 1] == '_')
                    {
                        Console.Write("8");
                   

                }
                    else
                    //Verificando se é 9    
                    if (vetorLinha2[i] == '|' && vetorLinha2[i + 3] == '|' && vetorLinha3[i] == ' ' & vetorLinha3[i + 3] == '|' && vetorLinha3[i+2] == '_')
                    {
                        Console.Write("9");
                  

                }
                    else
                    //Verificando se é 0
                    if (vetorLinha2[i] == '|' && vetorLinha2[i + 3] == '|' && vetorLinha3[i] == '|' & vetorLinha3[i + 3] == '|' && vetorLinha2[i + 1] == ' ' && vetorLinha2[i+2] == ' ')
                    {
                        Console.Write("0");
                  

                }

                }

            Console.ReadKey();

        }



        /*public static void codigosTestes()
        {
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < strPrimeiraLinha.Length; j++)
                    {
                        for (int k = 0; k < 2; k++)
                        {


                        }

                    }

                    for (int j = 0; j < strSegundaLinha.Length; j++)
                    {


                    }

                    for (int j = 0; j < strTerceiraLinha.Length; j++)
                    {


                    }

                }
        
            }
        }
        */

        
    }
}