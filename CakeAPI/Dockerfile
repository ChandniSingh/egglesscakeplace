FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /app
EXPOSE 80

#COPY ./CakeAPI ./
COPY . .
RUN dotnet restore CakeAPI.csproj

FROM build AS publish
RUN dotnet publish "CakeAPI.csproj" -c Release -o /app

WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "CakeAPI.dll"]
