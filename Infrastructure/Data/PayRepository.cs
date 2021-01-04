using Core.Entities;
using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class PayRepository : EfRepository<Mobile>, IRepository<Mobile>
    {
        public PayRepository(AppDbContext ctx) : base(ctx)
        {
        }
    }
}
