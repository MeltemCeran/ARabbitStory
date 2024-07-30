namespace ARabbitStory_Deneme4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---IS SHE GONNA MAKE IT?---");
            Console.WriteLine();

            int[] Havuclar = new int[10];

            int EnerjiT = 5;

            AdimT(ref Havuclar, ref EnerjiT);
        }

        private static void AdimT(ref int[] Havuclar, ref int EnerjiT)
        {


            string Tavsan = "T=>";
            int firstVersion = 0;


            for (int i = 0; i < Havuclar.Length; i++)
            {

                Havuclar[i] = new Random().Next(0, 2);


            }

            for (var i = 0; i < Havuclar.Length; i++)
            {

                if (firstVersion == 0 || i == 0)
                {
                    Console.Write($"   {Tavsan}");
                    firstVersion++;

                }

                if (Havuclar[i] != 1)
                {
                    EnerjiT--;

                }
                if (EnerjiT <= 0)
                {
                    Console.Write("  Enerji Bitti. Karşıya geçemediniz.");
                    break;
                }

                for (int j = 1; j < Havuclar.Length; j++)
                {
                    
                    if (i != j)
                    {
                        Console.Write($"   {Havuclar[j]}");
                    }
                    else if (i == j)
                    {
                        Console.Write($"   {Tavsan}");

                    }

                }
                Console.Write("   Kalan Enerji: " + EnerjiT);
                Console.WriteLine();

            }

        }
    }
}
