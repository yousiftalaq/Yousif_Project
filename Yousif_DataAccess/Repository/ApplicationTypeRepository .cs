using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yousif_DataAccess.Data;
using Yousif_DataAccess.Repository.IRepository;
using Yousif_Models.Models;

namespace Yousif_DataAccess.Repository
{
    public class ApplicationTypeRepository : Repository<ApplicationType>, IApplicationTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public ApplicationTypeRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
        public void Update(ApplicationType obj)
        {
            var objFormDb = base.FirstOrDefault(u=>u.Id==obj.Id);
            if(objFormDb == null)
            { 
                objFormDb.Name = obj.Name;
            }
        }
    }
}
