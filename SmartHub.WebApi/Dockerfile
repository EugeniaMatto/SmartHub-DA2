# Usar la imagen oficial de .NET SDK para la compilación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar todos los proyectos necesarios
COPY . ./

# Restaurar las dependencias del proyecto
RUN dotnet restore

# Publicar la aplicación
RUN dotnet publish -c Release -o /out

# Usar la imagen de .NET Runtime para el contenedor final
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /out ./
ENTRYPOINT ["dotnet", "SmartHub.WebApi.dll"]
