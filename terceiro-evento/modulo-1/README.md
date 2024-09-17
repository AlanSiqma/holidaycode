# Holiday Code 🥳🎉💃🕺👯👯‍♂️👯‍♀️
## Módulo 1: Introdução ao AWS Lambda e Arquitetura Serverless

### O que é Arquitetura Serverless?

A **arquitetura serverless** permite que os desenvolvedores construam e executem aplicações e serviços sem gerenciar a infraestrutura subjacente. Embora servidores ainda sejam utilizados, toda a parte de provisionamento, escalabilidade, manutenção e gerenciamento de servidores é automatizada pela AWS. Isso possibilita que você foque totalmente no desenvolvimento de código.

- **Vantagens do serverless:**
  - Escalabilidade automática
  - Pagamento por uso real (você só paga pelo tempo de execução)
  - Redução da sobrecarga operacional e custos de infraestrutura
  - Implementação rápida

Serverless é ideal para aplicações baseadas em eventos, como processamento de dados em tempo real, backends para APIs e automação de tarefas.

### O que é AWS Lambda?

O **AWS Lambda** é o serviço serverless da Amazon Web Services (AWS). Ele executa código em resposta a eventos, sem a necessidade de provisionar ou gerenciar servidores. Você pode criar funções Lambda para uma ampla variedade de casos de uso, como:

- Processar arquivos carregados em um bucket S3
- Executar tarefas em resposta a mudanças em bancos de dados
- Atender requisições HTTP via API Gateway

As principais características do AWS Lambda incluem:

- **Execução sob demanda**: O Lambda só roda quando um evento o aciona.
- **Escalabilidade automática**: Ele escala automaticamente com base na carga.
- **Pagamento pelo uso**: Você paga apenas pelo tempo em que o código é executado.

### Como funciona o AWS Lambda?

O ciclo de vida de uma função Lambda é simples:

1. **Evento**: Um evento (como uma requisição HTTP, uma alteração no banco de dados, ou um arquivo carregado no S3) aciona a execução da função.
2. **Execução da função**: O código definido na função Lambda é executado automaticamente pela AWS.
3. **Resposta**: O Lambda retorna um resultado, seja ele um valor de sucesso, um erro ou uma resposta direta para o evento que acionou a função.

### Exemplo de uso do AWS Lambda

Vamos imaginar que você precise processar imagens enviadas para o Amazon S3. O fluxo seria:

1. Uma imagem é enviada para um bucket no S3.
2. Esse evento de upload aciona uma função Lambda.
3. A função Lambda processa a imagem (por exemplo, gerando miniaturas).
4. O resultado é armazenado ou utilizado conforme necessário.

### Quando usar o AWS Lambda?

- **Automação de tarefas**: Executar scripts ou rotinas automaticamente, em horários específicos ou quando eventos ocorrem.
- **Backend para APIs**: Lambda pode ser usado para criar backends de APIs RESTful em conjunto com o API Gateway.
- **Processamento de dados**: Em pipelines de processamento de dados, como ETL, você pode usar o Lambda para processar grandes volumes de dados em partes.
- **Internet das Coisas (IoT)**: Processar dados de dispositivos conectados.

### Conclusão

No Módulo 1, discutimos os conceitos básicos de **serverless** e **AWS Lambda**, explorando os benefícios e como essas tecnologias funcionam em um cenário prático. No próximo módulo, vamos colocar a mão na massa e começar a desenvolver nossa primeira função Lambda utilizando .NET Core!
