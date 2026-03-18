/*using System;


namespace listaEd
{
    class Ex7
    {
        static void Main(string[] args)
        {
            int t, sm, c, mt, i;
        Console.WriteLine("Digite o tamanho do Vetor: ");
        t = Convert.ToInt32(Console.ReadLine());

        
        int[] vt = new int[t];
        int[] par = new int [99999];

        for(i=0; i<vt.Length; i++)
        {
           Console.WriteLine("Digite um elemento do vetor: ");
           vt[i] = Convert.ToInt32(Console.ReadLine());

        }
        sm=0;
        mt=1;
         c=0;
        for(i=0; i<vt.Length; i++)
        { 
                if(vt[i]% 2 == 0)
                {
                    par[c]=vt[i];
                    c++;
                }     
                
        }

        for(i=0; i<c; i++)
        {
            sm = sm + par[i];
            mt = mt * par[i];  
        }

        Console.WriteLine("Soma dos numeros pares do vetor: "+sm);
        Console.WriteLine("Multiplicação dos numeros pares do vetor: "+mt);
        
        for(i=0; i<c; i++)
        {
            Console.WriteLine("Pares: "+par[i]);
            Console.WriteLine("-------");

        }

        }
    }
}
*/