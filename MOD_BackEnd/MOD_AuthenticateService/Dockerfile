#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-nanoserver-1903 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-nanoserver-1903 AS build
WORKDIR /src
COPY ["MOD_AuthenticateService/MOD_AuthenticateService.csproj", "MOD_AuthenticateService/"]
RUN dotnet restore "MOD_AuthenticateService/MOD_AuthenticateService.csproj"
COPY . .
WORKDIR "/src/MOD_AuthenticateService"
RUN dotnet build "MOD_AuthenticateService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MOD_AuthenticateService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MOD_AuthenticateService.dll"]