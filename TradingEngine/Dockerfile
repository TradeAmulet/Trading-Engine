FROM microsoft/dotnet:3.0-aspnetcore-runtime-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:3.0-sdk-stretch AS build
WORKDIR /src
COPY ["TradingEngine/TradingEngine.csproj", "TradingEngine/"]
RUN dotnet restore "TradingEngine/TradingEngine.csproj"
COPY . .
WORKDIR "/src/TradingEngine"
RUN dotnet build "TradingEngine.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TradingEngine.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TradingEngine.dll"]