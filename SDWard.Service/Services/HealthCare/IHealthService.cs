using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Service.Services.HealthCare
{
  public interface IHealthService
  {
        HealthNotesModel Insert(HealthNotesModel model);
        HealthNotesModel Update(HealthNotesModel model);
        HealthNotesModel Delete(int id);
        HealthNotesModel GetById(int id);
       IEnumerable<HealthNotesModel> GetList();
  }
}

