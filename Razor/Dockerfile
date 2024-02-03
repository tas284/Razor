FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT="Production"

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Razor.csproj", "."]
RUN dotnet restore "Razor.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Razor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Razor.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Razor.dll"]