# Docker essencial para a plataforma .NET

Verificar o docker:

```
docker --version
```

Para usar o docker sem o sudo:

```
sudo groupadd docker

sudo gpasswd -a <usuario> docker

sudo service docker restart

newgrp Docker
```

# Containers

## Criar um container

```
docker container run <imagem>
```

Explicando o comando acima:

- docker
é o executor do comando.

- container
indica que o comando vai atuar em um container.

- run
é a porta de entrada no Docker e realiza 4 operações.
    - Baixa a imagem não encontrada localmente: `docker image pull`
    - Cria o container: `docker container create`
    - Inicializa o container: `docker container start`
    - Uso do modo interativo executa um comando: `docker container exec`


## Visualizar os containers

```
docker container ps

docker container ps -a
```

Visualizar as imagens

```
docker images
```

