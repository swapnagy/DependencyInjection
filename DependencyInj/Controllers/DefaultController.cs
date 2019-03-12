using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyInj.DomainModels;
using DependencyInj.ServiceLayer;
using DependencyInj.ViewModels;
   

namespace DependencyInj.Controllers
{
    public class DefaultController : Controller
    {
        IServiceStu ISerStuobj;
        //parameter constructor
        //public DefaultController(IServiceStu obj)
        //{
        //    ISerStuobj = obj;
        //}
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentViewModel st)
        {
            Student s = new Student();
            s.SNo = st.sno;
            s.Sname = st.sname;
            s.Saddr = st.saddress;
            ISerStuobj.InsertStudents(s);
            ViewBag.x = "row inserted";
            return View("Index");
        }
    }
}