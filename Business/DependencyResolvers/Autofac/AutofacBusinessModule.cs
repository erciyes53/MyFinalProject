﻿using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
   public class AutofacBusinessModule :Module
    {
        //autofac modulu kuruyoruz bir startup.cs mantığı
        protected override void Load(ContainerBuilder builder)
        {
            //uygulama çalıştığında çalışcak
            //biri senden ıproductservice  isterse productmanager ver demek alttaki kod
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
        }
    }
}