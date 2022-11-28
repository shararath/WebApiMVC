using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApiMVC.Models;
using WebApiMVC.ViewModel;
using Newtonsoft.Json;

namespace WebApiMVC.Controllers
{
    public class TransactionDetailController : System.Web.Mvc.Controller
    {
        public ActionResult Index()
        {
          return  View("CreateTransaction");
        }
        // GET: TransactionDetail
        public ActionResult Transactions()
        {
            TransactionDetailClient TC = new TransactionDetailClient();
            ViewBag.listTransactions = TC.findAll();

            return View();
        }


        [HttpGet]
        public ActionResult CreateTransaction()
        {
            return View("CreateTransaction");
        }
        [HttpPost]
        public ActionResult CreateTransaction(TransactionDetailViewModel tdvm)
        {
            TransactionDetailClient TC = new TransactionDetailClient();
            TC.CreateTransaction(tdvm.transactions);
            return View();
        }
    }
}