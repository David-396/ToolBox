using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
     abstract class Tool
    {
        protected string Name;
        protected double Weight;
        protected int UseCount;

        public Tool(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        abstract public void Describe();

        abstract public void Use();
    }


    internal class Hammer : Tool
    {
        public Hammer(string name, double weight) : base(name, weight){}

        public override void Describe()
        {
            Console.WriteLine($"a hammer named {this.Name} , weight: {this.Weight}");
        }

        public override void Use()
        {
            this.UseCount++;
            Console.WriteLine($"{this.Name} is being used.");
        }
    }



    internal class Wrench : Tool
    {
        public Wrench(string name, double weight) : base(name, weight) { }

        public override void Describe()
        {
            Console.WriteLine($"a hammer named {this.Name} , weight: {this.Weight}");
        }

        public override void Use()
        {
            this.UseCount++;
            Console.WriteLine($"{this.Name} is being used.");
        }
    }




    internal class Drill : Tool
    {
        public Drill(string name, double weight) : base(name, weight) { }

        public override void Describe()
        {
            Console.WriteLine($"a hammer named {this.Name} , weight: {this.Weight}");
        }

        public override void Use()
        {
            this.UseCount++;
            Console.WriteLine($"{this.Name} is being used.");
        }
    }


    internal class Saw : Tool
    {
        public Saw(string name, double weight) : base(name, weight) { }

        public override void Describe()
        {
            Console.WriteLine($"a hammer named {this.Name} , weight: {this.Weight}");
        }

        public override void Use()
        {
            this.UseCount++;
            Console.WriteLine($"{this.Name} is being used.");
        }
    }



    internal class Screwdriver : Tool
    {
        public Screwdriver(string name, double weight) : base(name, weight) { }

        public override void Describe()
        {
            Console.WriteLine($"a hammer named {this.Name} , weight: {this.Weight}");
        }

        public override void Use()
        {
            this.UseCount++;
            Console.WriteLine($"{this.Name} is being used.");
        }
    }



    internal class PipeCutter : Tool
    {
        public PipeCutter(string name, double weight) : base(name, weight) { }

        public override void Describe()
        {
            Console.WriteLine($"a hammer named {this.Name} , weight: {this.Weight}");
        }

        public override void Use()
        {
            this.UseCount++;
            Console.WriteLine($"{this.Name} is being used.");
        }
    }


    internal class Toolbox
    {
        private List<Tool> lstool;
        private Dictionary<string, List<Tool>> ToolCategory;

        public Toolbox()
        {
            Dictionary<string, List<Tool>> ToolCategory = new Dictionary<string, List<Tool>>();
            this.ToolCategory["cutting"] = new List<Tool>();
            this.ToolCategory["fastening"] = new List<Tool>();
            this.ToolCategory["drilling"] = new List<Tool>();
        }


        public void AddTool(Tool tool)
        {
            this.lstool.Add(tool);

            if (tool.GetType() == typeof(Hammer) || tool.GetType() == typeof(PipeCutter) || tool.GetType() == typeof(Saw))
            {
                this.ToolCategory["cutting"].Add(tool);
            }
            else if (tool.GetType() == typeof(Screwdriver) || tool.GetType() == typeof(Wrench))
            {
                this.ToolCategory["fastening"].Add(tool);
            }
            else
            {
                this.ToolCategory["drilling"].Add(tool);
            }
        }
    }

}
