

using System;


namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] numbers = new int[10, 14];
            string line1;
            string line2;
            char op;

            //Matrix mit Zufallszahlen füllen
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int u = 0; u < numbers.GetLength(1); u++)
                {
                    numbers[i, u] = random.Next(1, 10);
                }
            }

            //Ausgeben der Matrix mit Vergleichsoperatoren
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                line1 = "";
                line2 = "";
                for (int u = 0; u < numbers.GetLength(1); u++)
                {
                    
                    //Vergleichsoperator für zwei Zahlen nebeneinander
                    line1 = line1 + numbers[i, u];
                    if (u < numbers.GetLength(1)-1) //Bei letzter Zahl kein Vegleichsoperator mehr
                    {
                        if (numbers[i,u] < numbers[i,u + 1])
                            op = '<';
                        else if (numbers[i,u] > numbers[i,u + 1])
                            op = '>';
                        else
                            op = '=';
                        line1=line1+" " + op + " ";
                    }
                    //Vergleichoperator für zwei Zahlen übereinander     
                    if (i < numbers.GetLength(0) - 1)
                    {
                        if (numbers[i, u] < numbers[i+1, u ])
                            op = 'A';
                        else if (numbers[i, u] > numbers[i+1, u])
                            op = 'V';
                        else
                            op = '=';
                        line2 = line2 + op + "   ";
                    }
                }
                Console.WriteLine(line1);
                Console.WriteLine(line2);
            }
        }
    }
}
