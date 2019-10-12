using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Infrastructure
{
    public class ApiPath
    {
        public static class Cake
        {
            public static string GetAllTypes(string baseUri)
            {
                return $"{baseUri}Cakes";
            }
        }
    }
}
