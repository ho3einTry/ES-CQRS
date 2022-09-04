FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Course/Course.API/Course.API.csproj", "Course.API/"]
RUN dotnet restore "src/Course/Course.API/Course.API.csproj"
COPY . .
WORKDIR "/src/Course.API"
RUN dotnet build "Course.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Course.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Course.API.dll"]
