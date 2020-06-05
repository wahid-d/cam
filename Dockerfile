FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet tool install --global dotnet-ef
ENV ENV PATH="${PATH}:/root/.dotnet/tools"
RUN dotnet ef migrations add "newmigration"
RUN dotnet ef database update
ENTRYPOINT ["dotnet", "run", "--urls" , "http://0.0.0.0:5000"]


# # Build runtime image
# FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
# WORKDIR /app
# COPY --from=build-env /app/out .

