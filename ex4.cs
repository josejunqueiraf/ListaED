/*using System;

namespace listaED
{
    class Ex4
    {
        static void Main(string[] args)
        {
            int t, m, m2, ps2, ps, i;
        Console.WriteLine("Digite o tamanho do Vetor: ");
        t = Convert.ToInt32(Console.ReadLine());

        
        int[] vt = new int[t];

        for(i=0; i<vt.Length; i++)
        {
           Console.WriteLine("Digite um elemento do vetor: ");
           vt[i] = Convert.ToInt32(Console.ReadLine());

        }
         m=-999999;
         ps= 0;
        for(i=0; i<vt.Length; i++)
        {
            if(vt[i]>m)
            {
                m=vt[i];
                ps=i;
            }
        }

        m2=-999999;
        ps2=0;
        for(i=0; i<vt.Length; i++)
        {
            if(vt[i]<m && vt[i]>m2)
            {
                m2=vt[i];
                ps2=i;
            }
        }

        

        Console.WriteLine("Maior numero do vetor: "+m+" na posicao: "+ps);

        Console.WriteLine("O segundo Maior numero do vetor: "+m2+" na posicao: "+ps2);

        }
    }
}
*/

/* TESTE DE MESA (Entradas: 10, 30, 20)
   
   i | t | m       | ps | m2      | ps2 | vt[i] 
   --|---|---------|----|---------|-----|-------
   - | 3 |    -    | -  |    -    |  -  |   -   
   0 | 3 |    -    | -  |    -    |  -  |   10  
   1 | 3 |    -    | -  |    -    |  -  |   30  
   2 | 3 |    -    | -  |    -    |  -  |   20  
   - | 3 | -999999 | 0  |    -    |  -  |   -   
   0 | 3 |   10    | 0  |    -    |  -  |   10  
   1 | 3 |   30    | 1  |    -    |  -  |   30  
   2 | 3 |   30    | 1  |    -    |  -  |   20  
   - | 3 |   30    | 1  | -999999 |  0  |   -   
   0 | 3 |   30    | 1  |   10    |  0  |   10  
   1 | 3 |   30    | 1  |   10    |  0  |   30  
   2 | 3 |   30    | 1  |   20    |  2  |   20  
   3 | 3 |   30    | 1  |   20    |  2  |   -   
*/