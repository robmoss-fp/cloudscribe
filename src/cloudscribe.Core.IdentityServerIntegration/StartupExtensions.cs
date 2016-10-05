﻿using cloudscribe.Core.Identity;
using cloudscribe.Core.IdentityServerIntegration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.FileProviders;
using System.Reflection;

// https://github.com/IdentityServer/IdentityServer4/issues/19

namespace Microsoft.Extensions.DependencyInjection
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddCloudscribeIdentityServerIntegration(this IServiceCollection services)
        {
            services.AddScoped<IIdentityServerIntegration, Integration>();

            return services;
        }

        public static RazorViewEngineOptions AddEmbeddedViewsForCloudscribeIdentityServerIntegration(this RazorViewEngineOptions options)
        {
            options.FileProviders.Add(new EmbeddedFileProvider(
                    typeof(Integration).GetTypeInfo().Assembly,
                    "cloudscribe.Core.IdentityServerIntegration"
                ));

            return options;
        }

    }
}
