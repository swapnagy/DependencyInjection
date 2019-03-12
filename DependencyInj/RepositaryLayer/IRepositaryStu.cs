using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInj.DomainModels;

namespace DependencyInj.RepositaryLayer
{
    interface IRepositaryStu
    {
         void InsertStudent(Student s);
    }
}
