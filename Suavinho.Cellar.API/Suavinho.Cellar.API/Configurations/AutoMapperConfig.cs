﻿using Microsoft.Extensions.DependencyInjection;
using Suavinho.Cellar.Application.AutoMapper;

namespace Suavinho.Cellar.API.Configurations
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(EntityToDTO), typeof(DTOToEntity));
        }
    }
}
