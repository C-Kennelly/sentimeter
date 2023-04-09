FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["sentimeter.csproj", "./"]
RUN dotnet restore "sentimeter.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "sentimeter.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "sentimeter.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "sentimeter.dll"]
