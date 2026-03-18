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

/* TESTE DE MESA (Entradas: 2, 3, 4)
   
   i | t | sm | mt | c | vt[i] | par[c]
   --|---|----|----|---|-------|-------
   - | 3 | -  | -  | - |   -   |   -
   0 | 3 | -  | -  | - |   2   |   -
   1 | 3 | -  | -  | - |   3   |   -
   2 | 3 | -  | -  | - |   4   |   -
   - | 3 | 0  | 1  | 0 |   -   |   -
   0 | 3 | 0  | 1  | 1 |   2   |   2
   1 | 3 | 0  | 1  | 1 |   3   |   -
   2 | 3 | 0  | 1  | 2 |   4   |   4
   0 | 3 | 2  | 2  | 2 |   -   |   2
   1 | 3 | 6  | 8  | 2 |   -   |   4
   2 | 3 | 6  | 8  | 2 |   -   |   -
*/