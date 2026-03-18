/*using System;

namespace listaED
{
    class Ex3
    {
        static void Main(string[] args)
        {
            int t, m, ps, i;
        Console.WriteLine("Digite o tamanho do Vetor: ");
        t = Convert.ToInt32(Console.ReadLine());

        
        int[] vt = new int[t];

        for(i=0; i<vt.Length; i++)
        {
           Console.WriteLine("Digite um elemento do vetor: ");
           vt[i] = Convert.ToInt32(Console.ReadLine());

        }
         m=999999;
         ps= 0;
        for(i=0; i<vt.Length; i++)
        {
            if(vt[i]<m)
            {
                m=vt[i];
                ps=i;
            }

        }

        Console.WriteLine("Menor numero do vetor: "+m+" na posicao: "+ps);
    
        }
    }

}
*/