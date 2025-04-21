# .NET Core SDK
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
# Sets the working directory
WORKDIR /app
# Expose ports
EXPOSE 8080

ENV ASPNETCORE_URLS=http://+:8080

# Copy Projects
WORKDIR /src
COPY PearDBApi.Main/PearDBApi.Main.csproj ./PearDBApi.Main/
COPY PearDBApi.Infrastructure/PearDBApi.Infrastructure.csproj ./PearDBApi.Infrastructure/
COPY PearDBApi.BackgroundServices/PearDBApi.BackgroundServices.csproj ./PearDBApi.BackgroundServices/
COPY PearDBApi.Contracts/PearDBApi.Contracts.csproj ./PearDBApi.Contracts/
COPY PearDBApi.Application/PearDBApi.Application.csproj ./PearDBApi.Application/
COPY PearDBApi.Domain/PearDBApi.Domain.csproj ./PearDBApi.Domain/
RUN dotnet restore ./PearDBApi.Main/PearDBApi.Main.csproj
COPY . .

RUN dotnet publish ./PearDBApi.Main/PearDBApi.Main.csproj -c Release -o /publish

# ASP.NET Core Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /publish ./

ENTRYPOINT ["dotnet", "PearDBApi.Main.dll"]