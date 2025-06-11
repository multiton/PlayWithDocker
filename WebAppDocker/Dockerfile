# See https://aka.ms/customizecontainer to learn how to customize your debug container
# and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["WebAppDocker/WebAppDocker.csproj", "WebAppDocker/"]
RUN dotnet restore "WebAppDocker/WebAppDocker.csproj"
COPY . .
WORKDIR "/src/WebAppDocker"
RUN dotnet build "WebAppDocker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebAppDocker.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebAppDocker.dll"]