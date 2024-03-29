﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRep());
        [HttpGet]   
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public  IActionResult Index(Writer writer)
        {
            WriterValidator wv= new WriterValidator(); 
            ValidationResult results= wv.Validate(writer);
            if (results.IsValid)
            {
                wv.Validate(writer);
                writer.WriterStatus = true;
                writer.WriterAbout = "test";
                wm.WriterAdd(writer);

                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
                return View();  
            }
           
        }
    }
}
