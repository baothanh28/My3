FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /My.IdentityServer

# Copy csproj and restore as distinct layers
COPY ./My.Application/*.csproj ./My.Application/
COPY ./My.CrossCuttingConcerns/*.csproj ./My.CrossCuttingConcerns/
COPY ./My.Domain/*.csproj ./My.Domain/
COPY ./My.IdentityServer/*.csproj ./My.IdentityServer/
COPY ./My.Infrastructure/*.csproj ./My.Infrastructure/
COPY ./My.Migrator/*.csproj ./My.Migrator/
COPY ./My.Persistence/*.csproj ./My.Persistence/
COPY ./My.IdentityServer4.sln .
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish ./My.IdentityServer/My.IdentityServer.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /My.IdentityServer
COPY --from=build-env /My.IdentityServer/out .

ENTRYPOINT ["dotnet", "My.IdentityServer.dll"]