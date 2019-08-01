using SDWard.Entity.Entities;
using SDWard.Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDWard.Data.Infrastructure;
using ViewModels;
using SDWard.Repository.UnitOfWork;
using AutoMapper;

namespace SDWard.Repository.Repository.HealthNotes
{
    public class HealthRepository : GenericRepository<HealthNotes_Poonam>, IHeathRepository
    {
        private readonly IUOW _uow;
        public HealthRepository(IUOW uow) : base(uow.DbContext())
        {
            _uow = uow;
        }

        public HealthNotesModel AddHealth(HealthNotesModel schedue)
        {
            base.Add(Mapper.Map<HealthNotesModel, HealthNotes_Poonam>(schedue));
            _uow.SaveChanges();
            _uow.Dispose();
            return schedue;
        }

        public HealthNotesModel DeleteHealth(int Id)
        {
            var a = _object.Where(x => x.HealthNoteId == Id).FirstOrDefault();
            if (a==null)
            {
                return null;
            }
            base.Delete(a);
            _uow.SaveChanges();
          return  Mapper.Map<HealthNotes_Poonam, HealthNotesModel>(a);
        }

        public HealthNotesModel GetHealthById(int Id)
        {
            return Mapper.Map<HealthNotes_Poonam, HealthNotesModel>(base.GetById(Id));
        }

        public List<HealthNotesModel> GetHealthList()
        {
            return Mapper.Map<IEnumerable<HealthNotes_Poonam>, IEnumerable<HealthNotesModel>>(base.GetList()).ToList();
        }

        public HealthNotesModel UpdateHealth(HealthNotesModel schedule)
        {
            var obj = Mapper.Map<HealthNotesModel, HealthNotes_Poonam>(schedule);
            base.Update(obj);
            _uow.SaveChanges();
            _uow.Dispose();
            return schedule;
        }
    }
}
