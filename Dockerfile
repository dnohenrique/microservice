FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build

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

## MODO RELEASE
#RUN dotnet publish EmpresaService.sln -c Release
#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
#COPY --from=build [ "/workdir/Api/bin/Release/netcoreapp3.1/publish/", "./" ]

## MODO DEBUG
RUN dotnet publish EmpresaService.sln -c Debug 
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
COPY --from=build [ "/workdir/Api/bin/Debug/netcoreapp3.1/publish/", "./" ]

RUN curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -v latest -l /publish/vsdbg;

ENV ASPNETCORE_URLS http://*:80
EXPOSE 80

CMD [ "dotnet", "Api.dll" ]
