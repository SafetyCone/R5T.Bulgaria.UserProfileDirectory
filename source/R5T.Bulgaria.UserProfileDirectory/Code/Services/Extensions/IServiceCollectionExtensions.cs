using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy.Standard;
using R5T.Peristeria.Standard;
using R5T.Visigothia.Standard;

using R5T.Bulgaria.Visigothia;


namespace R5T.Bulgaria.UserProfileDirectory
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IDropboxDirectoryPathProvider"/> service.
        /// </summary>
        public static IServiceCollection AddDropboxDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddUserProfileDropboxDirectoryPathProvider(
                services.AddUserProfileDirectoryPathProviderAction(),
                services.AddDropboxDirectoryNameConventionAction(),
                services.AddStringlyTypedPathOperatorAction());

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IDropboxDirectoryPathProvider"/> service.
        /// </summary>
        public static ServiceAction<IDropboxDirectoryPathProvider> AddDropboxDirectoryPathProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IDropboxDirectoryPathProvider>(() => services.AddDropboxDirectoryPathProvider());
            return serviceAction;
        }
    }
}
