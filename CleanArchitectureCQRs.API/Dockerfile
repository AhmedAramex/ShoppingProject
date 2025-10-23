# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy everything and restore dependencies
COPY ["CleanArchitectureCQRs.API/CleanArchitectureCQRs.API.csproj", "CleanArchitectureCQRs.API/"]
RUN dotnet restore "CleanArchitectureCQRs.API/CleanArchitectureCQRs.API.csproj"

# Copy the rest of the source code
COPY . .

# Build and publish the app
WORKDIR "/src/CleanArchitectureCQRs.API"
RUN dotnet publish "CleanArchitectureCQRs.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Final stage: use a smaller runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "CleanArchitectureCQRs.API.dll"]
