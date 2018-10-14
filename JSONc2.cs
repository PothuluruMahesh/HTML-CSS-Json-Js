using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace JsonwithC
{
    class State
    {
        public string City { get; set; }
        public int PC { get; set; }
        public override string ToString()
        {
            return string.Format("Name: {0} \nAge: {1}", City, PC);
        }
    }
    class JSONc2
    {
        static void Main(string[] args)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            State s1 = new State() { City = "Kadapa", PC = 516003 };
            string Outjson = jss.Serialize(s1);
            File.WriteAllText(@"F:\JAVA\C#\JsonwithC\JsonwithC\Json2.json", Outjson);
            Console.WriteLine("Done");
        }
    }
}
