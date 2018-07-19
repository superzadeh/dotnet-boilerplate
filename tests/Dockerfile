FROM microsoft/dotnet:2.1-sdk AS build-env

COPY ./src /src
COPY ./tests  /tests

WORKDIR /tests/UnitTests
RUN dotnet restore
ENTRYPOINT ["dotnet", "watch", "test"]
