# .NET Core boilerplate

## Create a new project

### Create the project and add it to the SLN

```sh
mkdir -p src/NewProject
cd src/NewProject
dotnet new web
cd ../../
dotnet sln add src/NewProject/NewProject.csproj
```

### Dockerize

Copy the content of the `template` folder into your new project.

```sh
cp template/* src/NewProject/*
```

Add the following reference to your `.csproj` to enable the file watcher:

```xml
<ItemGroup>
  <DotNetCliToolReference Include="Microsoft.DotNet.Watcher.Tools" Version="2.1.0-preview1-27567" />
</ItemGroup>
``` 

Add the following service in `docker-compose.yml` and customize ports, 
environment and volumes in `docker-compose.override.yml`.

```yml
# docker-compose.yml
  NewProject:
    container_name: "newproject"
    build:
      context: ./src/NewProject
      dockerfile: Dockerfile
    entrypoint: "dotnet NewProject.dll"
    image: bunch/newproject

# docker-compose.override.yml
  NewProject:
    build:
      dockerfile: Dockerfile.dev
    ports: 
      - 8080:80
    environment: 
      - ASPNETCORE_ENVIRONMENT=Development
    volumes:
      - ./src/NewProject:/code/app

```

## Build and run

Build and run the docker images:

```sh
docker-compose build
docker-compose up
```

That's it!
