using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class TransactionsController : ApiController
    {
        private SystemTestEntities db = new SystemTestEntities();

        // GET: api/Customers
        public IQueryable<TransactionDetail> GetTransactions()
        {
            return db.TransactionDetails;
        }

        // POST: api/Customers
        [ResponseType(typeof(TransactionDetail))]
        public IHttpActionResult PostTransactionDetail(TransactionDetail transactionDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TransactionDetails.Add(transactionDetail);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = transactionDetail.TransactionId }, transactionDetail);
        }
    }
}