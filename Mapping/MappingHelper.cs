using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ForestClicker.Model.Models;
using ForestClicker.Model.ViewModels;

namespace ForestClicker.Model.Mapping
{
    public class MappingHelper
    {
        public Mapper RegisterMap()
        {
            return new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DataModel, DataViewModel>();
                cfg.CreateMap<DataViewModel, DataModel>();

                cfg.CreateMap<Forest, ForestViewModel>();
                cfg.CreateMap<ForestViewModel, Forest>();

                cfg.CreateMap<Animal, AnimalViewModel>();
                cfg.CreateMap<AnimalViewModel, Animal>();

                cfg.CreateMap<Poacher, PoacherViewModel>();
                cfg.CreateMap<PoacherViewModel, Poacher>();
            }));
        }
    }
}
