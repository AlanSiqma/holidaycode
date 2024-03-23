# Holiday Code 🥳🎉💃🕺👯👯‍♂️👯‍♀️
## Introdução ao Git

O Git é um repositorio para seu codigo, projetado para lidar com tudo, desde projetos pequenos a muito grandes, com velocidade e eficiência.

Para poder instalar o Git siga o passo a passo abaixo:
[Veja o artigo aqui](https://alansiqma.substack.com/p/primeiros-passos-git)

Ele fornece um arcabouço de comandos que podemos utilizar para manter os arquivos

## Alguns comandos 

###  git init

Para que o git monitore as alterações do diretorio que queremos nos temos que, acessar a pasta que queremos monitorar, depois axecutar o comando no cmd

```
git init
```
se você estiver com a visualização dos aruivos ocultos da pasta podera ver que esse comando fez com que fosse criado uma pasta chamada .git

vamos criar um arquivo .txt o que aparece

### git status

O comando git status mostra o status atual do monitoramento da nossa pasta, ao executar o comando: ```

```
git status
```
é nos mostrado algo semelhante a isso: 

![image](https://github.com/AlanSiqma/holidaycode/assets/15115007/87fa8c0d-71d7-4ad3-bcd9-f2c8aea8e028)

ou seja, o nosso arquivo precisa ser adicionado para ser rastreado pelo nosso amigo git

### git add

Para rastrear as alterações do nosso arquivo então precisamos adiciona-lo no rastreamento, no meu caso executar o comando 

```
git add nomedoarquivo.txt
```

ao executarmos o comando ```git status``` teremos a saida: 

![image](https://github.com/AlanSiqma/holidaycode/assets/15115007/f68db6f9-2c58-4ed3-9df4-ab3b9f9ed147)


### git commit

Quando realizamos o comando acima o nosso arquivo foi para uma area chamada de staginfg, ela não está propriamente dita no nosso repositorio, para que mandemos as alterações para o repositorio precisamos executar o comando 

```
git commit -m 'nome da mensagem referente ao que você esta mandando para o repositorio'
```

ao realizar essa ação o seu resultado sera semelhante a esse:

![image](https://github.com/AlanSiqma/holidaycode/assets/15115007/7dbc5fbb-5f84-4eca-84f1-1b68f984c7bd)


## Introdução ao GitHub

GitHub é a rede social do seu codigo, quando instalamos o Git conseguimos gerenciar as versões do que estamos fazendo apenas no nosso computador, para que consegamos colaborar com outras pessoas, seja na empresa ou um codigo aberto, necessitamos de um servidor para centralizar as alterações que vão decorrendo do projeto, o GitHub fornece esse e outros serviços para o nosso código. 

Abaixo um artigo para você criar a sua conta e criar o primeiro repositorio de exemplo:

[Veja o artigo aqui](https://alansiqma.substack.com/p/primeiros-passos-github)

### Equalizando

Ao realizar a criação do repositorio você conseguira equalizar o seu repositorio local com o repositorio remoto que criou no GitHub
Há dois comandos basicos para conversar com o repositorio remoto 

```
git pull
```
e

```
git push
```

Estes comandos permitem atualizar seu repositório local com as alterações do remoto (git pull) e enviar suas alterações locais para o repositório remoto (git push).

Com essas ferramentas básicas, você está pronto para começar a colaborar em projetos usando o Git e o GitHub!


![github](https://github.com/AlanSiqma/holidaycode/assets/15115007/177203a3-6ea2-4101-942d-2180af41c4cc)
