FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/presentation/Net.JourneyHero.WebApi/Net.JourneyHero.WebApi.csproj", "src/presentation/Net.JourneyHero.WebApi/"]
RUN dotnet restore "src/presentation/Net.JourneyHero.WebApi/Net.JourneyHero.WebApi.csproj"
COPY . .
WORKDIR "/src/src/presentation/Net.JourneyHero.WebApi"
RUN dotnet build "Net.JourneyHero.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Net.JourneyHero.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Net.JourneyHero.WebApi.dll"]
