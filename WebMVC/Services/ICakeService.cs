using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Models;
using static WebMVC.Infrastructure.ApiPath;

namespace WebMVC.Services
{
   public interface ICakeService
    {
        Task<CakeList> Cakes();
    }
}

