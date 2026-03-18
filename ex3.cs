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

/* TESTE DE MESA (Entradas: 15, 4, 9)
   
   i | t | m      | ps | vt[i] 
   --|---|--------|----|-------
   - | 3 |    -   | -  |   -   
   0 | 3 |    -   | -  |   15  
   1 | 3 |    -   | -  |   4   
   2 | 3 |    -   | -  |   9   
   - | 3 | 999999 | 0  |   -   
   0 | 3 |   15   | 0  |   15  
   1 | 3 |   4    | 1  |   4   
   2 | 3 |   4    | 1  |   9   
   3 | 3 |   4    | 1  |   -   
*/