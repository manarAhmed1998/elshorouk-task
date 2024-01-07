using Account.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.DAL;

public class CashiersRepo : ICashiersRepo
{
    public CashiersRepo(ShaTaskContext context)
    {
        
    }
    public void Delete(Cashier cashier)
    {
        throw new NotImplementedException();
    }
}
