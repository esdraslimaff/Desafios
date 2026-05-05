# 📌 Desafios

Repositório contendo soluções para desafios de programação(Projeto Console) e uma API desenvolvida em .NET.

---

## 📦 Organização do repositório

Este repositório está dividido em dois contextos principais:

### 🧠 Desafios (algoritmos)

A pasta `Desafios/` contém implementações de desafios de lógica de programação (estilo LeetCode), como:

* Fibonacci
* Palíndromo
* Normalização de texto

Os desafios foram desenvolvidos em um **projeto Console**, utilizando **interfaces** para melhor organização e separação de responsabilidades.

📌 Objetivo:

* Demonstrar clareza na implementação
* Aplicar boas práticas mesmo em problemas simples

---

### 🚀 API (Oficina)

O projeto `Oficina.WebAPI/` contém a API desenvolvida para o desafio técnico descrito abaixo.

---

# 📌 Oficina API

API desenvolvida em **.NET** para gerenciamento de orçamentos em uma oficina mecânica, conforme proposto no desafio técnico.

---

## 🚀 Objetivo

Implementar endpoints para:

* Criação de orçamentos
* Consulta de orçamentos cadastrados
* Validação de dados de entrada
* Cálculo automático do valor total

---

## 🛠️ Tecnologias utilizadas

* ASP.NET Core Web API
* Entity Framework Core (InMemory)
* FluentValidation
* Swagger (OpenAPI)

---

## 📁 Estrutura do projeto

```plaintext
Controllers/
DTOs/
Services/
Entities/
Data/
Middleware/
Validators/
```

---

## 📌 Endpoints

### ➤ Criar Orçamento

```http
POST /api/orcamentos
```

#### 📥 Exemplo de requisição

```json
{
  "clienteId": 10,
  "veiculoId": 25,
  "itens": [
    {
      "descricao": "Troca de óleo",
      "quantidade": 1,
      "valorUnitario": 120.00
    },
    {
      "descricao": "Filtro de óleo",
      "quantidade": 1,
      "valorUnitario": 45.00
    }
  ]
}
```

---

### ➤ Listar Orçamentos

```http
GET /api/orcamentos
```

---

## ✅ Regras implementadas

* `clienteId` obrigatório
* `veiculoId` obrigatório
* Deve existir pelo menos 1 item
* Cada item deve conter:

  * Descrição obrigatória
  * Quantidade maior que zero
  * Valor unitário maior que zero
* O valor total é calculado automaticamente pela API

---

## 🔍 Validação

As validações de entrada foram implementadas com **FluentValidation**, permitindo:

* Centralização das regras
* Controllers mais limpas
* Melhor separação de responsabilidades

📌 As entidades foram mantidas simples (sem auto-validação) para evitar duplicação de regras neste contexto.

---

## 🧠 Regra de negócio

A lógica de cálculo do orçamento foi implementada na camada de **Service**, garantindo separação entre:

* Validação
* Regra de negócio
* Persistência

---

## 🛡️ Tratamento de erros

Foi implementado um **middleware global** para:

* Capturar exceções não tratadas
* Retornar respostas padronizadas
* Evitar exposição de erros internos

---

## ⚙️ Persistência

Foi utilizado o **Entity Framework Core com banco em memória (InMemory)** com o objetivo de:

* Simplificar a execução do projeto
* Evitar dependências externas
* Permitir avaliação rápida da solução

---

## ⚖️ Decisões de arquitetura

Para manter o foco no escopo do desafio e na clareza da solução, foram adotadas as seguintes decisões:

- Não foi aplicada uma arquitetura completa (DDD/Clean Architecture), mantendo a implementação concentrada na camada de Web API
- Utilização de banco em memória (EF Core InMemory) para simplificar a execução e evitar dependências externas
- Mapeamento entre entidades e DTOs realizado de forma manual, considerando a simplicidade do cenário

📌 Essas decisões foram intencionais, visando reduzir complexidade e facilitar a avaliação da solução.

---

## 🚧 Considerações para um cenário real

Em um ambiente de produção ou projeto real, adotaria uma abordagem mais robusta, incluindo:

- Utilização de banco de dados relacional (ex: SQL Server)
- Uso de Docker e Docker Compose para padronização do ambiente
- Separação por camadas (ex: Domain, Application, Infrastructure e API), seguindo princípios de Clean Architecture/DDD
- Implementação de testes automatizados

📌 Essas escolhas refletem minhas práticas usuais e facilitam padronização e execução do ambiente.

---

## ▶️ Como executar

```bash
dotnet run
```

Acesse:

```
https://localhost:{porta}/swagger
```

---

## 💬 Resumo final

> O projeto foi desenvolvido com foco em clareza, boas práticas e aderência ao escopo do desafio, enquanto demonstra conhecimento de abordagens mais robustas para cenários reais.

---

