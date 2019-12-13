using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.ViewModels
{
    public class StoreListViewModel
    {
        public IEnumerable<Store> Stores { get; set; }
        public string PageTitle { get; set; }
    }
}
