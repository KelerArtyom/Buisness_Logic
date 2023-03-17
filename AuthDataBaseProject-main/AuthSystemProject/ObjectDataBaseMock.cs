using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using static AuthSystemProject.Object_Flowers;
using static AuthSystemProject.User;

namespace AuthSystemProject
{
    public class ObjectDataBaseMock
    {
        private Object_Flowers[] Objects;

        public ObjectDataBaseMock(int length)
        {
            Objects = new Object_Flowers[length];
            Init();
        }

        public Object_Flowers[] GetAll()
        {
            return Objects;
        }


        public Object_Flowers? Get(string name)
        {
            foreach (Object_Flowers f in Objects)
            {
                if (f.Name.Equals(name))
                {
                    return f;
                }
            }

            return null;
        }

        public Object_Flowers? GetById(int id)
        {
            foreach (Object_Flowers f in Objects)
            {
                if (f.Id == id)
                {
                    return f;
                }
            }

            return null;
        }

        public Object_Flowers? AddById(int id, string name, string color)
        {
            {
                foreach (Object_Flowers f in Objects)
                {
                    if (f.Id == id)
                    {
                        f.Name = name;
                        f.Color = color;
                        Console.WriteLine("Object was succesfully recreate");
                        return f;
                    }
                    else if (id >= Objects.Length) 
                    {
                        Console.WriteLine("ID is too big");
                        return null;
                    }
                }
            }
            return null;
        }

        private void Init()
        {
            for (int i = 0; i < Objects.Length; i++)
            {
                Objects[i] = new Object_Flowers
                    (
                    "Sort_of_flower" + i,
                    "Color" + i
                    );
                Objects[i].Id = i;
            }
        }

    }
}

