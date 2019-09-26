FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Smealio.Grpc.HelloWorld.App1/Smealio.Grpc.HelloWorld.App1.csproj", "Smealio.Grpc.HelloWorld.App1/"]
RUN dotnet restore "Smealio.Grpc.HelloWorld.App1/Smealio.Grpc.HelloWorld.App1.csproj"
COPY . .
WORKDIR "/src/Smealio.Grpc.HelloWorld.App1"
RUN dotnet build "Smealio.Grpc.HelloWorld.App1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Smealio.Grpc.HelloWorld.App1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Smealio.Grpc.HelloWorld.App1.dll"]