using Fravin_Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fravin_DataAccess.Repository.IRepository
{
    public interface IInquiryDetailRepository : IRepository<InquiryDetail>
    {
        void Update(InquiryDetail obj);
    }
}
