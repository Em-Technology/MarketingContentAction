FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app/worker
COPY EmtechActions/ /app/EmtechActions
COPY .config/ ./
COPY paket.* ./

# Copy csproj and restore as distinct layers
COPY MauticActionWorker ./
RUN dotnet tool install paket
RUN dotnet tool restore
RUN dotnet paket restore

# Copy everything else and build
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/worker/out .
ENTRYPOINT ["dotnet", "MauticActionWorker.dll"]
