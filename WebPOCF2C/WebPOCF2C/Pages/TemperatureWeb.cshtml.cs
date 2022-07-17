using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebPOCF2C.Models;

namespace WebPOCF2C.Pages
{
    public class TemperatureWebModel : PageModel
    {
        public double TemperatureCelsius;
        public double TemperatureFarenheit;
        private Temperature temp;

        public void OnGet()
        {

        }

        public void OnPost()
        {
            temp = new Temperature();
            TemperatureCelsius = Convert.ToDouble(Request.Form["TemperatureCelsius"]);
            TemperatureFarenheit = temp.C2F(TemperatureCelsius);
        }
    }
}
