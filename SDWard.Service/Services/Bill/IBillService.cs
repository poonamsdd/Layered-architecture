using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Service.Services.Bill
{
  public  interface IBillService
    {
        BillingModel InsertBill(BillingModel model);
        BillingModel Update(BillingModel model);
        BillingModel Delete(int id);
        BillingModel GetBillById(int id);
        IEnumerable<BillingModel> GetList();
    }
}
