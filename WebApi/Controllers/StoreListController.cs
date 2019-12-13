using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Repository;
using WebApi.ViewModels;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreListController : ControllerBase
    {
        [HttpGet]
        public ActionResult<StoreListViewModel> Get()
        {
            var storeListViewModel = new StoreListViewModel();
            var storeRepository = new StoreRepository();
            storeListViewModel.PageTitle = "Store List";
            storeListViewModel.Stores = storeRepository.GetAll();
            return storeListViewModel;
        }
    }
}