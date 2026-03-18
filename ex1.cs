/*using System;

namespace listaED{
class Ex1
{
    static void Main(string[] args)
    {
        int t, aux, i;
        Console.WriteLine("Digite o tamanho do Vetor: ");
        t = Convert.ToInt32(Console.ReadLine());

        
        int[] vt = new int[t];
        int[] vti = new int[t];

        for(i=0; i<vt.Length; i++)
        {
           Console.WriteLine("Digite um elemento do vetor: ");
           vt[i] = Convert.ToInt32(Console.ReadLine());

        }

        aux = t - 1;


        
        for(i=0; i<vt.Length; i++)
        {
            vti[i]=vt[aux];
            aux--;

        }

           Console.WriteLine("-------Normal------- ");
        for(i=0; i<vt.Length; i++)
        {
            Console.WriteLine(vt[i]);
            
        }

        Console.WriteLine("-------Inverso------- ");
        for(i=0; i<vt.Length; i++)
        {
            Console.WriteLine(vti[i]);
            
        }

    }

}
}
*/  

/* TESTE DE MESA (Entradas: 10, 20, 30)
   
   i | t | aux | vt[i] | vti[i] 
   --|---|-----|-------|-------
   - | 3 |  -  |   -   |   -   
   0 | 3 |  -  |  10   |   -   
   1 | 3 |  -  |  20   |   -   
   2 | 3 |  -  |  30   |   -   
   - | 3 |  2  |   -   |   -   
   0 | 3 |  2  |   -   |  30   
   1 | 3 |  1  |   -   |  20   
   2 | 3 |  0  |   -   |  10   
   - | 3 | -1  |   -   |   -   
*/