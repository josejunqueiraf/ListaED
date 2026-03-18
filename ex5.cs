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

/* TESTE DE MESA (Entradas: 7, 3, 10)
   
   i | t | m       | mn     | ps | psmn | vt[i] 
   --|---|---------|--------|----|------|-------
   - | 3 |    -    |   -    | -  |  -   |   -   
   0 | 3 |    -    |   -    | -  |  -   |   7   
   1 | 3 |    -    |   -    | -  |  -   |   3   
   2 | 3 |    -    |   -    | -  |  -   |   10  
   - | 3 | -999999 | 999999 | 0  |  0   |   -   
   0 | 3 |    7    |   7    | 0  |  0   |   7   
   1 | 3 |    7    |   3    | 0  |  1   |   3   
   2 | 3 |    10   |   3    | 2  |  1   |   10  
   3 | 3 |    10   |   3    | 2  |  1   |   -   
*/