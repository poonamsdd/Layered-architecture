using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViewModels;
using System.Threading.Tasks;

namespace SDWard.Repository.Repository.Record
{
  public  interface IRecordRepository
    {
        RecordModel AddRecord(RecordModel model);
        RecordModel UpdateRecord(RecordModel model);
       // int Delete(RecordModel model);
        RecordModel GetRecordByID(int id);
        List<RecordModel> GetRecordList();
    }
}
