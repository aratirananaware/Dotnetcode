using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
namespace Set_3_Solutions
{
    class Program2
    {
        private static int num = 5;
        public int myNum
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }
        static void Main1(string[] args)
        {
            Program2 p = new Program2();
            Type t = typeof(Program2);
            Console.WriteLine(p.GetTypeNamespace(t));
            p.GetTypeName(t);
            p.GetTypeInfo(t);
            p.GetTypeInfo(t, "myNum");
            Console.Read();
        }
        public string GetTypeName(Type type)
        {
            return type.Name;
        }
        public string GetTypeNamespace(Type type)
        {
            return type.Namespace;
        }
        public Type GetTypeInfo(Type type, string varName)
        {
            return type;
        }
        public Type GetTypeInfo(Type type, string varName, string arg)
        {
            return type;
        }
        public string GetTypeInfo(Type t)
        {
            return t.Name;
        }
    }
}
