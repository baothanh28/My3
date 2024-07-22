FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /My.Monolith

# Copy csproj and restore as distinct layers
COPY ./My.Application/*.csproj ./My.Application/
COPY ./My.ArchTests/*.csproj ./My.ArchTests/
COPY ./My.BackgroundServer/*.csproj ./My.BackgroundServer/
COPY ./My.Blazor.Modules/*.csproj ./My.Blazor.Modules/
COPY ./My.BlazorServerSide/*.csproj ./My.BlazorServerSide/
COPY ./My.BlazorWebAssembly/*.csproj ./My.BlazorWebAssembly/
COPY ./My.ContractTests/*.csproj ./My.ContractTests/
COPY ./My.CrossCuttingConcerns/*.csproj ./My.CrossCuttingConcerns/
COPY ./My.Domain/*.csproj ./My.Domain/
COPY ./My.EndToEndTests/*.csproj ./My.EndToEndTests/
COPY ./My.GraphQL/*.csproj ./My.GraphQL/
COPY ./My.IdentityServer/*.csproj ./My.IdentityServer/
COPY ./My.Infrastructure/*.csproj ./My.Infrastructure/
COPY ./My.IntegrationTests/*.csproj ./My.IntegrationTests/
COPY ./My.Migrator/*.csproj ./My.Migrator/
COPY ./My.Persistence/*.csproj ./My.Persistence/
COPY ./My.UnitTests/*.csproj ./My.UnitTests/
COPY ./My.WebAPI/*.csproj ./My.WebAPI/
COPY ./My.WebMVC/*.csproj ./My.WebMVC/
COPY ./My.Monolith.sln .
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish ./My.Migrator/My.Migrator.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /My.Monolith
COPY --from=build-env /My.Monolith/out .

ENTRYPOINT ["dotnet", "My.Migrator.dll"]