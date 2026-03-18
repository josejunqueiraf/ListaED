/*using System;

namespace listED
{
    class Ex12
    {
        static void Main(string[] args)
        {
            int  i, sm, t;
            
        Console.WriteLine("Digite o tamanho do Vetor: ");
        t = Convert.ToInt32(Console.ReadLine());

        
        int[] vt = new int[t];
        int[] vtq = new int[t];
        

        for(i=0; i<vt.Length; i++)
        {
           Console.WriteLine("Digite um numero do vetor: ");
           vt[i] = Convert.ToInt32(Console.ReadLine());
        }
        sm = 0;
        for(i=0; i<vt.Length; i++)
        {
           vtq[i]= vt[i] * vt[i];

           sm = sm + vtq [i];
        }

        
        Console.WriteLine("---------");   
        Console.WriteLine("Soma dos quadrados = "+sm);
      
        }
    }
}
*/

/* TESTE DE MESA (Entradas: 2, 3, 4)
   
   i | t | vt[i] | vtq[i] | sm | Saída
   --|---|-------|--------|----|-------
   - | 3 |   -   |    -   | -  | 
   0 | 3 |   2   |    -   | -  | 
   1 | 3 |   3   |    -   | -  | 
   2 | 3 |   4   |    -   | -  | 
   - | 3 |   -   |    -   | 0  | 
   0 | 3 |   2   |    4   | 4  | 
   1 | 3 |   3   |    9   | 13 | 
   2 | 3 |   4   |   16   | 29 | 
   3 | 3 |   -   |    -   | 29 | Soma: 29
*/