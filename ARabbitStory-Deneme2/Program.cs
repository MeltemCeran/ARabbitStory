
using System.Runtime.ExceptionServices;

namespace ARabbitStory_Deneme2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Şimdi önce bana 10 tane random 1 yada sıfır lazım bi kere yapıcam onu kullanıcam. 

            int[] bridge = new int[10];

            int[] T = {0, 1, 2, 3, 4, 5 };

            int EnerjiT = 5;

            BridgeSteps(ref bridge, ref T, ref EnerjiT);

            for (int i = 0; i < bridge.Length; i++)   //burda tavşanı hareket ettirmeyi denedim.
            {
                if (i == T[i])
                {
                    Console.Write("T =>    ");
                }
                Console.Write($"{bridge[i]}   ");
            }

        }


        private static void BridgeSteps(ref int[] bridge, ref int[] T, ref int EnerjiT)
        {
            bridge[0] = new Random().Next(0, 2);
            bridge[1] = new Random().Next(0, 2);
            bridge[2] = new Random().Next(0, 2);
            bridge[3] = new Random().Next(0, 2);
            bridge[4] = new Random().Next(0, 2);
            bridge[5] = new Random().Next(0, 2);
            bridge[6] = new Random().Next(0, 2);
            bridge[7] = new Random().Next(0, 2);
            bridge[8] = new Random().Next(0, 2);
            bridge[9] = new Random().Next(0, 2);

            Console.Write("T=> ");
            for (int i = 0; i < bridge.Length; i++)
            {
                
                Console.Write($"  {bridge[i]}  ");    //Sanırım doğru yaptım araya T eklemem lazım şimdi. Canvada comicbook çizcem tavşanı.

                if (bridge[i] == 0)
                {
                    EnerjiT = EnerjiT - 1;
                    //Console.Write($"kalan enerji {T}");

                }
                else if (bridge[i] == 1)
                {
                    EnerjiT = EnerjiT - 1 + 1;

                    //Console.Write($"kalan enerji {T}");
                }
                
            }
            Console.WriteLine($"Kalan enerji = {EnerjiT}");

            Console.WriteLine();


            



            Console.Write("T=> ");
            for (int i = 0; i < bridge.Length; i++)
            {

                Console.Write($"  {bridge[i]}  ");    //Sanırım doğru yaptım araya T eklemem lazım şimdi. Canvada comicbook çizcem tavşanı.

                if (bridge[i] == 0)
                {
                    EnerjiT = EnerjiT - 1;
                    //Console.Write($"kalan enerji {T}");

                }
                else if (bridge[i] == 1)
                {
                    EnerjiT = EnerjiT - 1 + 1;

                    //Console.Write($"kalan enerji {T}");
                }

            }
            Console.WriteLine($"Kalan enerji = {EnerjiT}");



        }
        
    }










}


