﻿using System.Reflection;
using Abp.Modules;

namespace Abp.Web.SimpleCaptcha
{
    public class SimpleCaptchaModule : AbpModule
    {
        public override void PreInitialize()
        {
            IocManager.Register<ISimpleCaptchaModuleConfig, SimpleCaptchaModuleConfig>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
