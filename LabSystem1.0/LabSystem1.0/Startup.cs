﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabSystem1._0.Startup))]
namespace LabSystem1._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
