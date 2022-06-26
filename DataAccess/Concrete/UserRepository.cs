using Core.DataAccess.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UserRepository : EfBaseRepository<User, ProductManagementDbContext>, IUserRepository
    {
     
        public List<OperationClaim> GetClaims(User user)
        {
            using(var context= new ProductManagementDbContext())
            {
                var result = from operationClaims in context.OperationClaims
                             join userOperationClaims in context.UserOperationClaims
                             on operationClaims.Id equals userOperationClaims.Id
                             where userOperationClaims.UserId == user.Id
                             select new OperationClaim() { Id = operationClaims.Id, Name = operationClaims.Name };
                return result.ToList();
            }
        }
    }
}
