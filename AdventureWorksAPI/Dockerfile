#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["AdventureWorksAPI/AdventureWorksAPI.csproj", "AdventureWorksAPI/"]
COPY ["IoC/IoC.csproj", "IoC/"]
COPY ["Application/Application.csproj", "Application/"]
COPY ["Data/Data.csproj", "Data/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Core/Core.csproj", "Core/"]
RUN dotnet restore "Core/Core.csproj"
RUN dotnet restore "Domain/Domain.csproj"
RUN dotnet restore "Data/Data.csproj"
RUN dotnet restore "Application/Application.csproj"
RUN dotnet restore "IoC/IoC.csproj"
RUN dotnet restore "AdventureWorksAPI/AdventureWorksAPI.csproj"
COPY . .
WORKDIR "/src/AdventureWorksAPI"
RUN dotnet build "AdventureWorksAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AdventureWorksAPI.csproj" -c Release -o /app/publish --self-contained --runtime linux-x64

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdventureWorksAPI.dll"]