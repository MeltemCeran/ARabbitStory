namespace ARabbitStory_Deneme3
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
        //baslangıc enerjin var
        //havucları math randomla her bir değeri şeye listeye ata
        // sonsuz döngüde olcak sağ düğmeye basınca t'nin durduğu yer bir sağdaki ile yer değişcek
        //eğer i+1 de havuc yoksa enerji -1 varsa enerji +1 ama hareket etmek 1 enerji
        //her bastıgında da ekrana yeniden durumu bascaz.

        private static int AdimT(ref int[] Havuclar, ref int EnerjiT)
        {


            string Tavsan = "T=>";
            int firstVersion = 0;


            for (int i = 0; i < Havuclar.Length; i++)
            {

                Havuclar[i] = new Random().Next(0, 2);

                
            }

            for (var i= 0;i < Havuclar.Length;i++)
            {
               
                if(firstVersion==0 || i == 0)
                {
                    Console.Write($"   {Tavsan}");
                    firstVersion++;

                }

                if (Havuclar[i] != 1)
                {
                    EnerjiT--;

                }
                else if (EnerjiT == 0)
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
                Console.Write(" Kalan Enerji: " + EnerjiT);
                Console.WriteLine();

            }
            


            return EnerjiT; 
        }
    }

    //if (Havuclar[i] == 1)
    //{

    //    EnerjiT = EnerjiT - 1 + 1;
    //}
    //else if (Havuclar[i] == 0)
    //{

    //    EnerjiT = EnerjiT - 1;
    //}
    //Console.Write($"   {Havuclar[i]}");

    //if (EnerjiT ==0 )
    //{
    //    break;

    //}
    //else if (EnerjiT <=5 )
    //{
    //    EnerjiT = EnerjiT + 1 - 1;
    //}
}
