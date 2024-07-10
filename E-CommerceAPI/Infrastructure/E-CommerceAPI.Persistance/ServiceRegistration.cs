using E_CommerceAPI.Application.Abstarction;
using E_CommerceAPI.Persistance.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Persistance
{
    public static  class ServiceRegistration
    {
        public static void AddPersistanceServices( this IServiceCollection services)
        {
            services.AddSingleton<IProductSercive,ProductService>();
        }
    }
}
