using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Db
{
    public interface ICommentsRepository
    {
        Task SaveAsync(Comment comment, Guid productId, Guid userId);
    }
}
