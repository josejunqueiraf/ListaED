using System;

namespace listaED
{
    class Ex12mais1
    {
        static void Main(string[] args)
        {
            int  i, t;
            double sm, md;
            
        Console.WriteLine("Digite o tamanho do Vetor: ");
        t = Convert.ToInt32(Console.ReadLine());

        
        int[] vt = new int[t];
        double[] vtrq = new double[t];
        

        for(i=0; i<vt.Length; i++)
        {
           Console.WriteLine("Digite um numero do vetor: ");
           vt[i] = Convert.ToInt32(Console.ReadLine());
        }
        sm = 0;
        md=0;
        for(i=0; i<vt.Length; i++)
            {
                vtrq[i] = Math.Sqrt(vt[i]);

                sm = sm + vtrq[i];
            }

            md = sm/t;

        
        Console.WriteLine("---------");   
        Console.WriteLine("Soma das raizes = "+sm);
        Console.WriteLine("Media das raizes = "+md);
        }
    }
}

/* TESTE DE MESA (Entradas: 16, 64, 225)
   
   i | t | vt[i]  | vtrq[i]| sm | md
   --|---|--------|--------|----|-------
   - | 3 |   -    |    -   | -  | 
   0 | 3 |   16   |    -   | -  | 
   1 | 3 |   64   |    -   | -  | 
   2 | 3 |   225  |    -   | -  | 
   - | 3 |   -    |    -   | 0  | 0
   0 | 3 |   16   |    4   | 4  | 0
   1 | 3 |   64   |    8   | 12 | 0
   2 | 3 |   225  |    15  | 27 | 0
   3 | 3 |   -    |    -   | 27 | 9 
*/