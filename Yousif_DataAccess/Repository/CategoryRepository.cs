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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
        public void Update(Category obj)
        {
            var objFormDb = base.FirstOrDefault(u=>u.Id==obj.Id);
            if(objFormDb == null)
            { 
                objFormDb.Name = obj.Name;
                objFormDb.DisplayOrder = obj.DisplayOrder;
            }
        }
    }
}
