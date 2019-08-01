using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace SDWard.Repository.Repository.HealthNotes
{
    public interface IHeathRepository
    {
        HealthNotesModel AddHealth(HealthNotesModel schedue);
        HealthNotesModel GetHealthById(int Id);
        HealthNotesModel UpdateHealth(HealthNotesModel schedule);
        HealthNotesModel DeleteHealth(int Id);
        List<HealthNotesModel> GetHealthList();
    }
}
