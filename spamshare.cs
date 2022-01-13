using System;
using System.Text;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;

namespace spamshare
{
    public class info
    {
        public string id { get; set; }
        public string name { get; set; }

    }

    public class res
    {
        public string id { get; set; }
    }
    class Program
    {
        static void Delay(int delay)
        {
            for(int i = delay; i > 0; i--)
            {
                Console.Write("\r Đang nghĩ , vui lòng đợi {0}\r", i);
                Thread.Sleep(1000);
            }
        }

        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng token muốn chạy: ");
            int amuont = Convert.ToInt32(Console.ReadLine());
            int sttreal = 0;
            string[] token = new string[amuont];
            for (int i = 0; i < amuont; i++)
            {
                bool non = true;
                try
                {
                    sttreal++;
                    Console.Write("Nhập token thứ {0}: ", sttreal);
                    string tokeninput = Convert.ToString(Console.ReadLine());
                    using var clientz = new HttpClient();
                    string t = await clientz.GetStringAsync("https://graph.facebook.com/me?access_token=" + tokeninput);
                    token[sttreal - 1] = tokeninput;
                    info profile = JsonSerializer.Deserialize<info>(Convert.ToString(t));
                    Console.Write("IDFB: {0} || NAME: {1}", profile.id, profile.name);
                    Console.WriteLine();
                } catch
                {
                    non = false;
                    Console.Write("Token die hoạc không chính xác");Console.ReadLine();
                } 
                if (non == false)
                {
                    sttreal = sttreal - 1;
                    i = i - 1;
                }
            }
            bool tieptuc = true;

            Console.Write("Nhập số lượt share rồi đổi nick: ");
            int doinick = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập delay share: ");
            int delayshare = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bao nhiêu lượt share thì delay vòng: ");
            int delayvong = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sau {0} thì nghĩ bao nhiêu giây: ", delayvong);
            int delaygiay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập id muốn share: ");
            string id = Convert.ToString(Console.ReadLine());
            int num = 0;
            int numao = 0;
            int numacc = 0;
            using var client = new HttpClient();
            if (tieptuc == true)
            {
                while (true)
                {
                    int iacc = 0;
                    foreach (string accesstoken in token)
                    {
                        iacc++;
                        bool run = true;
                        try
                        {
                            
                            string tv = await client.GetStringAsync("https://graph.facebook.com/me?access_token=" + accesstoken);
                            info profile = JsonSerializer.Deserialize<info>(Convert.ToString(tv));
                            Console.WriteLine("STT {0} Đang chạy acc {1}", iacc,profile.name);
                        } catch
                        {
                            run = false;
                        }
                        if (run == true)
                        {
                            while (true)
                            {
                                try
                                {
                                    string t = await client.GetStringAsync("https://graph.facebook.com/me/feed?method=POST&link=https://www.facebook.com/" + id + "&privacy={%27value%27:%20%27EVERYONE%27}&access_token=" + accesstoken);
                                    res result = JsonSerializer.Deserialize<res>(t);
                                    num++;
                                    numao++;
                                    numacc++;
                                    string date = string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);

                                    Console.WriteLine("{0}=>{1} thành công , uid: {2}", num, date, result.id);
                                    Delay(delayshare);
                                    if (numao == delayvong)
                                    {
                                        numao = 0;
                                        
                                        Delay(delaygiay);
                                    }


                                } catch (Exception ex)
                                {
                                    num = num - 1;
                                    numao = numao - 1;
                                    numacc = numacc - 1;
                                    Console.WriteLine(ex.Message);
                                    
                                    break;
                                }

                                if(numacc == doinick)
                                {
                                    numacc = 0;
                                    Console.WriteLine("Đang chuyển acc");
                                    break;
                                }

                            }

                        }


                    }
                }
            }


        }
       
    }
}
