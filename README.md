# DbPersistedCors
A proof-of-concept to have Whitelisted Uris persisted in a database.

## Requirements / Suggestions
* .NET 5 SDK & Runtime
* Visual Studio 2019 Community
* SQL Server

## Setup
1. Clone the repository
2. `cd` into `CorsDbPersistedSandbox/CorsDbPersistedSandbox`
3. Ensure you have the `dotnet-ef` tool installed in the .NET CLI. (Run `dotnet tool install --global dotnet-ef` if you don't)
4. Run `dotnet ef migrations add InitialCreate`
5. Run `dotnet ef database update`
6. Run the application and make requests via Postman
