/*using System;

namespace listaED
{
    class Ex11
    {
        static void Main(string[] args)
        {
            int  i, t;
            
        Console.WriteLine("Digite o tamanho do Vetor: ");
        t = Convert.ToInt32(Console.ReadLine());

        
        int[] vt = new int[t];
        int[] vtq = new int[t];
        int [] vtc = new int[t];

        for(i=0; i<vt.Length; i++)
        {
           Console.WriteLine("Digite um numero do vetor: ");
           vt[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(i=0; i<vt.Length; i++)
        {
           vtq[i]= vt[i] * vt[i];

           vtc[i]= vt[i] * vt[i] * vt[i];
        }

        for(i=0; i<vt.Length; i++)
        {
        Console.WriteLine("---------");
        Console.WriteLine(vt[i]+" ao quadrado = "+vtq[i]);
        Console.WriteLine(vt[i]+" ao cubo = "+vtc[i]);
        }
        }
    }
}
*/

/* TESTE DE MESA (Entradas: 2, 3)
   
   i | t | vt[i] | vtq[i] | vtc[i] | Saída
   --|---|-------|--------|--------|-------
   - | 2 |   -   |   -    |   -    | 
   0 | 2 |   2   |   -    |   -    | 
   1 | 2 |   3   |   -    |   -    | 
   - | 2 |   -   |   -    |   -    | 
   0 | 2 |   2   |   4    |   8    | 
   1 | 2 |   3   |   9    |   27   | 
   0 | 2 |   2   |   4    |   8    | 2 ao q = 4, 2 ao c = 8
   1 | 2 |   3   |   9    |   27   | 3 ao q = 9, 3 ao c = 27
   2 | 2 |   -   |   -    |   -    | 
*/