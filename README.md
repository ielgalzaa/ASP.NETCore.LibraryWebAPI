
# Visual Studio .Net Core 7.0 RESTful Web API with Entity Framework Core including SQL project.

"Library example" management Web API example built in .Net Core 7.0 and Entity Framework Core including SQL project.

Add the following NuGet packages to the solution:

	Microsoft.EntityFrameworkCore.SQLServer
	Microsoft.VisualStudio.Web.CodeGeneration.Design
	Microsoft.EntityFrameworkCore.Tools
	Microsoft.EntityFrameworkCore
	System.IdentityModel.Tokens.Jwt
	Microsoft.AspNetCore.Authentication.JwtBearer

Create model:

  Tools → NuGet Package Manager → Package Manager Consoler
  Scaffold-DbContext “Server=***********;Database=LibraryManagementAPI;Trusted_Connection=True; Encrypt=False" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
