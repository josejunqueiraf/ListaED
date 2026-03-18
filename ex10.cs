/*using System;

namespace listaED
{
    class Ex10
    {
        static void Main(string[] args)
        {
            int  i, sm, t;
            double md;
            
        Console.WriteLine("Digite o tamanho do Vetor: ");
        t = Convert.ToInt32(Console.ReadLine());

        
        int[] vt = new int[t];

        for(i=0; i<vt.Length; i++)
        {
           Console.WriteLine("Digite uma temperatura: ");
           vt[i] = Convert.ToInt32(Console.ReadLine());
        }
        sm=0;
        for(i=0; i<vt.Length; i++)
        {
           sm = sm + vt[i];
        }
        md = sm/t;

        Console.WriteLine("---------");
        Console.WriteLine("Soma: "+ sm);
        Console.WriteLine("Media: "+ md);
        
        }
    }
}
*/

/* TESTE DE MESA (Entradas: 20, 30, 10, 20)
   
   i | t | vt[i] | sm | md | Saída
   --|---|-------|----|----|-------
   - | 4 |   -   | -  | -  | 
   0 | 4 |  20   | -  | -  | 
   1 | 4 |  30   | -  | -  | 
   2 | 4 |  10   | -  | -  | 
   3 | 4 |  20   | -  | -  | 
   - | 4 |   -   | 0  | -  | 
   0 | 4 |  20   | 20 | -  | 
   1 | 4 |  30   | 50 | -  | 
   2 | 4 |  10   | 60 | -  | 
   3 | 4 |  20   | 80 | -  | 
   - | 4 |   -   | 80 | 20 | Soma: 80, Media: 20
*/