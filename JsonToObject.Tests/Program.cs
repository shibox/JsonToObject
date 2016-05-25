using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToObject.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = "[{'IsFacet':false,'IsSegment':true,'Weigh':1,'FieldOption':67,'Data':'数据库也出“Windows”，数据“砖”家？你也行','Name':'title','Type':0,'Flag':0}]";
            string classCode = JsonClassGenerator.GenerateString(json);
            Console.WriteLine(classCode);
            Console.ReadLine();
        }
    }
}
