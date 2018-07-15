using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorServerSide.Server.DataAccess;
using BlazorServerSide.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorServerSide.Server.Controllers
{
    public class CountriesController : Controller
    {
        ComboboxDataAccessClass objCountry = new ComboboxDataAccessClass();

        [HttpGet]
        [Route("api/Countries/GetCountryList")]
        public IEnumerable<Country> GetCountryList()
        {
            return objCountry.GetAllCountries();
        }

        [HttpGet]
        [Route("api/Countries/GetCities/{id}")]
        public IEnumerable<Cities> GetCities(string id)
        {
            return objCountry.GetCityData(id);
        }
    }
}