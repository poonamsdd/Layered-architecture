using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Repository.IRepository
{
   public interface IBilling_Repository
    {
        BillingModel AddBill(BillingModel model);
        BillingModel UpdateBill(BillingModel se);
        BillingModel DeleteBill(int id);
        List<BillingModel>GetBillList();
        BillingModel GetBillById(int id);
    }
}
