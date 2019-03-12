using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DependencyInj.DomainModels;
using DependencyInj.RepositaryLayer;

namespace DependencyInj.RepositaryLayer
{
    public class RepositaryStu:IRepositaryStu
    {
        public void InsertStudent(Student s)
        {
            using (stgDBEntities stgdb = new stgDBEntities())
            {
                stgdb.Students.Add(s);
                stgdb.SaveChanges();
            }
        }
    }
}