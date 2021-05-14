using System;
using System.Text;

namespace BanTauNguoiVsMay
{
    class Program
    {
        public static int[,] vitringuoi1 = new int[10, 2] { { 1, 6 }, { 1, 8 }, { 2, 2 }, { 3, 2 }, { 5, 1 }, { 7, 1 }, { 4, 4 }, { 4, 8 }, { 6, 10 }, { 9, 10 } };
        public static int[,] vitringuoi2 = new int[10, 2] { { 1, 6 }, { 1, 8 }, { 2, 2 }, { 3, 2 }, { 5, 1 }, { 7, 1 }, { 4, 4 }, { 4, 8 }, { 6, 10 }, { 9, 10 } };
        public static double diemnguoichoi1 = 0;
        public static double diemnguoichoi2 = 0;
        public static void chonvitri()
        {
            Console.OutputEncoding = Encoding.UTF8;

            for(int  i = 1;i<=2;i++) { 
                int a = 0;
                int l = 0;
                if (i == 1)
                {
                    Console.WriteLine("nguoi choi  chon toa do tau ");
                }
                else
                {
                    Console.WriteLine("nguoi choi máy chon toa do tau ");
                }
               
                for (int j = 2; j <= 5; j++)
                {
                    int x = 0; int y = 0;
                    int z = 0;int t = 0;

                   

                    
                    if (i == 1)
                    {
                        Console.WriteLine("\nTọa độ tàu 1-" + j);
                        Console.WriteLine("\nTọa độ đầu tàu ");
                        Console.Write("Tọa độ x= ");
                         x = Int32.Parse(Console.ReadLine());
                        Console.Write("Tọa độ y= ");
                         y = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nTọa độ đuôi tàu ");
                        Console.Write("Tọa độ x= ");
                         z = Int32.Parse(Console.ReadLine());
                        Console.Write("Tọa độ y= ");
                         t = Int32.Parse(Console.ReadLine());

                    }
                  
                    else  if(i == 2)
                    {
                        Console.WriteLine("\nTọa độ tàu 1-" + j);
                        Console.WriteLine("\nTọa độ đầu tàu ");
                        Random rd = new Random();
                        x = rd.Next(1, 10);
                        Console.Write("Tọa độ x= ",z);
                        y = rd.Next(1, 10);
                        Console.Write("Tọa độ y= ",y);
                        Console.WriteLine("\nTọa độ đuôi tàu ");
                            int q = 0;
                            while (q != 0)
                            {
                                z = rd.Next(1, 10);
                                t = rd.Next(1, 10);
                                if (z == x)
                                {
                                    q++;
                                    t = y + j;
                                }
                                else if (t == y)
                                {
                                    q++;
                                    z = x + j;
                                }
                            }
                        

                        Console.Write("Tọa độ x= "+z);
                        
                        Console.Write("Tọa độ y= "+t);
                        if(Math.Sqrt(Math.Pow(x - z, 2) + Math.Pow(y - t, 2)) != j+1)
                        {
                            j--;
                            continue;
                        }
                       
                    
}
                    
                    if ((x == z || y == t) && (Math.Abs(y - t) == j - 1 || Math.Abs(x - z) == j - 1) && x > 0 && y > 0 && z > 0 && t > 0 && x <= 10 && y <= 10 && z <= 10 && t <= 10)
                    {
                        if (i == 1)
                        {
                            if (a == 0)
                            {
                                vitringuoi1[a, 0] = x;
                                vitringuoi1[a, 1] = y;
                                vitringuoi1[a + 1, 0] = z;
                                vitringuoi1[a + 1, 1] = t;
                                showlocation(i);
                            }
                            else
                            {
                                int kt = 0;
                                for (int k = 0; k <= a; k += 2)
                                {
                                    if ((x == vitringuoi1[k, 0] && y == vitringuoi1[k, 1]) || (z == vitringuoi1[k, 0] && t == vitringuoi1[k, 1]) ||
                                            (x == vitringuoi1[k + 1, 0] && y == vitringuoi1[k + 1, 1]) || (z == vitringuoi1[k + 1, 0] && t == vitringuoi1[k + 1, 1]))
                                    {
                                        kt++;
                                        Console.WriteLine("\nTọa độ toa do duoi tau va dau tau bi trung voi toa do duoi tau dau tau khac ");
                                        j--;
                                    }


                                }
                                if (kt == 0)
                                {
                                    vitringuoi1[a, 0] = x;
                                    vitringuoi1[a, 1] = y;
                                    vitringuoi1[a + 1, 0] = z;
                                    vitringuoi1[a + 1, 1] = t;
                                    showlocation(i);
                                }

                            }
                        }

                        else
                        {
                            if (a == 0)
                            {
                                vitringuoi2[a, 0] = x;
                                vitringuoi2[a, 1] = y;
                                vitringuoi2[a + 1, 0] = z;
                                vitringuoi2[a + 1, 1] = t;
                                showlocation(i);
                            }
                            else
                            {
                                int kt = 0;
                                for (int k = 0; k <= a; k += 2)
                                {
                                    if ((x == vitringuoi1[k, 0] && y == vitringuoi1[k, 1]) || (z == vitringuoi1[k, 0] && t == vitringuoi1[k, 1]) ||
                                            (x == vitringuoi1[k + 1, 0] && y == vitringuoi1[k + 1, 1]) || (z == vitringuoi1[k + 1, 0] && t == vitringuoi1[k + 1, 1]))
                                    {
                                        kt++;
                                        Console.WriteLine("\nTọa độ toa do duoi tau va dau tau bi trung voi toa do duoi tau dau tau khac ");
                                        j--;
                                    }


                                }
                                if (kt == 0)
                                {
                                    vitringuoi2[a, 0] = x;
                                    vitringuoi2[a, 1] = y;
                                    vitringuoi2[a + 1, 0] = z;
                                    vitringuoi2[a + 1, 1] = t;
                                    showlocation(i);
                                }

                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("\nTọa độ nhap sai vui long nhap lai ");
                        j--;
                    }
                    if (l == 0 && j == 3)
                    {
                        l++;
                        j--;
                    }



                    a = a + 2;
               
                }
            }
        }

        public static double tinhdiem(double x)
        {
            if (x + 1 == 2)
                return 5;
            else if (x + 1 == 3)
                return 3;
            else if (x + 1 == 4)
                return 2;
            else if (x + 1 == 5)
                return 1;
            return 0;
        }
        public static void kiemtradiem(int x, int y, int nguoiban)
        {//su dung careme
         //ax1+b=y1
         //ax2+b=y2
            if (nguoiban == 1)
            {
                Console.WriteLine("\nnguoi choi 1");

            }
            else Console.WriteLine("\nnguoi choi Máy");

            for (int i = 0; i <= 9; i += 2)
            {
                int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
                if (nguoiban == 1)
                {
                    x1 = vitringuoi2[i, 0]; y1 = vitringuoi2[i, 1]; x2 = vitringuoi2[i + 1, 0]; y2 = vitringuoi2[i + 1, 1];


                }
                else
                {

                    x1 = vitringuoi1[i, 0]; y1 = vitringuoi1[i, 1]; x2 = vitringuoi1[i + 1, 0]; y2 = vitringuoi1[i + 1, 1];
                }
                int a = 0, b = 0;

                if (x1 == x2 && x2 == x)
                {
                    if (nguoiban == 1 && y >= y1 && y <= y2)
                    {


                        diemnguoichoi1 += tinhdiem(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)));
                        Console.WriteLine("diem nguoi choi 1:" + diemnguoichoi1);
                        vitringuoi2[i, 0] = 0; vitringuoi2[i, 1] = 0; vitringuoi2[i + 1, 0] = 0; vitringuoi2[i + 1, 1] = 0;
                    }
                    else if (nguoiban == 2 && y >= y1 && y <= y2)
                    {
                        diemnguoichoi2 += tinhdiem(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)));
                        Console.WriteLine("diem nguoi choi May:" + diemnguoichoi2);
                        vitringuoi1[i, 0] = 0; vitringuoi1[i, 1] = 0; vitringuoi1[i + 1, 0] = 0; vitringuoi1[i + 1, 1] = 0;
                    }

                }
                else if (y1 == y2 && y2 == y)
                {

                    if (nguoiban == 1 && x >= x1 && x <= x2)
                    {

                        diemnguoichoi1 += tinhdiem(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)));
                        Console.WriteLine("diem nguoi choi 1:" + diemnguoichoi1);

