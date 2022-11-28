using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;

namespace WebApiMVC.Models
{
    public class TransactionDetailClient
    {
        private string Base_URL = "http://localhost:50985/api/";

        public IEnumerable<TransactionDetail> findAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("Transactions").Result;

                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<IEnumerable<TransactionDetail>>().Result;
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public bool CreateTransaction(TransactionDetail transaction)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("transactions", transaction).Result;
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}