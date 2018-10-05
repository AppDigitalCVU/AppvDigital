using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AppUscv.Domain;
using AppvDigital.ViewModel;

namespace AppvDigital.Infrastructure
{
    public class AutomapperWebprofile : AutoMapper.Profile
    {
        public static void Run()
        {
            AutoMapper.Mapper.Initialize(a => {

                a.AddProfile<AutomapperWebprofile>();


            });
        }

        public AutomapperWebprofile()
        {
            CreateMap<PersonalDomainModel, ViewModelPersonal>();
            //aplicamos la ingenieria inversa
            CreateMap<ViewModelPersonal, PersonalDomainModel>();
        }
    }
}