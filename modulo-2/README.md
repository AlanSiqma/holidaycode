# Holiday Code 🥳🎉💃🕺👯👯‍♂️👯‍♀️
## Vamos começar então 
### O que é Entity Framework Core?
Ei, já ouviu falar do Entity Framework (EF) Core? É tipo uma versão mais leve, estilosa e moderninha do famoso EF, que é uma tecnologia de acesso a dados.

O EF Core é tipo um faz-tudo, sabe? Ele serve como um mapeador objeto-relacional (O/RM), o que significa que os devs de .NET podem brincar com um banco de dados usando objetos do próprio .NET. Isso acaba com aquele monte de código chato que a gente sempre tem que escrever só pra mexer nos dados.

E o melhor é que o EF Core é amigo de muitos motores de banco de dados por aí.


### Vamos iniciar?


- SDK do .net 7.0 instalado 🫡
- [Instale aqui](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
  
## Primeiro passo 
Via cmd vá para a pasta holidaycode e digite 
```
code .
```
Abra o terminal do vs code: Para abrir o terminal no Visual Studio Code, digite Ctrl + ' ou vá em View>Terminal.
Digite o seguinte comando:
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```
E depois 
```
dotnet tool install --global dotnet-ef
```

## Segundo passo
No terminal digite o comando 
```
dotnet new mvc -n MinhaPrimeiraApllicacaoWeb
```


## Terceiro passo
Agora que a aplicação foi criada, podemos acessar a pasta digitando
```
cd MinhaPrimeiraApllicacaoWeb
```
...