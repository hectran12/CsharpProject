using System;
using System.Collections.Generic;
using System.Text;
namespace tracuutudien
{
    class Program
    {
        static Dictionary<string,string> dic = new Dictionary<string,string>();
        static void Main (string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Tu ban da them: ");
                    tuhientai();
                    Console.WriteLine();
                    Menu();
                }
                catch (Exception ex) {
                    Console.Write("Lo gi do o: ", ex.Message);
                    Thread.Sleep(1000);
                              
                }

                
     

            }
           
        }
        static void Menu()
        {
            string menu;
            menu = "[1] Them tu\n";
            menu += "[2] sua tu\n";
            menu += "[3] tra cuu tu\n";
            menu += "[4] xoa tu\n";
            menu += "[5] Tim kiem tu dong nghia\n";
            Console.Write(menu);
            Console.Write("Ban chon chuc nang nao?: ");
            try
            {
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        createtu();
                        break;
                    case 2:
                        repaitu();
                        break;
                    case 3:
                        findtu();
                        break;
                    case 4:
                        removetu();
                        break;
                    case 5:
                        same();
                        break;
                    default:
                        Console.Write("Khong co su lua chon nao cho ban");
                        break;
                }
            } catch (Exception ex)
            {
                Console.Write (ex.Message);
            }
        }

        private static void same()
        {
            while (true)
            {
                Console.Clear();
                List<string> listk = new List<string>();
                Console.Clear();
                Console.WriteLine("Khong tim dong nghia nua thi xoa");
                Console.Write("Cac tu hien co trong tu dien: ");
                tuhientai();
                Console.WriteLine();
                Console.Write("Nhap tu muon tim dong nghia: ");
                string dn = Convert.ToString(Console.ReadLine());
                if (dn == "") { Console.Write("Khong tim dong nghia nua"); break; Thread.Sleep(1000); }
                if (dic.ContainsKey(dn))
                {
                    Console.Write("Tu van dong nghia duoc tim thay la: ");
                    foreach (KeyValuePair<string, string> i in dic)
                    {

                        string a = dic[dn].ToUpper();
                        string b = i.Value.ToUpper();

                        if (a == b)
                        {
                            listk.Add(i.Key);
                        }

                    }
                    int local = listk.IndexOf(dn);
                    listk.RemoveAt(local);

                    int SS = 0;
                    foreach (string a in listk)
                    {
                        SS++;

                        if (listk.Count == SS)
                        {
                            Console.Write(a);
                        }
                        else
                        {
                            Console.Write(a + ", ");
                        }

                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Khong tim thay tu can tim dong nghia");
                    Console.WriteLine();
                    Thread.Sleep(1000);
                }


                Console.Write("Enter de tiep tuc");
                Console.ReadLine();
            }
            
        }

        private static void removetu()
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("Khong xoa nu thi enter");
                Console.Write("Cac tu hien co trong tu dien: ");
                tuhientai();
                Console.WriteLine();
                Console.Write("Nhap tu muon xoa: ");
                string tuxoa = Convert.ToString(Console.ReadLine());
                if(tuxoa == "")
                {
                    Console.Write("Ban khong xoa nua nua"); Thread.Sleep(1000); break;
                }
                if (dic.ContainsKey(tuxoa))
                {
                    dic.Remove(tuxoa);
                    Console.Write("Xoa thanh cong tu [{0}]", tuxoa);
                } else
                {
                    Console.Write("Khong co tu ban can xoa");
                }
                Thread.Sleep(1000);
            }
        }

        private static void findtu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Khong tra cuu nua thi enter");
                Console.Write("Cac tu hien co trong tu dien: ");
                tuhientai();
                Console.WriteLine();
                Console.Write("Nhap tu can tra cuu: ");
                string tuta = Console.ReadLine();
                if (tuta == "") { Console.Write("Ban khong cuu nua nua"); Thread.Sleep(1000); break; }
                if (dic.ContainsKey(tuta))
                {
                    Console.Write("Enter de tiep tuc\n");
                    Console.Write("Tu [{0}] co nghia la [{1}]", tuta,dic[tuta]);
                    Console.ReadLine();
                } else
                {
                    Console.Write("Khong tim thay tu ban muon tra cuu!\n");
                    Thread.Sleep(1000);
                }
            }
        }

        private static void repaitu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Khong sua nua thi enter");
                Console.Write("Cac tu hien co trong tu dien: ");
                tuhientai();
                Console.WriteLine();
                Console.Write("Nhap tu can thay doi: ");
                string tuthaydoi = Convert.ToString(Console.ReadLine());
                if (tuthaydoi == "") { Console.Write("Ban khong sua nua"); Thread.Sleep(1000); break; }
                if (dic.ContainsKey(tuthaydoi))
                {
                    Console.Write("Ban muon thay nghia tu [{0}] thanh gi?: ", tuthaydoi);
                    dic[tuthaydoi] = Convert.ToString(Console.ReadLine());
                    Console.Write("Da thay doi thanh cong nghia tu [{0}] thanh [{1}]\n", tuthaydoi, dic[tuthaydoi]);
                    Thread.Sleep(1000);
                } else
                {
                    Console.Write("Khong co tu nay trong tu dien");
                    Thread.Sleep(1000);
                }
            }
        }

        private static void createtu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Khong them nua thi enter ");
                Console.Write("Tu hien tai da them: ");
                tuhientai(); Console.WriteLine();
                Console.Write("Nhap tu tieng anh: ");
                string tuta = Convert.ToString(Console.ReadLine());
                if(tuta == "")
                {
                    Console.Write("Khong them nua\n");
                    Thread.Sleep(1000);
                    break;
                } else
                {
                    if (dic.ContainsKey(tuta))
                    {
                        Console.Write("Tu {0} da them roi\n",tuta);
                        Thread.Sleep(1000);
                    } else
                    {
                        Console.Write("Nhap tu tieng viet: ");
                        string tutv = Convert.ToString(Console.ReadLine());
                        dic.Add(tuta, tutv);
                        Console.Write("Them thanh cong!\n");
                    }
                }
            }
      
        }

        private static void tuhientai()
        {
            List<string> list = new List<string>(dic.Keys);
            if(list.Count == 0)
            {
                Console.Write("Chua them tu nao");
            } else
            {
                int a = 0;
                foreach (string key in list)
                {
                    a++;
                    if(list.Count == a)
                    {
                        Console.Write(key);
                    }  else
                    {
                        Console.Write(key + ", ");
                    }
                   
                }
            }
        }
    }
}
