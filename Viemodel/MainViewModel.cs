using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viemodel
{
    public class MainViewModel
    {
        private readonly MyDbContext db;

        private CustomerViewModel customerViewModel;
        public CustomerViewModel CustomerViewModel
        {
            get => customerViewModel;
        }

        private ResourceViewModel resourceViewModel;
        public ResourceViewModel ResourceViewModel
        {
            get => resourceViewModel;
        }
        public MainViewModel()
        {

        }
        public MainViewModel(MyDbContext db)
        {
            this.db = db;
            customerViewModel = new CustomerViewModel(db);
            resourceViewModel = new ResourceViewModel(db);
        }
    }
}
