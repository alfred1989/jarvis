using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientEx
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var client = new HttpClient();
            var content = await client.GetStringAsync("https://app.remoteme.org/api/~449981_vdlin2pEBmP3/rest/v1/variable/get/variableValue/Distance/INTEGER/?fbclid=IwAR3hxR1g1shrFBEqPEgVkHQpKxKq8I9AJbhAxpvHOhkun2v_Yzit7w09WT4");

            //Console.WriteLine(content);
            int distance = Convert.ToInt32(content);

            int sum = 0;
                if (distance < 8)
                {
                    sum = 100;
                }
                else if (distance < 16 && distance > 8)
                {
                    sum = 90;
                }
                else if (distance < 24 && distance > 16)
                {
                    sum = 80;
                }
                else if (distance < 32 && distance > 24)
                {
                    sum = 70;
                }
                else if (distance < 40 && distance > 32)
                {
                    sum = 60;
                }
                else if (distance < 48 && distance > 40)
                {
                    sum = 50;
                }
                else if (distance < 56 && distance > 48)
                {
                    sum = 40;
                }
                else if (distance < 64 && distance > 56)
                {
                    sum = 30;
                }
                else if (distance < 67 && distance > 56)
                {
                    sum = 20;
                }
                else if (distance < 74 && distance > 67)
                {
                    sum = 10;
                }
                else if (distance <= 80 && distance > 74)
                {
                    sum = 5;
                }
            int finalMeasurement = sum + 8;
            string saveStan = Convert.ToString(finalMeasurement);

            string s = saveStan;
            File.WriteAllText(@"C:\Users\pliki\source\repos\testO\stan.txt", s);

            Console.WriteLine(finalMeasurement);
            Console.ReadKey();
        }
    }
}