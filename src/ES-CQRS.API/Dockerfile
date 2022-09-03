FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/ES-CQRS.API/ES-CQRS.API.csproj", "ES-CQRS.API/"]
RUN dotnet restore "src/ES-CQRS.API/ES-CQRS.API.csproj"
COPY . .
WORKDIR "/src/ES-CQRS.API"
RUN dotnet build "ES-CQRS.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ES-CQRS.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ES-CQRS.API.dll"]
