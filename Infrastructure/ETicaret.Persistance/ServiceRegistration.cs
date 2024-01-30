﻿using ETicaret.Application.Abstractions;
using ETicaret.Persistance.Concrete;
using ETicaret.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistance;
public static class ServiceRegistration
{
    public static void AddPersistanceServices(this IServiceCollection services)
    {
        services.AddDbContext<ETicaretDbContext>(opt => opt.UseNpgsql("User ID=postgres;Password=142314;Host=localhost;Port=5432;Database=ETicaretDb;"));
    }
}
