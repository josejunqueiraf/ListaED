/*using System;

namespace listaED
{
    class Ex6
    {
        static void Main(string[] args)
        {
            int t, i;
        Console.WriteLine("Digite o tamanho do Vetor: ");
        t = Convert.ToInt32(Console.ReadLine());

        
        int[] vt = new int[t];

        for(i=0; i<vt.Length; i++)
        {
           Console.WriteLine("Digite uma idade do vetor: ");
           vt[i] = Convert.ToInt32(Console.ReadLine());

        }
         
        for(i=0; i<vt.Length; i++)
        {
            if(vt[i]>=1 && vt[i]<=9)
            {
                Console.WriteLine(vt[i] + " Criança");
                Console.WriteLine("--------");
                
            }
            else if(vt[i]>=10 && vt[i]<=12)
            {
                Console.WriteLine(vt[i] + " Pré-adolescente");
                Console.WriteLine("--------");

            }
            else if(vt[i]>=13 && vt[i]<=17)
            {
                Console.WriteLine(vt[i] + " Adolescente");
                Console.WriteLine("--------");

            }
            else if(vt[i]>=18 && vt[i]<=59)
            {
                Console.WriteLine(vt[i] + " Adulto");
                Console.WriteLine("--------");

            }
            else if(vt[i]>=60)
            {
                Console.WriteLine(vt[i] + " Idoso");
                Console.WriteLine("--------");

            }


        }

        
    }
}
}
*/