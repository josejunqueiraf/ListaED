/*using System;

namespace listaED
{
    class Ex9
    {
        static void Main(string[] args)
        {
            int  i, t;
            double sml;
        Console.WriteLine("Digite o tamanho do Vetor: ");
        t = Convert.ToInt32(Console.ReadLine());

        
        double[] vt = new double[t];

        for(i=0; i<vt.Length; i++)
        {
           Console.WriteLine("Digite um salario: ");
           vt[i] = Convert.ToDouble(Console.ReadLine());
        }
        sml=0;
        for(i=0; i<vt.Length; i++)
        {
           sml = sml + vt[i];
        }

        Console.WriteLine("---------");
        Console.WriteLine("Soma de todos os salarios: "+ sml);
        
    }
}
}

*/

/* TESTE DE MESA (Entradas: 1200, 1500, 1300)
   
   i | t | vt[i] | sml    | Saída
   --|---|-------|--------|-------
   - | 3 |   -   |   -    | 
   0 | 3 | 1200  |   -    | 
   1 | 3 | 1500  |   -    | 
   2 | 3 | 1300  |   -    | 
   - | 3 |   -   |   0    | 
   0 | 3 | 1200  |  1200  | 
   1 | 3 | 1500  |  2700  | 
   2 | 3 | 1300  |  4000  | 
   3 | 3 |   -   |  4000  | Soma: 4000
*/