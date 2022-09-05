using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    internal class Demo
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Demo(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}";
        }
    }
}