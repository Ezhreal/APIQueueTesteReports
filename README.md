## API de Relatórios com .NET Core e RabbitMQ (MassTransit)

Este repositório contém uma API de relatórios desenvolvida em .NET Core, utilizando o RabbitMQ como mensageria através da biblioteca MassTransit. O RabbitMQ será executado em um container Docker para facilitar a configuração e execução do ambiente.

### Funcionalidades

A API possui as seguintes funcionalidades:

- **Geração de relatórios:** Endpoint para gerar relatórios, recebendo os parâmetros necessários (ex: tipo de relatório, período, etc.).
- **Publicação de mensagens:** Após a solicitação de geração de relatório, a API publica uma mensagem no RabbitMQ, através do MassTransit, contendo os dados necessários para o processamento do relatório.
- **Consumo de mensagens:** A API possui um consumidor (consumer) interno, implementado com MassTransit, que fica à escuta das mensagens publicadas no RabbitMQ.
- **Processamento de relatórios:** Ao receber uma mensagem, o consumidor processa os dados e gera o relatório (ex: consulta ao banco de dados, cálculos, formatação, etc.).
- **Armazenamento de relatórios:** Os relatórios gerados podem ser armazenados em diferentes locais (ex: banco de dados, sistema de arquivos, serviço de nuvem, etc.).

### Tecnologias utilizadas

- **Linguagem de programação:** C# (.NET Core)
- **Framework/Biblioteca:** ASP.NET Core
- **Mensageria:** RabbitMQ (com MassTransit)
- **Containerização:** Docker
- **Banco de dados (opcional):** [Nome do banco de dados utilizado] (ex: PostgreSQL, MySQL, MongoDB, etc.)

### Pré-requisitos

- **.NET SDK:** Certifique-se de ter o .NET SDK instalado em sua máquina.
- **Docker:** Certifique-se de ter o Docker instalado em sua máquina.
