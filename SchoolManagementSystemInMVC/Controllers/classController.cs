﻿using Microsoft.Ajax.Utilities;
using SchoolManagementSystemInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementSystemInMVC.Controllers
{
    public class classController : Controller
    {
        // GET: class
        StudentDataEntities db = new StudentDataEntities();
        // GET: Class
        public ActionResult Index()
        {
            List<ClassModel> classlist = new List<ClassModel>();
            List<Class> c = db.Classes.ToList();

            foreach (var item in c)
            {
                ClassModel s = new ClassModel();
                s.ClassID = item.ClassID;
                s.ClassName = item.ClassName;
                classlist.Add(s);
            }
            return View(classlist);
        }

        // GET: Class/Details/5
        public ActionResult Details(int id)
        {
            Class c = db.Classes.Find(id);
            ClassModel s = new ClassModel();
            s.ClassID = c.ClassID;
            s.ClassName = c.ClassName;
            return View(s);
        }

        // GET: Class/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Class/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                ClassModel c = new ClassModel();
                c.ClassName = collection["ClassName"].ToString();

                Class s = new Class();
                s.ClassName = c.ClassName;
                db.Classes.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Class/Edit/5
        public ActionResult Edit(int id)
        {
            Class c = db.Classes.Find(id);
            ClassModel s = new ClassModel();
            s.ClassID = c.ClassID;
            s.ClassName = c.ClassName;
            return View(s);
        }

        // POST: Class/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Class c = db.Classes.Find(id);
                c.ClassName = collection["ClassName"].ToString();
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Class/Delete/5
        public ActionResult Delete(int id)
        {
            Class c = db.Classes.Find(id);
            ClassModel s = new ClassModel();
            s.ClassID = c.ClassID;
            s.ClassName = c.ClassName;
            return View(s);
        }

        // POST: Class/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Class c = db.Classes.Find(id);
                db.Classes.Remove(c);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }

    internal class ClassModel
    {
        public int ClassID { get; internal set; }
        public string ClassName { get; internal set; }
    }
}