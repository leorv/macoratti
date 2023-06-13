# Define a imagem base
FROM mcr.microsoft.com/dotnet/sdk:6.0
LABEL version="1.0.1" description="Aplicação .NET Console"
# Define o diretório de trabalho do container
WORKDIR /app

# Copia o arquivo csproj e restaura as camadas
COPY *.csproj ./

# Restaura as dependências do projeto.
RUN dotnet restore

# Copia tudo da pasta atual para o container
COPY . ./

# Executa o comando que publica o projeto na pasta out
RUN dotnet publish -c Release -o out

# Executa o comando dotnet no arquivo do projeto na pasta out
ENTRYPOINT [ "dotnet", "out/appnetcore6.dll" ]
