﻿using System.Web.Mvc;
using FluentValidation;
using FluentValidation.Mvc;
using Ninject;
using Ninject.Modules;


namespace ISIS.Web
{
    public class ValidatorModule
        : NinjectModule 
    {
        public override void Load()
        {
            Kernel.Bind<IValidatorFactory>().To<ValidatorFactory>().InSingletonScope();


            DataAnnotationsModelValidatorProvider
                .AddImplicitRequiredAttributeForValueTypes = false;

            ModelValidatorProviders.Providers.Add(
                new FluentValidationModelValidatorProvider(Kernel.Get<IValidatorFactory>()));

        }
    }
}