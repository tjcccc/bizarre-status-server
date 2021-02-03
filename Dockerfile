FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["bizarre-status-server.csproj", ""]
RUN dotnet restore "./bizarre-status-server.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "bizarre-status-server.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "bizarre-status-server.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "bizarre-status-server.dll"]
