# Aplicação ASP .NET Core MVC

## Criar projeto

- **mkdir** projetos
- **cd** projetos
- **mkdir** mvc1
- **cd** mvc1

`dotnet new mvc`
`ls -g`
`code .`


## Criar imagem

1 - Publicar a aplicação
`dotnet publish`
`dotnet publish --configuration Release --output dist`

**--configuration Release**
Indica que estamos usando o modo Release que é o modo usado em produção.

**--output dist**
Especifica que o projeto compilado será copiado para a pasta dist.


2 - Criar o arquivo Dcokerfile
Definir as instruções para criação da imagem.

Dockerfile
```
FROM mcr.microsoft.com/dotnet/aspnet:6.0
LABEL version="1.0.2" description="Aplicação ASP .NET Core MVC"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "appnetcore6mvc.dll"]
```

3 - Criar a imagem
`docker build -t imagem:tag`

`docker build -t aspnetcore6mvc:1.0.2`

4 - Criar o container
`docker container create`

`docker container create -p 3000:80 --name mvcprodutos aspnetcore6mvc/app:1.0.2`

`docker container start mvcprodutos`
