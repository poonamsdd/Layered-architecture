using SDWard.Repository.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDWard.Service.Services
{
   public static class MapperInitialize
    {
        public static void Init()
        {
            AutoMapper.AutoIni();
        }
    }
}
