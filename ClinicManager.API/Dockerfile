FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
RUN apt-get update && apt-get install -y libgdiplus
ARG source
WORKDIR /app
EXPOSE 80
COPY ${source:-obj/Docker/publish} .
ENTRYPOINT ["dotnet", "ClinicManager.API.dll"]