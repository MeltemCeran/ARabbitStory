namespace ARabbitStory_Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---IF SHE GONNA MAKE IT?---");

            //int[] T = { 1, 1, 1, 1, 1 };           //Bura tavşanın başlangıç enerjisi.
            //                                           //Array olmasının nedeni her bir elemanı ile işlem yapmam lazım.
            //Console.WriteLine($" T= {T.Length}");

            int enerji = 5;

            int[] T = { 1, 1, 1, 1, 1 };

            int[] bridge = new int[10];

            Console.WriteLine("-------");

            BridgeSteps(ref bridge);


            for (int i = 0; i <= bridge.Length; i++)   //burayı enerji sıfırlanana kadar nasıl döndürcem ya?
            {
                for (int j = 0; j < bridge.Length; j++)    //bridge length gereklimiydi emin değilim. düz bi for yapsaydım?
                {
                    BridgeSteps(ref bridge);

                    if (bridge[i] == 1)
                    {
                        enerji = enerji + 1 - 1;
                    }
                    else if (bridge[i] == 0)
                    {
                        enerji--;
                    }

                }
                Console.Write($"Kalan enerji = {enerji}");

                Console.WriteLine();
            }
            
                
            //Bura komple çöp. 






            //for (int j = 0; j < 10; j++) //   !!! bir defa atılan random 10 sayı enerji sıfır olana kadar kullanılacak. 
            //{

            //    if (bridge[0] == 1)
            //    {
            //        Console.Write($"Kalan enerji =  {enerji}"); // burda bişeyler yolunda gidiyo gibi. 

            //    }

            //    else if (bridge[0] == 0)
            //    {
            //        Console.Write($"Kalan enerji = {enerji -= 1}");
            //        enerji--;
            //    }
            //    Console.WriteLine();

            //    if (enerji == 0)
            //    {

            //    }

            //}


            //for (int j = 0; j < 10; j++)    //bridge length gereklimiydi emin değilim. düz bi for yapsaydım?
            //{
            //    bridge[i] = new Random().Next(0, 2);    //yan yana yazılan 10 adet rastgele 1-0 atışı burda. 
            //    Console.Write($"  {bridge[i]}  ");

            //}


            //şimdi 10a 10 oldu.  tavşanı zıplatıcaz şimdi.


            //foreach (int k in bridge)
            //{
            //    if (bridge[i] == 1)                   //burda her bir adım için hesap yapmasını umuyorum.
            //        Console.WriteLine($" Kalan Enerji = {T.Length}");
            //    else if (bridge[i] == 0)
            //        Console.WriteLine($" Kalan Enerji = {T.Length - 1}");
            //}




            //while (T.Length ==0 )
            // {
            //     if (bridge[0]==1)
            //     {
            //         Console.Write($" T => {T[0] - 1 }");
            //     }

            // }
            //while içinde if???  bu tavşanı ikinci for a nasıl bağlarım?




        }

        private static void BridgeSteps(ref int[] bridge)
        {
            Console.WriteLine("Orijinal Random :");
            for (int i = 0; i < bridge.Length; i++)
            {
                bridge[i] = new Random().Next(0, 2);   //Köprü tamam. Köprüyü metod yapim dur.
                Console.Write(bridge[i].ToString());
                Console.Write("    ");
            }
            Console.WriteLine();
        }
    }
}
