using Mapster;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UsingMapster.DTOs;
using UsingMapster.Entites;

namespace UsingMapster
{
    public static class MapsterConfig
    {
        public static void MapsterConfigRegistration(this ServiceCollection service)
        {
            TypeAdapterConfig<User, UserViewModel>.NewConfig()
                .Map(dest => dest.FullName, src => src.Firstname + " " + src.Lastname);
            
            
            TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
        }
    }
}
