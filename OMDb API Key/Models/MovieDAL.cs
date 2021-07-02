using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OMDb_API_Key.Models
{
    public class MovieDAL
    {
        public string CallAPI(string searchType, string title)
        {
            string key = "554496dd";
            string url = @$"http://www.omdbapi.com/?{searchType}={title}&apikey={key}";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());

            string JSON = rd.ReadToEnd();
            rd.Close();

            return JSON;
        }

        public Movie GetMovie(string title)
        {
            string movieJson = CallAPI("t", title);
            Movie m = JsonConvert.DeserializeObject<Movie>(movieJson);
            return m;
        }

        //not needed at all for the lab but if i wanted to have the user search by series then this will do it
        public Search GetSearch(string title)
        {
            string searchJson = CallAPI("s", title);
            Search s = JsonConvert.DeserializeObject<Search>(searchJson);
            return s;
        }
    }
}
