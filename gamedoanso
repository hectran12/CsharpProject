using System;
using System.Text;
namespace GameDoanSo
{
    class Program
    { 
        /// <summary>
        /// Random số máy 
        /// </summary>
        /// <param name="max">Số random max</param>
        /// <returns>Kết quả số máy cho ra</returns>
        static int Random(int max)
        {
            Random rd = new Random();
            int number = rd.Next(max);
            return number;
        }
        /// <summary>
        /// Info game
        /// </summary>
        static void Author_Game()
        {
            string namegame = "Dự đoán số";
            string ngongu = "C#";
            string version = "0.0.1";
            string author = "Tran Trong Hoa";
            Console.WriteLine("Title Game: "+ namegame);
            Console.WriteLine("Lang: "+ ngongu);
            Console.WriteLine("Version: "+ version);
            Console.WriteLine("Author: " + author);
        }
        static void bar(int amount)
        {
            for (int i = 1; i <= amount; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
        static void Main (string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int money = ;
            while (true)
            {
                Console.Clear();
                bar(30);
                Author_Game();
                bar(30);
                Console.WriteLine("Bạn hiện có: " + money);
                Console.Write("Bấm enter để chơi ( phí 1000 money )");
                Console.ReadLine();
                if (money > 1000 || money == 1000)
                {
                    money = money - 1000;
                }
                else
                {
                    Console.WriteLine("Số dư bạn không đủ để chơi");
                    Console.WriteLine("Liên hệ Fb: https://www.facebook.com/thehex101 để nạp tiền");
                    break;
                }

                int somay = Random(501);
                Console.WriteLine("Máy đã cho số , bạn có thể bắt đầu trò chơi");
                Console.WriteLine("Lưu ý: dự đoán trong khoảng 0 đến 500 thôi nhé");
                Console.WriteLine("Thể lệ: dự đoán sai quá 7 lần sẽ thua");
                Console.WriteLine("Mỗi lần chơi mất 1000 money nhé");
                bar(30);
                Console.WriteLine("Bạn hiện có: " + money);
                bar(30);
                int maxlost = 7;
                int lose = 0;
                for (int i = 1; i <= maxlost; i++)
                {
                    //console write so may de duoc lam hacker
                    Console.WriteLine("Bạn đang dự đoán lần " + i);
                    Console.Write("Nhập số của bạn đã dự đoán: ");
                    int numuser;
                    numuser = Convert.ToInt32(Console.ReadLine());
                    bar(30);
                    if (numuser == somay)
                    {
                        Console.WriteLine("Bạn đã dự đoán đúng, xin chúng mừng");
                        lose = 1;
                        break;
                    }
                    else if (numuser > somay)
                    {
                        Console.WriteLine("Bạn đã nhập lớn hơn số máy cho ra");
                        lose = 2;
                    }
                    else if (numuser < somay)
                    {
                        Console.WriteLine("Bạn đã nhập nhỏ hơn số máy cho ra");
                        lose = 2;
                    }
                    else
                    {
                        Console.WriteLine("Không rõ bạn đang nhập gì");
                        lose = 3;
                    }
                }
                bar(30);
                switch (lose)
                {
                    case 1:
                        Console.Write("Bạn đưa cộng 50k , xin chúc mừng ");
                        money = money + 50000;
                        Console.WriteLine("|| số dư hiện tại: "+ money);
                        break;
                    case 2:
                        Console.WriteLine("Bạn thua, bạn còn cái nịt");
                        break;
                    case 3:
                        Console.WriteLine("Không rõ bán muốn gì , nhưng bạn thua rôif :)");
                        break;
                    default:
                        Console.WriteLine("Có thể code đã bị lỗi");
                        break;

                }
                bar(30);
                Console.Write("Enter để tiếp tục chơi nhé");
                Console.ReadLine();
            }


        }
    
    }

}
