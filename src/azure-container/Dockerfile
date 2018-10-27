FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 55190
EXPOSE 44319

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["azure-container.csproj", "azure-container/"]
RUN dotnet restore "azure-container/azure-container.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "azure-container.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "azure-container.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "azure-container.dll"]