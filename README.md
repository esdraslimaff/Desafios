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

Para manter o foco no desafio e na clareza da solução:

* Não foi utilizada camada de repositório
* Não foi aplicada uma arquitetura completa (DDD/Clean Architecture)
* Utilizado banco em memória ao invés de banco relacional
* O mapeamento entre entidades e DTOs foi realizado de forma manual, considerando a simplicidade do projeto.

📌 Essas decisões foram intencionais para evitar complexidade desnecessária no contexto do teste.

---

## 🚧 Considerações para um cenário real

Em um ambiente de produção ou projeto real, adotaria uma abordagem mais robusta, incluindo:

* Uso de **SQL Server** como banco de dados
* Configuração com **Docker e Docker Compose** para facilitar a execução e padronização do ambiente
* Separação por camadas, com uso de  Clean Architecture / DDD (exemplo: Domain, Application, Infra, testes...)
* Testes automatizados

📌 Essas escolhas refletem minhas preferências e práticas usuais de desenvolvimento, além de facilitarem a execução e avaliação do projeto em ambientes reais.

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

## ✅ Conclusão

A solução atende aos requisitos do desafio, demonstrando:

* Validação consistente
* Separação de responsabilidades
* Código limpo e organizado
* Uso de boas práticas

---

## 💬 Resumo final

> O projeto foi desenvolvido com foco em simplicidade, clareza e aderência ao escopo do desafio, enquanto evidencia conhecimento de boas práticas aplicáveis em cenários reais.

---

Se quiser, posso te dar uma versão **ultra enxuta (tipo 10 linhas)** ou uma **versão “impacto máximo” com badges e destaque visual** pra chamar atenção de recrutador.
