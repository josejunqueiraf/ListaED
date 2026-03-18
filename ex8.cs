/*using System;

namespace listaED
{
    class Ex8
    {
        static void Main(string[] args)
        {
            int t, mt, i;
        Console.WriteLine("Digite o tamanho do Vetor: ");
        t = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o multiplicador ");
        mt = Convert.ToInt32(Console.ReadLine());

        
        int[] vt = new int[t];

        for(i=0; i<vt.Length; i++)
        {
           Console.WriteLine("Digite um elemento do vetor: ");
           vt[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(i=0; i<vt.Length; i++)
        {
           Console.WriteLine(vt[i]+ " * "+ mt+ " = "+ vt[i]*mt);
           Console.WriteLine("---------");
        }
        }
    }
}
*/

/* TESTE DE MESA (Entradas: t=3, mt=5, valores: 2, 4, 6)
   
   i | t | mt | vt[i] | vt[i]*mt | Saída
   --|---|----|-------|----------|-------
   - | 3 | 5  |   -   |    -     | 
   0 | 3 | 5  |   2   |    -     | 
   1 | 3 | 5  |   4   |    -     | 
   2 | 3 | 5  |   6   |    -     | 
   0 | 3 | 5  |   2   |    10    | 2 * 5 = 10
   1 | 3 | 5  |   4   |    20    | 4 * 5 = 20
   2 | 3 | 5  |   6   |    30    | 6 * 5 = 30
   3 | 3 | 5  |   -   |    -     | 
*/