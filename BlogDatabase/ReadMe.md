# Simple application to test MS EntityFramework

```bash
dotnet add package EntityFramework --version 6.4.4
dotnet list package
```

To install a tool for local access only (for the current directory and subdirectories), it has to be added to a tool manifest file. To create a tool manifest file, run the dotnet new tool-manifest command:

```bash
dotnet new tool-manifest
dotnet tool install --local dotnet-ef --version 6.0.3 

dotnet tool list
```

Migration database

First Migration:

```bash
dotnet ef migrations add InitialCreate
```

Create Schema:

```bash

dotnet ef database update

```