                        vitringuoi2[i, 0] = 0; vitringuoi2[i, 1] = 0; vitringuoi2[i + 1, 0] = 0; vitringuoi2[i + 1, 1] = 0;
                    }
                    else if (nguoiban == 2 && x >= x1 && x <= x2)
                    {
                        diemnguoichoi2 += tinhdiem(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)));
                        Console.WriteLine("diem nguoi choi máy:" + diemnguoichoi2);
                        vitringuoi1[i, 0] = 0; vitringuoi1[i, 1] = 0; vitringuoi1[i + 1, 0] = 0; vitringuoi1[i + 1, 1] = 0;

                    }

                }


            }
            showlocation(1);
            showlocation(2);
        }
        public static void showlocation(int nc)
        {
            if (nc == 1)
            {
                Console.WriteLine("\n nguoi choi ");

            }
            else Console.WriteLine("\n nguoi choi máy");
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("");
                for (int j = 1; j <= 10; j++)
                {
                    int z = 0;

                    for (int k = 0; k <= 9; k += 2)
                    {
                        if (nc == 1)
                        {
                            if ((vitringuoi1[k, 0] == j && vitringuoi1[k, 1] == i) || (vitringuoi1[k + 1, 0] == j && vitringuoi1[k + 1, 1] == i)
                                || (vitringuoi1[k, 0] <= j && j <= vitringuoi1[k + 1, 0] && vitringuoi1[k, 1] <= i && i <= vitringuoi1[k + 1, 1]))
                            {

                                z = 1;
                                Console.Write("|X ");
                                break;
                            }
                        }
                        else
                        {
                            if ((vitringuoi2[k, 0] == j && vitringuoi2[k, 1] == i) || (vitringuoi2[k + 1, 0] == j && vitringuoi2[k + 1, 1] == i)
                            || (vitringuoi2[k, 0] <= j && j <= vitringuoi2[k + 1, 0] && vitringuoi2[k, 1] <= i && i <= vitringuoi2[k + 1, 1]))
                            {

                                z = 1;
                                Console.Write("|X ");
                                break;
                            }
                        }



                    }
                    if (z != 1)
                    {
                        Console.Write("|  ");
                    }

                }
                Console.Write("|");

            }


        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*chonvitri();*/
            showlocation(1);
            showlocation(2);
            Console.WriteLine("\nnhap so làm chon vi tri de ban ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= 2 * n; i += 1)
            {
                int x = 0;int y = 0;
                Console.WriteLine("\nlần bắn  " + i / 2);
                if (i % 2 != 0)
                {
                    Console.WriteLine("\n vi tri ban cua nguoi choi 1");
                    Console.Write("Tọa độ x= ");
                     x = Int32.Parse(Console.ReadLine());
                    Console.Write("Tọa độ y= ");
                     y = Int32.Parse(Console.ReadLine());
                }
                else if (i % 2 == 0)
                {
                    Random rd = new Random();
                    Console.WriteLine("\n vi tri ban cua máy");
                    x = rd.Next(1, 10);
                    Console.Write("\nTọa độ x= "+x);
                     
                     y = rd.Next(1, 10);
                    Console.Write("\nTọa độ y= "+y);
                    
                }
                

                if (i % 2 != 0)
                {
                    kiemtradiem(x, y, 1);
                }
                else if (i % 2 == 0)
                {
                    kiemtradiem(x, y, 2);
                }
                Console.WriteLine("\ndiem so 1 " + diemnguoichoi1);
                Console.WriteLine("\ndiem so 2 " + diemnguoichoi2);
            }




        }
    }
}
