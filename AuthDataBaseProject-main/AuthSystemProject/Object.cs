using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AuthSystemProject.User;

namespace AuthSystemProject
{
    public class Object_Flowers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Object_Flowers(string name, string color)
        {
            Name = name;
            Color = color;
        }
    }
}
