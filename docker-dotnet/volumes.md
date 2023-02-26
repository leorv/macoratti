# Trabalhando com volumes

Sabemos que os containers são criados a partir de imagens, e que são apenas uma fina camada de leitura e escrita em cima das imagens que são somente leitura.

Quando guardamos informações em um container, e depois removemos o container com o comando `docker container rm`, a sua fina camada será removido juntamente com essas informações.

Então onde guardar as informações? O Docker fornece um recurso chamado volumes.

Os volumes separam os arquivos de dados que são gerados por um aplicativo ou banco de dados do restante do armazenamento do container.

Eles permitem que dados inmportantes existam fora do container, o que significa que você pode substituir um container sem perder os dados que ele criou.

Eles tornam possível excluir um container sem também excluir os dados que contém, o que permite que os containeres sejam alterados ou atualizados sem perder os dados e informações armazenadas.

## Principais usos

- Para manter os dados quando um container for removido.
- Para compartilhar dados entre o sistema de arquivo do host e o container do docker.
- Para compartilhar dados com outros containeres do Dcoker.

## Criar um volume

```
docker container run -v <pasto do host>:<pasta container> imagem
```

Exemplo: `-v $(pwd)/teste:/usr/share`

Exemplo com uma imagem do Alpine: `docker container run -it --name alp1 -v $(pwd)/teste:/usr/share alpine`

