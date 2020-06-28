using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public static List<SurveyModel> SurveyCollection = new List<SurveyModel>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetSurvey()
        {

            return View(SurveyCollection);
        }

        public ActionResult SaveSurvey()
        {
            // ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult SaveSurvey(SurveyModel sm)
        {
            var s = sm.FileName.Split('\\');
            var fileNameNew = s[s.Length - 1];

            sm.FileName = fileNameNew;
            SurveyCollection.Add(sm);


            //String str[] = sm.FileName.Split("\\");

            /*
            if(file.ContentLength>0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
                file.SaveAs(path);
            }
            */

            // return RedirectToAction("Index");

            //HttpFileCollectionBase files = Request.Files;


            /*if (file == null)
            {
                ModelState.AddModelError("CustomError", "Please select CV");
                return View();
            }
            if (!(file.ContentType == "application/vnd.openxmlformats-officedocument.wordprocessingml.document" ||
                file.ContentType == "application/pdf"))
            {
                ModelState.AddModelError("CustomError", "Only .docx and .pdf file allowed");
                return View();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    string fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                    file.SaveAs(Path.Combine(Server.MapPath("~/UploadedCV"), fileName));

                    sm.FileName = fileName;
                    SurveyCollection.Add(sm);

                    // ModelState.Clear();
                    ViewBag.Message = "Successfully Done";
                    return View();
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Error! Please try again";
                    return View();
                }
                //SurveyCollection.Add(sm);
                //return View();
            }*/

            return View();

        }
    }
}
   