
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

WORKDIR /app

# Copy csproj and restore as distinct layers
COPY Module6HW2.api.sln ./
COPY Module6HW2.api/*.csproj ./Module6HW2.api/
COPY Module6HW2.core/*.csproj ./Module6HW2.core/
COPY Module6HW2.infrastructure/*.csproj ./Module6HW2.infrastructure/
COPY Module6HW2.db/*.csproj ./Module6HW2.db/

RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish Module6HW2.api.sln -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0

ENV ASPNETCORE_URLS=http://*:80
ENV ASPNETCORE_ENVIRONMENT=Development

USER 1000

WORKDIR /app
COPY --from=build-env /app/out .

EXPOSE 7029
ENTRYPOINT ["dotnet", "Module6HW2.api.dll"]