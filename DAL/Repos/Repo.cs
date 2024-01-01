using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class Repo
    {
        internal ProductContext db;
        internal Repo()
        {
            db = new ProductContext();
        }
    }
}
