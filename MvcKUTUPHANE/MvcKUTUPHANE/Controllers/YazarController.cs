using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKUTUPHANE.Models.entity;
namespace MvcKUTUPHANE.Controllers
{
    public class YazarController : Controller
    {
        // GET: Yazar
        DBKUTUPHANEEntities DB=new DBKUTUPHANEEntities();
        public ActionResult Index()
        {
            var degerler = DB.TBLYAZAR.ToList();

            return View(degerler);
        }

        [HttpGet]
        public ActionResult YazarEkle()
        {
            return View();

        }
        public ActionResult YazarEkle(TBLYAZAR p)   

        {
            if (!ModelState.IsValid)
            {
                return View("YazarEkle");
            }

            DB.TBLYAZAR.Add(p);
            DB.SaveChanges();
            return View();

        }
        public ActionResult YazarSil(int id)
        {
            var yazar = DB.TBLYAZAR.Find(id);
            DB.TBLYAZAR.Remove(yazar);
            DB.SaveChanges();
            return RedirectToAction("Index");
            
        }
        public ActionResult YazarGetir(int id)
        {
            var yzr = DB.TBLYAZAR.Find(id);
            return View("YazarGetir",yzr);

        }
        public ActionResult YazarGuncelle(TBLYAZAR p)
        {
            var yzr = DB.TBLYAZAR.Find(p.ID);
            yzr.AD=p.AD;
            yzr.SOYAD=p.SOYAD;
            yzr.DETAY=p.DETAY;
            DB.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}