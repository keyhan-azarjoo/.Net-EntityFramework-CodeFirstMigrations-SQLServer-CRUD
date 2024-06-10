1. Create your Entity
2. Create your DataContext Class
3. add your connection string t appsettings.json

		"ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=MyEntityTable;Trusted_Connection=true;TrustServerCertificate=True;"
},

4. install Microsoft.EntityFrameworkCore.SQLServer from nugetpackagemanmagment
5. Add your DbContext to your program.cs


builder.Services.AddDbContext<DataContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefultConnection"));
});


6. install Microsoft.EntityFrameworkCore.tools from nugetPackagemanagment to use migeration and update your database



7. For Migration:

  use Package Manager Console
	add-Migration Initial
	Update-Database

8. For usinf DbContext in Controller, we need to inject the DbContext to the controller

9 impliment CRUD(Create,Read,Update,Delete)