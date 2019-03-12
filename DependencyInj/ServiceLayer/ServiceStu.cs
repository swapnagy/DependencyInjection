using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DependencyInj.DomainModels;
using DependencyInj.RepositaryLayer;
using DependencyInj.ServiceLayer;

namespace DependencyInj.ServiceLayer
{
    public class ServiceStu:IServiceStu
    {
        //stgDBEntities stdb = new stgDBEntities();
        RepositaryStu repStuCls = new RepositaryStu();
        public void InsertStudents(Student s)
        {
            if (s.Sname.Length <= 10)
            {
                repStuCls.InsertStudent(s);
            }
            else
            { }
        }
    }
}