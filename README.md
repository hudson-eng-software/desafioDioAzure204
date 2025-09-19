# 🧾 CPF Validator Service

[![.NET](https://img.shields.io/badge/.NET-7-blue)](https://dotnet.microsoft.com/)
[![Build Status](https://img.shields.io/badge/build-passing-brightgreen)](https://github.com/)
[![License](https://img.shields.io/badge/license-MIT-green)](LICENSE)
[![Azure](https://img.shields.io/badge/Azure-deploy-blue)](https://azure.microsoft.com/)
[![Author](https://img.shields.io/badge/Author-Hudson%20Amorim-orange)](https://github.com/)

## 📌 Descrição

O **CPF Validator Service** é um microserviço em **.NET 7** para validação de CPFs brasileiros. Ele fornece uma **API REST** simples que permite validar CPFs através de um endpoint HTTP.

## 🚀 Funcionalidades

* Validação de CPF com verificação de dígitos.
* API REST com endpoint `/validate-cpf`.
* Estrutura de projeto organizada em **Core**, **API** e **Tests**.
* Fácil deploy no **Azure App Service** ou containers.

## 🛠️ Estrutura do Projeto

```
CpfValidatorService/
│
├─ CpfValidatorService.sln
├─ CpfValidatorService.Api/
│   ├─ Controllers/
│   │   └─ CpfController.cs
│   ├─ Program.cs
│   └─ appsettings.json
│
├─ CpfValidatorService.Core/
│   └─ Services/
│       └─ CpfValidationService.cs
│
└─ CpfValidatorService.Tests/
    └─ CpfValidationServiceTests.cs
```

## 📋 Como usar

1. Clone o projeto:

```bash
git clone <repo_url>
cd CpfValidatorService
```

2. Rode a aplicação:

```bash
dotnet run --project CpfValidatorService.Api
```

3. Teste o endpoint via navegador ou Postman:

```
GET https://localhost:5001/cpf/validate-cpf?cpf=123.456.789-09
```

## 🧪 Testes

Para rodar os testes unitários:

```bash
dotnet test CpfValidatorService.Tests
```

## ☁️ Deploy no Azure

1. Faça login no Azure CLI:

```bash
az login
```

2. Crie um App Service e publique o projeto.

## 📄 Licença

Este projeto está licenciado sob a **MIT License**.

---

Desenvolvido **Hudson Amorim** 
