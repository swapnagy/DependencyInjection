using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInj.DomainModels;
using DependencyInj.RepositaryLayer;

namespace DependencyInj.ServiceLayer
{
    interface IServiceStu
    {
        void InsertStudents(Student s);
    }
}
