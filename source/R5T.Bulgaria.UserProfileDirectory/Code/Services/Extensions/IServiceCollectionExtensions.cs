using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy.Standard;
using R5T.Peristeria.Standard;
using R5T.Visigothia.Standard;

using R5T.Bulgaria.Visigothia;


namespace R5T.Bulgaria.UserProfileDirectory
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDropboxDirectoryPathProvider(this IServiceCollection services)
        {
            services
                .AddSingleton<IDropboxDirectoryPathProvider, UserProfileDropboxDirectoryPathProvider>()
                .AddDropboxDirectoryNameConvention()
                .AddUserProfileDirectoryPathProvider()
                .AddStringlyTypedPathOperator()
                ;

            return services;
        }
    }
}
