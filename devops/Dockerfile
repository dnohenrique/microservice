FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build

WORKDIR /workdir

COPY [ "EmpresaService.sln", "./" ]
COPY [ "docker-compose.dcproj", "./" ]
COPY [ "Api/Api.csproj", "Api/" ]
COPY [ "Application/Application.csproj", "Application/" ]
COPY [ "Domain/Domain.csproj", "Domain/" ]
COPY [ "Infrastructure/Infrastructure.csproj", "Infrastructure/" ]
COPY [ "Domain.Test/Domain.Test.csproj", "Domain.Test/" ]

RUN dotnet restore EmpresaService.sln
COPY . ./
RUN dotnet publish EmpresaService.sln -c Release -o published

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2

WORKDIR /service/api
COPY --from=build [ "/workdir/Api/published/", "./" ]

ENV ASPNETCORE_URLS http://*:80
EXPOSE 80

CMD [ "dotnet", "Api.dll" ]
