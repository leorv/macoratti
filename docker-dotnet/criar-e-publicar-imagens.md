# Como criar imagens

## Publicar imagens

1 - Criar uma conta no Dockerhub.
2 - Preparar a imagem (tagear a imagem) para ser enviada.
`docker image tag leorv/nome:versão`
3 - Se logar na sua conta no repositório.
`docker login -u <usuário> -p <senha>`
4 - Enviar a imagem para o repositório.
`docker image push imagem_repositorio`

Há duas maneiras de criarmos imagens, com o Dockerfile ou commit. O Commit não é recomendável.

O **Dockerfile** é um arquivo com texto com instruções, comandos e passos que é executado através do comando *build* para gerar uma imagem.

```
docker build -t <imagem>
```

Exemplo: Criar uma imagem do **debian 8** que instale e inicie o servidor **nginx**.

Definindo as etapas que vamos usar para criar a imagem:

- Definir uma imagem base.
- Definir informações para a imagem.
- Executar comandos para instalar e iniciar o nginx.
- Expor qual porta o servidor vai atender (no container).
- Definir o ponto de entrada da aplicação.
- Definir a execução de um comando para inicializar o servidor nginx.


### Passo a passo

Criar o arquivo Dockerfile.

Ele atua com o build dentro do diretório e seus sub diretórios, não é boa ideia colocá-lo na raiz.

```
FROM debian:8
LABEL version="1.0" description="Debian/Nginx"
RUN apt-get update && apt-get install -y nginx --force-yes && apt-get clean
EXPOSE 80
ENTRYPOINT ["/usr/sbin/nginx"]
CMD ["-g", "daemon off;"]
```

Acima, o comando FROM pega a imagem debian versão 8.
O LABEL define as informações da imagem.
o RUN determina os comando a serem executados, no caso, instalar o nginx no Debian.
EXPOSE expõe a porta 80, a porta do nginx.
O ENTRYPOINT define a pasta de entrada, onde a aplicação vai ser executada.
O CMD é o comando que será executado no servidor.

O comando que vai ser executado no CMD vai ser esse: `/usr/sbin/nginx -g daemon off`

Agora resta criar a imagem com o docker build.

```
docker build -t leorv/debian8-nginx:1.0 .
```

O ponto final significa o diretório atual, no caso, onde tem o Dockerfile.

Testando:

```
docker container run -d -p 8080:80 --name=ws1 leorv/debian8-nginx:1.0
```

Daí pode dar um `docker login` e um `docker push` para subir a imagem pra conta.

### Inspecionar a imagem

```
docker image inspect leorv/debian8-nginx:1.0

docker image history leorv/debian8-nginx:1.0
```

### Criar um alias através da tag da imagem

```
docker image tag redis:latest redis:leo
```

### Criar uma imagem através de um Dockerfile

```
docker image build <Dockerfile>
```

### 
