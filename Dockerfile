FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine AS build-env
WORKDIR /app

COPY ./ ./
# Copy csproj and restore as distinct layers
RUN dotnet tool install paket
RUN dotnet tool restore
RUN dotnet paket restore

# Copy everything else and build
RUN dotnet publish -c Release -o out EmTech.MarketingContentAggregator

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine

COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "EmTech.MarketingContentAggregator.dll"]
