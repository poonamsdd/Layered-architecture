using AutoMapper;
using SDWard.Entity.Entities;
using SDWard.Repository.BaseRepository;
using SDWard.Repository.IRepository;
using SDWard.Repository.Repository.Record;
using SDWard.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Repository.Repository
{
    public class BillingRepository :GenericRepository<Billing_table_Poonam>, IBilling_Repository
    {
        private readonly IUOW _iuow;
        private readonly IRecordRepository _patient;
        public BillingRepository(IUOW iuow, IRecordRepository patient) : base(iuow.DbContext())
        {
            _patient = patient;
            this._iuow = iuow;
        }

        public BillingModel AddBill(BillingModel model)
        {
            base.Add(Mapper.Map<BillingModel, Billing_table_Poonam>(model));
            _iuow.SaveChanges();
            _iuow.Dispose();
            return model;
        }

        public BillingModel DeleteBill(int id)
        {
            var del = _object.Where(x => x.Bill_Id == id).FirstOrDefault();
            if (del == null)
            {
                return null;
            }
            base.Delete(del);
            _iuow.SaveChanges();
            _iuow.Dispose();
            return Mapper.Map<Billing_table_Poonam, BillingModel>(del);
        }

        public BillingModel GetBillById(int id)
        {
            return (from x in base.GetList().Where(a => a.Bill_Id == id)
                    join y in _patient.GetRecordList() on x.RecordId equals y.RecordId
                    select new BillingModel()
                    {
                        Bill_Id = x.Bill_Id,
                         RecordId = x.RecordId,
                        MedicineName = x.MedicineName,
                         //AdmitDate = x.AdmitDate
                         TotalBill=x.TotalBill
                          

                    }).FirstOrDefault();
          
        }

        public List<BillingModel> GetBillList()
        {
            return Mapper.Map<IEnumerable<Billing_table_Poonam>, IEnumerable<BillingModel>>(base.GetList()).ToList();
        }

        public BillingModel UpdateBill(BillingModel model)
        {
            base.Update(Mapper.Map<BillingModel, Billing_table_Poonam>(model));
            _iuow.SaveChanges();
            _iuow.Dispose();
            return model;
        }
    }
}
