using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CountryViewer.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Microsoft.CodeAnalysis;
using System.Diagnostics;
using System.Text;

namespace CountryUI.Controllers
{
    public class HomeController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        string Baseurl = "https://restcountries.eu/rest/v2/all";
        public async Task<ActionResult> Index()
        {
            List<CountryModel> country = new List<CountryModel>();
            
            using (client)
            {
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //get all country Info 
                HttpResponseMessage Res = await client.GetAsync("https://restcountries.eu/rest/v2/all");

                if (Res.IsSuccessStatusCode)
                {
                    var CountryResponse = Res.Content.ReadAsStringAsync().Result;
                    country = JsonConvert.DeserializeObject<List<CountryModel>>(CountryResponse);
                    
                }
                

                return View(country);
            }

        }

        //incomplete Post Method 
        static async Task SendPost(CountryModel country)
        {
            var json = JsonConvert.SerializeObject(country);
            var content = new StringContent(json);
            Debug.WriteLine(content);

            var response = await client.PostAsync("https://enruolvzz04.x.pipedream.net/vengatest", content);

            var responseString = await response.Content.ReadAsStringAsync();

        }
    }
    }


