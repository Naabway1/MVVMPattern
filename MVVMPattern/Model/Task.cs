using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPattern.Model
{
    internal class Task
    {
        private int _id;
        private string _name;
        private string _descriptionOfProblem;

        public Task(int id, string name, string descriptionOfProblem)
        {
            _id = id;
            _name = name;
            _descriptionOfProblem = descriptionOfProblem;
        }
    }
}
