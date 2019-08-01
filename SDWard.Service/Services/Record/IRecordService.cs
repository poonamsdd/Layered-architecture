using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Service.Services.Record
{
  public  interface IRecordService
    {
        RecordModel Insert(RecordModel model);
        RecordModel Update(RecordModel model);
       // RecordModel Delete(int id);
        RecordModel GetRecordId(int id);
        IEnumerable<RecordModel> GetList();
    }
}
