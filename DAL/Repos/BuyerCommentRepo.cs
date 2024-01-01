using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BuyerCommentRepo : Repo, IRepo<BuyerComment, int, bool>
    {
        public bool Create(BuyerComment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BuyerComment> Read()
        {
            throw new NotImplementedException();
        }

        public BuyerComment Read(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(BuyerComment obj)
        {
            throw new NotImplementedException();
        }
    }
}
