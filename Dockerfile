# �tape 1 : Image pour la compilation
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copier le fichier .csproj et restaurer les d�pendances
COPY ["dofus-unity-rendering-back.csproj", "./"]
RUN dotnet restore "dofus-unity-rendering-back.csproj"

# Copier le reste des fichiers source et compiler
COPY . .
RUN dotnet build "dofus-unity-rendering-back.csproj" -c Release -o /app/build

# �tape 2 : Publier l'application
FROM build AS publish
RUN dotnet publish "dofus-unity-rendering-back.csproj" -c Release -o /app/publish

# �tape 3 : Image finale pour l'ex�cution
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
EXPOSE 80

# Copier les fichiers publi�s dans l'image finale
COPY --from=publish /app/publish .

# D�finir le point d'entr�e de l'application
ENTRYPOINT ["dotnet", "dofus-unity-rendering-back.dll"]
