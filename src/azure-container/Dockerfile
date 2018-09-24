FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 55190
EXPOSE 44319

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["CraftathonContainerTest/CraftathonContainerTest.csproj", "CraftathonContainerTest/"]
RUN dotnet restore "CraftathonContainerTest/CraftathonContainerTest.csproj"
COPY . .
WORKDIR "/src/CraftathonContainerTest"
RUN dotnet build "CraftathonContainerTest.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CraftathonContainerTest.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CraftathonContainerTest.dll"]