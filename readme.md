# .NET Core boilerplate

## Build and run

Build and run the docker images:

```sh
docker-compose build
docker-compose up api # starts the API with auto reload on changes
docker-compose up unittests # starts the unit tests with auto reload on changes
```

## Usage

```sh
curl http://localhost:8080/api/helloworld
```
