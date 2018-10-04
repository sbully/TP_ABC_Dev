using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourde_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("TOUR DE HANOI");
            Console.WriteLine("\n\n......................................");
            int[,] tour = new int[5, 3];
//            int ligne =0, colonne=0;
            int ctrligne=0, ctrcolonne=0;
            bool remplace = false;

            int tempo = 0;
            int coup = 0;


            tour [0,0]= 1;
            tour [1,0]= 2;
            tour [2,0]= 3;
            tour [3,0]= 4;
            tour [4,0]= 5;
            Console.WriteLine("..............Départ.....................");
            Console.WriteLine(tour[0, 0] + "|" + tour[0, 1] + "|" + tour[0, 2]);
            Console.WriteLine(tour[1, 0] + "|" + tour[1, 1] + "|" + tour[1, 2]);
            Console.WriteLine(tour[2, 0] + "|" + tour[2, 1] + "|" + tour[2, 2]);
            Console.WriteLine(tour[3, 0] + "|" + tour[3, 1] + "|" + tour[3, 2]);
            Console.WriteLine(tour[4, 0] + "|" + tour[4, 1] + "|" + tour[4, 2]);
            Console.WriteLine(".......................................");
            Console.ReadKey();

            do
            {
                ctrligne = 0;
                do
                {
                    
 
                    tempo=tour[ctrligne,ctrcolonne];
                    tour[ctrligne, ctrcolonne] = 0;

                    if (tempo == 0)
                    {
                            ctrligne++;
                            

                    }
                    if (ctrligne > 4)
                    {
                        ctrligne = 0;
                        ctrcolonne--;

                    }
                    if (ctrcolonne < 0)
                    {
                        ctrcolonne = 2;
                    }

                    

                } while (tempo==0);


                ctrcolonne--;
                if (ctrcolonne < 0)
                {
                    ctrcolonne = 2;
                }


                ctrligne = 4;
            do
	        {


                for (int i = 0; (tour[ctrligne, ctrcolonne] < tempo) && (tour[ctrligne, ctrcolonne] != 0); i++)
                {
                    ctrcolonne--;
                    if (ctrcolonne < 0)
                    {
                        ctrcolonne = 2;
                    }
                    ctrligne = 4;

                    i = 0;
                }


                if (tour[ctrligne,ctrcolonne]==0)
	            {

                     
                        tour[ctrligne, ctrcolonne] = tempo;
                        ctrcolonne--;
                        coup++;
                        remplace = true;
	                

	            }
                else
	            {
                    ctrligne--;
                    remplace = false;
	            }


                if (ctrcolonne < 0)
                {
                    ctrcolonne = 2;
                }
                if (ctrligne > 4)
                {
                    ctrligne = 0;
                }
	         
	        } while (remplace== false);



            Console.WriteLine(".........apres boucle..........");
            Console.WriteLine(tour[0, 0] + "|" + tour[0, 1] + "|" + tour[0, 2]);
            Console.WriteLine(tour[1, 0] + "|" + tour[1, 1] + "|" + tour[1, 2]);
            Console.WriteLine(tour[2, 0] + "|" + tour[2, 1] + "|" + tour[2, 2]);
            Console.WriteLine(tour[3, 0] + "|" + tour[3, 1] + "|" + tour[3, 2]);
            Console.WriteLine(tour[4, 0] + "|" + tour[4, 1] + "|" + tour[4, 2]);
            Console.WriteLine(".......................................");


            Console.WriteLine("valeur de coup : "+coup);

            

            } while (tour[0,2] != 1 || tour[1,2] != 2 || tour[2,2] != 3 || tour[3,2] != 4 || tour[4,2] != 5);


            Console.WriteLine(".............FINAL.....................");
            Console.WriteLine("......................................."); 
            Console.WriteLine(tour[0, 0] + "|" + tour[0, 1] + "|" + tour[0, 2]);
            Console.WriteLine(tour[1, 0] + "|" + tour[1, 1] + "|" + tour[1, 2]);
            Console.WriteLine(tour[2, 0] + "|" + tour[2, 1] + "|" + tour[2, 2]);
            Console.WriteLine(tour[3, 0] + "|" + tour[3, 1] + "|" + tour[3, 2]);
            Console.WriteLine(tour[4, 0] + "|" + tour[4, 1] + "|" + tour[4, 2]);
            Console.WriteLine(".......................................");


            Console.ReadKey();




        }
    }
}
