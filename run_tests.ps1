dotnet restore .\Crud_Clientes.sln
dotnet build .\Crud_Clientes.sln --configuration Release --no-restore
dotnet test .\Crud_Clientes.sln --configuration Release --no-build --collect:"XPlat Code Coverage"
