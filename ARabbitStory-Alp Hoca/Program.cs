using System.ComponentModel.Design;

namespace ARabbitStory_Alp_Hoca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] kopru = new int[10];

            int enerji = 5;

            KopruyuHazirla(kopru);


            for (int i = 0; i < kopru.Length; i++)
            {
                KopruyuYaz(kopru, i);

                if (kopru[i] == 0)
                    enerji--;

                if (enerji == 0 && i < kopru.Length - 1)
                {
                    Console.Write("Enerji bitti. Karşıya geçemedi :(");
                    break;
                }
                else if (i ==kopru.Length-1)
                {
                    Console.Write("Karşıya geçti.");
                }
                    
                Console.Write($"Kalan enerji = {enerji}");
                Console.WriteLine();
            }

        }

        static void KopruyuHazirla(int[] kopru)
        {
            Random rastgele = new Random();

            for (int i = 0; i < kopru.Length; i++)
            {
                kopru[i] = rastgele.Next(0, 2);
            }
        }
        static void KopruyuYaz(int[] kopru, int adim)
        {
            for (int i = 0; i < kopru.Length; i++)
            {
                
                if (i == adim)
                    Console.Write(" T=> " + kopru[i] + " ");
                else
                    Console.Write(" " + kopru[i] + " ");

            }
            
        }
    }
}
