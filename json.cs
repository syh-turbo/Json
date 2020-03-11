using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoLearning.VideoLearningServer
{
    public class json
    {
        static void Main(string[] args)

        {

            ShowData sd = new ShowData()

            {

                text1 = "百度",

                text2 = "baidu",

                text3 = "百度经验"

            };

            string jsonStr = JsonConvert.SerializeObject(sd);

            Console.WriteLine(jsonStr);

        }

    }

    public class ShowData

    {

        public string text1 { get; set; }

        public string text2 { get; set; }

        public string text3 { get; set; }

    }
}