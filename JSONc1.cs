using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Serialization;

namespace JsonwithC
{
    class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public override string ToString()
        {
            return string.Format("Name: {0} \nAge: {1}", Name, Age);
        }
    }
    class JSONc1
    {
        static void Main(string[] args)
        {
            String str = File.ReadAllText(@"F:\JAVA\C#\JsonwithC\JsonwithC\Json1.json");
            JavaScriptSerializer jss = new JavaScriptSerializer();
            Person p1 = jss.Deserialize<Person>(str);
            Console.WriteLine(p1);
        }
    }
}
