# ============================================================
# Stage 1: Build
# ============================================================
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["Chaos.Api.csproj", "./"]
RUN dotnet restore "./Chaos.Api.csproj"

COPY . .

RUN dotnet publish "./Chaos.Api.csproj" \
    -c Release \
    -o /app/publish \
    --no-restore

# ============================================================
# Stage 2: Runtime
# ============================================================
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

ENV ASPNETCORE_URLS=http://+:${PORT:-10000}
ENV ASPNETCORE_ENVIRONMENT=Production

COPY --from=build /app/publish .

EXPOSE 10000

ENTRYPOINT ["dotnet", "Chaos.Api.dll"]
