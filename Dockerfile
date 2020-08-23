FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine AS build-env
WORKDIR /app

COPY ./EmtechActions/EmtechActions.csproj ./EmtechActions/EmtechActions.csproj
COPY ./MauticActionWorker/MauticActionWorker.csproj ./MauticActionWorker/MauticActionWorker.csproj
COPY ./EmTech.ContentFileSystem/EmTech.ContentFileSystem.fsproj ./EmTech.ContentFileSystem/Emtech.ContentFileSystem.fsproj
COPY paket.dependencies ./paket.dependencies
COPY paket.lock ./paket.lock
COPY ./.config ./.config
# Copy csproj and restore as distinct layers
RUN dotnet tool install paket
RUN dotnet tool restore
RUN dotnet paket restore

COPY ./ ./

# Copy everything else and build
RUN dotnet publish -c Release -o out MauticActionWorker

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine

COPY --from=build-env /app/out .
RUN dotnet MauticActionWorker.dll
ENTRYPOINT ["dotnet", "MauticActionWorker.dll"]
