using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace lab3_2test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> List1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<string> List2 = new List<string>() { "One", "two", "three", "four", "five" };
            Dictionary<int, List<string>> dict = new Dictionary<int, List<string>>();

            foreach (int n in List1)
                dict.Add(n, List2);

            var jsonS = JsonConvert.SerializeObject(dict);
            File.WriteAllText("D:\\Университет\\1 курс\\2 cеместр\\ОП\\lab3\\lab3_2\\lab3_2\\Laba.json", jsonS);
        }
    }
}
