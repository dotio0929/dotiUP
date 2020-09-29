using System;
using System.IO;

namespace 乱数生成プログラム
{
    class Program
    {
        static void Main(string[] args)
        {
            string DataPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\RandomData.csv";

            Console.WriteLine("データを生成します。");
            Console.WriteLine("データを生成しています…しばらくお待ちください。");

            FileStream fs = System.IO.File.Create(DataPath);
            fs.Close();

            using (StreamWriter sw = new StreamWriter(DataPath))
            {
                int RoopCount = 0;
                int Seed = Environment.TickCount;
                Random rnddd = new Random();
                int MaxRoop = 1000;


                while (true)
                {
                    Random SeedRoopCountRondom = new Random();
                    int SeedRoopCount = SeedRoopCountRondom.Next(200);
                    for (int i = 0; i < 200; i++)
                    {
                        rnddd = new Random(Seed++);
                        if (i == SeedRoopCount)
                        {
                            break;
                        }
                    }

                    int value = rnddd.Next(1, 100000);
                    System.Threading.Thread.Sleep(51);
                    sw.WriteLine(value);

                    if (RoopCount == MaxRoop)
                    {
                        break;
                    }

                    RoopCount++;

                }

                Console.WriteLine("データ出力完了");
                Console.ReadKey();


            }
        }

    }
}

