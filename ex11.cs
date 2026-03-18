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