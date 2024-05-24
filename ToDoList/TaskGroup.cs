using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class TaskGroup
    {
        public string Name { get; set; }

        public TaskGroup(string name)
        {
            Name = name;
        }
    }
}
