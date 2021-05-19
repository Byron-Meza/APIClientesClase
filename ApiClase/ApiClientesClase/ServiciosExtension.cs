using CapaDatos;
using Entidades;
using Microsoft.Extensions.DependencyInjection;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utilidades.Interface;

namespace ApiClientesClase
{
    public static class ServiciosExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection service)
        {
            //Desde nuestro controlador hasta servicios 
            service.AddTransient<IGenericaServicios<TbCliente>, ClienteServicios>();

            //A la capa datos desde la capa servicios
            service.AddTransient<IGenericaDatos<TbCliente>, ClienteDatos>();
            return service;

        }
    }
}
