using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PozadavkyZakazniku.Model;
using PozadavkyZakazniku.Repository;




namespace PozadavkyZakazniku.Repository.Mappers
{

    public class MaperDbToModel : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToModelMappingProfile";
            }
        }

        public MaperDbToModel()
        {
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<Request, RequestModel>().ReverseMap();
            CreateMap<Status, StatusModel>().ReverseMap();
            CreateMap<Module, ModuleModel>().ReverseMap();

        }


    }

}
