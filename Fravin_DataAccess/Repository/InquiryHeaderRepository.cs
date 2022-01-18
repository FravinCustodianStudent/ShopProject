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
    public class InquiryHeaderRepository : Repository<InquiryHeader>, IInquiryHeaderRepository
    {
        private readonly ApplicationDbContext _db;
        public InquiryHeaderRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        
        public void Update(InquiryHeader obj)
        {
            //var objFromDb = _db.Category.FirstOrDefault(u=> u.Id== obj.Id);
            _db.InquiryHeader.Update(obj);
        }
    }
}
