# API de Controle de Produtos

## Descrição
Este é um exemplo simples de uma API para controle de produtos em ASP.NET Core. O código fornece operações básicas CRUD (Create, Read, Update, Delete) para uma lista estática de produtos.

## Funcionalidades
- **GET `/api/products`**: Retorna todos os produtos.
- **GET `/api/products/{id}`**: Retorna um produto específico com base no ID.
- **POST `/api/products`**: Adiciona um novo produto.
- **PUT `/api/products/{id}`**: Atualiza um produto existente com base no ID.
- **DELETE `/api/products/{id}`**: Remove um produto com base no ID.

## Uso
Certifique-se de ter o ambiente ASP.NET Core configurado para executar esta API. Você pode testar as operações CRUD usando ferramentas como o Postman ou o Swagger.

## Instruções de Configuração
1. Clone este repositório.
2. Abra o projeto em sua IDE preferida.
3. Execute a aplicação.
4. Utilize as rotas fornecidas para interagir com os produtos.

## Notas Adicionais
- Esta implementação usa uma lista estática de produtos para simular um banco de dados.
- Você pode expandir essa API para se conectar a um banco de dados real para operações persistentes.

# ENGLISH

## Description
This is a simple example of an API for product control in ASP.NET Core. The code provides basic CRUD (Create, Read, Update, Delete) operations for a static list of products.

## Features
- **GET `/api/products`**: Returns all products.
- **GET `/api/products/{id}`**: Returns a specific product based on the ID.
- **POST `/api/products`**: Adds a new product.
- **PUT `/api/products/{id}`**: Updates an existing product based on the ID.
- **DELETE `/api/products/{id}`**: Removes a product based on the ID.

## Usage
Ensure you have the ASP.NET Core environment set up to run this API. You can test CRUD operations using tools like Postman or Swagger.

## Setup Instructions
1. Clone this repository.
2. Open the project in your preferred IDE.
3. Run the application.
4. Utilize the provided routes to interact with the products.

## Additional Notes
- This implementation uses a static list of products to simulate a database.
- You can expand this API to connect to a real database for persistent operations.
