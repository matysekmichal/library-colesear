# LibraryColesear

## Run development
To run application for development you have to go to **Library** solution and run dotnet command `cd Library & dotnet run watch`.

## Run tests
To run tests you have to go to **LibraryTest** solution and run dotnet command `cd LibraryTest & dotnet test`.

## Build production
For build production enviorement run command:
```bash
cd LibraryTest && dotnet test && cd ../Library && dotnet restore && dotnet build --no-restore
```
