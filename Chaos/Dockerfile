# ============================================================
# Stage 1: Build
# ============================================================
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# ✅ Copia el .csproj primero para aprovechar el cache de capas
# Ajusta el nombre al de tu archivo .csproj real
COPY ["Chaos.Api.csproj", "./"]
RUN dotnet restore "./Chaos.Api.csproj"

# Copia el resto del código fuente
COPY . .

# Publica en modo Release
RUN dotnet publish "./Chaos.Api.csproj" \
    -c Release \
    -o /app/publish \
    --no-restore

# ============================================================
# Stage 2: Runtime (imagen final, mucho más liviana)
# ============================================================
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# ✅ Render asigna el puerto dinámicamente via variable de entorno PORT
# ASP.NET Core lo lee automáticamente con esta variable
ENV ASPNETCORE_URLS=http://+:${PORT:-10000}
ENV ASPNETCORE_ENVIRONMENT=Production

# Copia solo los artefactos publicados desde el stage anterior
COPY --from=build /app/publish .

# Expone el puerto (informativo para Render)
EXPOSE 10000

ENTRYPOINT ["dotnet", "Chaos.Api.dll"]# ============================================================
# Stage 1: Build
# ============================================================
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# ✅ Copia el .csproj primero para aprovechar el cache de capas
# Ajusta el nombre al de tu archivo .csproj real
COPY ["Chaos.Api.csproj", "./"]
RUN dotnet restore "./Chaos.Api.csproj"

# Copia el resto del código fuente
COPY . .

# Publica en modo Release
RUN dotnet publish "./Chaos.Api.csproj" \
    -c Release \
    -o /app/publish \
    --no-restore

# ============================================================
# Stage 2: Runtime (imagen final, mucho más liviana)
# ============================================================
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# ✅ Render asigna el puerto dinámicamente via variable de entorno PORT
# ASP.NET Core lo lee automáticamente con esta variable
ENV ASPNETCORE_URLS=http://+:${PORT:-10000}
ENV ASPNETCORE_ENVIRONMENT=Production

# Copia solo los artefactos publicados desde el stage anterior
COPY --from=build /app/publish .

# Expone el puerto (informativo para Render)
EXPOSE 10000

ENTRYPOINT ["dotnet", "Chaos.Api.dll"]