using Fravin_DataAccess.Data;
using Fravin_DataAccess.Repository.IRepository;
using Fravin_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fravin_DataAccess.Repository
{
    public class AplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;
        public AplicationUserRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
    }
}
