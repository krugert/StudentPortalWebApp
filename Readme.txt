1. Open the solution file in Visual Studio 2022.
2. Change the DefaultConnection string in the appsettings.json file in the Server project.
3. Go to Tools -> NuGet Package Manager -> Package Manager Console
4. Run the following commainds:
      Add-Migration -o Data/Migrations
	  Update-Datatbase
	
5. Run the Client and server in Visual Studio 2022.
