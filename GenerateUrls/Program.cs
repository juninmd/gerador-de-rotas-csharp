using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Routing;

namespace GenerateUrls
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<string[]> parametros = new List<string[]>()
            {
               new []{"nome","Maria"},
               new []{"numero","14555"},
               new []{"cidade","Franca"},

            };
            var rota = GenerateRoute(parametros);
            var rotaquery = GenerateRouteQuery(parametros);
 
        }

        private static RouteData GenerateRoute(IEnumerable<string[]> paramters)
        {
            var result = new RouteData();
            foreach (var paramter in paramters)
            {
                result.Values.Add(paramter[0], paramter[1]);
            }
            return result;
        }
        private static string GenerateRouteQuery(IEnumerable<string[]> paramters)
        {
            var builder = new UriBuilder("http://example.com");
            var query = HttpUtility.ParseQueryString(builder.Query);
            builder.Port = -1;

            foreach (var paramter in paramters)
            {
                query[paramter[0]] = paramter[1];
            }
            builder.Query = query.ToString();
            return builder.ToString(); 
        }
    }
}
