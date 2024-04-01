# Holiday Code 🥳🎉💃🕺👯👯‍♂️👯‍♀️
## Criar a Aplicação HolidayCodeApp

### O que é Blazor?

Blazor é um framework de código aberto da Microsoft para criar aplicativos web interativos usando C# e HTML. Ele oferece duas principais variantes:

1. **Blazor Server**: Executa a lógica do aplicativo no servidor, enviando atualizações de interface do usuário para o navegador.   
   
2. **Blazor WebAssembly**: Executa o código do aplicativo diretamente no navegador usando WebAssembly.

### Passo a passo para criar a aplicação HolidayCodeApp:

1. **Instalação do SDK do .NET Core**: Certifique-se de ter o SDK do .NET instalado, de uma olhada [neste](https://alansiqma.substack.com/p/primeiros-passos-visual-studio-code) passo a passo.

2. **Criar um novo projeto Blazor**: Use o comando `dotnet  new blazorwasm -o app --pwa` para criar um novo projeto Blazor Server.

3. **Navegar até o diretório do projeto**: Use `cd app`.

4. **Executar a aplicação**: Use `dotnet run` para iniciar a aplicação Blazor.

5. **Explorar a estrutura do projeto**: Arquivos como `Program.cs`, `Startup.cs`, e uma pasta `Pages` estarão presentes.

6. **Adicionar novas páginas**: Crie arquivos `.razor` na pasta `Pages`.

7. **Modificar a página inicial**: A página inicial é `Index.razor` por padrão.

8. **Personalizar o layout**: Edite o arquivo `_Layout.cshtml` na pasta `Pages`.

9. **Adicionar componentes**: Crie e adicione componentes na pasta `Shared`.

10. **Testar a aplicação**: Execute novamente a aplicação com `dotnet run` e teste no navegador.

Este guia básico ajudará você a começar a desenvolver a aplicação HolidayCodeApp. Para mais informações, consulte a documentação oficial em [Blazor - Documentação](https://docs.microsoft.com/pt-br/aspnet/core/blazor/?view=aspnetcore-6.0).

## Versionamento e Submissão no GitHub
### Vamos subir para o repositorio?

1. **Inicializar um repositório Git:**

   ```bash
   cd Caminho/Para/App
   git init
   ```

2. **Adicionar arquivos ao controle de versão:**
   ```bash
   git add .
   ```

3. **Commit das alterações:**
   ```bash
   git commit -m "Primeiro commit: Adiciona estrutura inicial da aplicação"
   ```

4. **Criar um repositório no GitHub:**

   Acesse o GitHub e crie um novo repositório chamado "HolidayCodeApp".
   Essa parte foi explicada neste (artigo)[https://alansiqma.substack.com/p/primeiros-passos-github]

5. **Conectar o repositório local ao repositório remoto:**
   ```bash
   git remote add origin URL-do-Repositório
   ```

6. **Enviar as alterações para o GitHub:**
   ```bash
   git push -u origin master
   ```

7. **Verificar no GitHub:**

   Acesse o repositório no GitHub e verifique se os arquivos foram enviados corretamente.
   Com estes passos, você aprendeu como versionar e enviar o código-fonte da sua aplicação HolidayCodeApp para o repositório no GitHub.