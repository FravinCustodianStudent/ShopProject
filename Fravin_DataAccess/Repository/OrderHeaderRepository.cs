using Fravin_DataAccess.Data;
using Fravin_DataAccess.Repository.IRepository;
using Fravin_Models;
using Fravin_Utility;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fravin_DataAccess.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderHeaderRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        
        public void Update(OrderHeader obj)
        {
            //var objFromDb = _db.Category.FirstOrDefault(u=> u.Id== obj.Id);
            _db.OrderHeader.Update(obj);
        }
    }
}
