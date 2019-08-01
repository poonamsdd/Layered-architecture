using SDWard.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Service.Services.Bill
{
    public class BillService : IBillService
    {
        private readonly IBilling_Repository _bill;

        public BillService(IBilling_Repository bill)
        {
            this._bill = bill;
        }
        public BillingModel Delete(int id)
        {
          return  _bill.DeleteBill(id);
        }

        public BillingModel GetBillById(int id)
        {
            return _bill.GetBillById(id);
        }

        public IEnumerable<BillingModel> GetList()
        {
            return _bill.GetBillList();
        }

        public BillingModel InsertBill(BillingModel model)
        {
            return _bill.AddBill(model);
        }

        public BillingModel Update(BillingModel model)
        {
            return _bill.UpdateBill(model);
        }
    }
}
