#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Vendedores/Vendedores.API/Vendedores.API.csproj", "Vendedores/Vendedores.API/"]
COPY ["Vendedores/Vendedores.Application/Vendedores.Application.csproj", "Vendedores/Vendedores.Application/"]
COPY ["Vendedores/Vendedores.Data/Vendedores.Data.csproj", "Vendedores/Vendedores.Data/"]
COPY ["Vendedores/Vendedores.Domain/Vendedores.Domain.csproj", "Vendedores/Vendedores.Domain/"]
RUN dotnet restore "Vendedores/Vendedores.API/Vendedores.API.csproj"
COPY . .
WORKDIR "/src/Vendedores/Vendedores.API"
RUN dotnet build "Vendedores.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Vendedores.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Vendedores.API.dll"]