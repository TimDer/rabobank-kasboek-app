using Microsoft.Extensions.FileProviders;

namespace rabobankKasboekApp;

public static class WwwRootDirs
{
    public static void SetWwwRoorDirsServices(this IServiceCollection services)
    {
        //
    }

    public static void SetAllWwwRootDirs(this WebApplication? app, string currentDirectory)
    {
        if (app != null)
        {
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(currentDirectory + "/login/www"),
                RequestPath = "/login/www",
            });
        }
    }
}
