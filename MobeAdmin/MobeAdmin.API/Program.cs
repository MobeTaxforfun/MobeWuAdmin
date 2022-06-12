using MobeAdmin.API;
{
    CreateWebHostBuilder(args).Build().Run();
}

IHostBuilder CreateWebHostBuilder(string[] args) =>
Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder
            //.UseKestrel(serverOptions =>
            //{
            //    // Set properties and call methods on options
            //serverOptions.AllowSynchronousIO = true;
            //})
            //.UseIIS()
            //.UseIISIntegration()
            .UseStartup<Startup>();
    });
