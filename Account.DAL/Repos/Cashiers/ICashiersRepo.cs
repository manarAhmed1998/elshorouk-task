using Account.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.DAL;

public interface ICashiersRepo
{
    public void Delete(Cashier cashier);
}
