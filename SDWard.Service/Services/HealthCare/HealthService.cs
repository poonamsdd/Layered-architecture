using SDWard.Repository.Repository.HealthNotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Service.Services.HealthCare
{
    public class HealthService : IHealthService
    {
        private readonly IHeathRepository _health;
        public HealthService(IHeathRepository health)
        {
            _health = health;
        }
        public HealthNotesModel Delete(int id)
        {
            return _health.DeleteHealth(id);
        }

        public HealthNotesModel GetById(int id)
        {
            return _health.GetHealthById(id);
        }

        public IEnumerable<HealthNotesModel> GetList()
        {
            return _health.GetHealthList();
        }

        public HealthNotesModel Insert(HealthNotesModel model)
        {
            return _health.AddHealth(model);

        }

        public HealthNotesModel Update(HealthNotesModel model)
        {
            return _health.UpdateHealth(model);
        }
    }
}
