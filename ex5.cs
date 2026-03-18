/*using System;

namespace listaED
{
    class Ex5
    {
        static void Main(string[] args)
        {
            int t, m, mn, psmn, ps, i;
        Console.WriteLine("Digite o tamanho do Vetor: ");
        t = Convert.ToInt32(Console.ReadLine());

        
        int[] vt = new int[t];

        for(i=0; i<vt.Length; i++)
        {
           Console.WriteLine("Digite um elemento do vetor: ");
           vt[i] = Convert.ToInt32(Console.ReadLine());

        }
         m=-999999;
         mn=999999;
         ps= 0;
         psmn=0;
        for(i=0; i<vt.Length; i++)
        {
            if(vt[i]>m)
            {
                m=vt[i];
                ps=i;
            }

            if(vt[i]<mn)
            {
                mn=vt[i];
                psmn=i;
            }

        }

        Console.WriteLine("Maior numero do vetor: "+m+" na posicao: "+ps);
        Console.WriteLine("Maior numero do vetor: "+mn+" na posicao: "+psmn);

        }
    }
}
*/