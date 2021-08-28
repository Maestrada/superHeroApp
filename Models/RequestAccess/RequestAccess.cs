
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

using System.Web.Configuration;

namespace superHeroApp.Models.RequestAccess
{
    public class RequestAccess
    {
        //HttpClient client = new HttpClient();
        public RequestAccess()
        {
            //client.BaseAddress = new Uri("https://superheroapi.com/api/" + WebConfigurationManager.AppSettings["heroToken"]);
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> SearchHero(string search)
        {
          
            string result = "";
            WebRequest oRequest = WebRequest.Create("https://superheroapi.com/api/" + WebConfigurationManager.AppSettings["heroToken"]+"/search/"+search);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            result = await sr.ReadToEndAsync();
            return result;
        }

        public async Task<string> GetHero(int id)
        {
            string result = "";
            WebRequest oRequest = WebRequest.Create("https://superheroapi.com/api/" + WebConfigurationManager.AppSettings["heroToken"] + "/" + id);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            result = await sr.ReadToEndAsync();
            return result;
        }
    }
}