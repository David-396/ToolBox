using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person man = new Person(1, 2);
            //Console.WriteLine(2333323);
            //Console.WriteLine(man.age);

            //calculator calc = new calculator(3);
            //calc.minus();
            //calc.plus();
            //calc.divide();
            //calc.times();
            //calc.print();

            //Agent moshe = new Agent("121", 2);
            //Report rep = new Report(12, 2, moshe);
            //MissionControl.AnalyzeReport(rep);
            //IntelTools.LogTransmission("moshe","hello");

            Hammer hammer = new Hammer("hammer", 6.5);
            Drill drill = new Drill("drill", 6.4);

            List<Tool> lstool = new List<Tool>();
            lstool.Add(hammer);
            lstool.Add(drill);
            Console.WriteLine(hammer.GetType());
            //foreach(Tool tool in lstool)
            //{
            //    tool.Describe();
            //    tool.Use();
            }
        }
    }
}
