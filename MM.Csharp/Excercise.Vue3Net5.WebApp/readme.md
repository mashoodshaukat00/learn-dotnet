- Net Core Web API
- vue create clientapp
- - Default
- VueCliMiddleware (Install nuget package) by EEParker
	-- startup : 
			--  ConfigureServices : 
					services.AddSpaStaticFiles(configuration => {configuration.RootPath = "ClientApp";});
			-- Configure : 
					app.UseSpaStaticFiles();
					app.UseSpa(spa =>
                {
                    if (env.IsDevelopment())
                    {
                        spa.Options.SourcePath = "ClientApp/";
                        spa.UseVueCli(npmScript: "serve");
                    }
                    else
                    {
                        spa.Options.SourcePath = "dist";
                    }
                });
- npm install axios