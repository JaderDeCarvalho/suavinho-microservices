FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /app

COPY *.sln .
COPY Suavinho.Cellar.API/*.csproj .
COPY Suavinho.Cellar.Applicarion/*.csproj .
COPY Suavinho.Cellar.Commons/*.csproj .
COPY Suvainho.Cellar.Domain/*.csproj .
COPY Suavinho.Cellar.Infrastructure/*.csproj .

RUN dotnet restore "Suavinho.Cellar.API.csproj" --use-current-runtime

COPY . .

WORKDIR /app/Suavinho.Cellar.API

RUN dotnet build

FROM build AS publish
WORKDIR /app/Suavinho.Cellar.API
RUN dotnet publish "Suavinho.Cellar.API.csproj" -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final

WORKDIR /app

COPY --from=publish /app/Suavinho.Cellar.API/out ./

ENTRYPOINT ["dotnet", "Suavinho.Cellar.API.dll"]

