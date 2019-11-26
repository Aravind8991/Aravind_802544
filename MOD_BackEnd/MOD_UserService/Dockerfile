#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-nanoserver-1903 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-nanoserver-1903 AS build
WORKDIR /src
COPY ["MOD_UserService/MOD_UserService.csproj", "MOD_UserService/"]
RUN dotnet restore "MOD_UserService/MOD_UserService.csproj"
COPY . .
WORKDIR "/src/MOD_UserService"
RUN dotnet build "MOD_UserService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MOD_UserService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MOD_UserService.dll"]