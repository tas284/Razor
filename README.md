# Razor

This project serves to validate the XML of an [NFe](https://www.nfe.fazenda.gov.br/portal/principal.aspx).

## Requirements
SDK net6.0

## ## Development server - Build and Run

To run this project enter the root directory and run `dotnet build` && `dotnet run`

## Backend
Depends on this project for run Backend: https://github.com/tas284/NFeXMLValidator

## Build image docker

Run `docker build -t razor .`

## Run with docker compose

Run `docker compose up -d`

## Run Backend and Frontend in mode production with docker

Run `docker compose -f .\docker-compose.prod.yml up`

If you set the environment variable ASPNETCORE_ENVIRONMENT to Develpment, [Swagger UI](https://swagger.io/tools/swagger-ui/) will be enabled, this will help you read the API documentation.

You can also set the environment variable ASPNETCORE_ENVIRONMENT for Production to disable [Swagger UI](https://swagger.io/tools/swagger-ui/).

Try in browser: http://localhost:5001/swagger/index.html
