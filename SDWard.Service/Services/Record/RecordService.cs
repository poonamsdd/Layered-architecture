using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDWard.Repository.IRepository;
using ViewModels;
using SDWard.Repository.Repository.Record;

namespace SDWard.Service.Services.Record
{
    public class RecordService : IRecordService
    {
        private readonly IRecordRepository _reobj;
        public RecordService(IRecordRepository reobj)
        {
            this._reobj = reobj;
        }
        public IEnumerable<RecordModel> GetList()
        {
           return _reobj.GetRecordList(); 
        }

        public RecordModel GetRecordId(int id)
        {
            return _reobj.GetRecordByID(id);
        }

        public RecordModel Insert(RecordModel model)
        {
            model.AdmitDate = DateTime.Now;
            //model.DischargeDate = DateTime.Now;
            return _reobj.AddRecord(model);

        }

        public RecordModel Update(RecordModel model)
        {
            return _reobj.UpdateRecord(model);
        }
    }
}
