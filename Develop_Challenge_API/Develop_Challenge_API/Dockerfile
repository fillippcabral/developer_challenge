
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Develop_Challenge_API/Develop_Challenge_API.csproj", "Develop_Challenge_API/"]
RUN dotnet restore "Develop_Challenge_API/Develop_Challenge_API.csproj"
COPY . .
WORKDIR "/src/Develop_Challenge_API"
RUN dotnet build "Develop_Challenge_API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Develop_Challenge_API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Develop_Challenge_API.dll"]