
# 🧾 Razor - Frontend para Validação de XML de NFe

Este projeto é uma aplicação **ASP.NET Core Razor Pages** que serve como **interface frontend** para validação de arquivos XML de **Nota Fiscal Eletrônica (NFe)**, utilizando como backend o projeto [NFeXMLValidator](https://github.com/tas284/NFeXMLValidator).

---

## ✅ Requisitos

- [.NET SDK 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- Docker (opcional)
- Backend rodando: [NFeXMLValidator](https://github.com/tas284/NFeXMLValidator)

---

## ⚙️ Desenvolvimento - Build e Execução

Entre no diretório raiz do projeto e execute:

```bash
dotnet build
dotnet run
```

---

## 🐳 Executando com Docker

### 📦 Build da imagem

```bash
docker build -t razor .
```

### ▶️ Executar com `docker compose`

```bash
docker compose up -d
```

---

## 🏭 Executar Frontend + Backend em Produção (docker-compose)

```bash
docker compose -f .\docker-compose.prod.yml up
```

---

## 📘 Documentação da API via Swagger

Se estiver usando o backend NFeXMLValidator, você pode acessar a documentação da API em:

🔗 [http://localhost:5001/swagger/index.html](http://localhost:5001/swagger/index.html)

- Ambiente `Development`: Swagger habilitado
- Ambiente `Production`: Swagger desabilitado por padrão

---

## 🐳 DockerHub

Se quiser apoiar o projeto, você pode avaliá-lo no Docker Hub:

👉 [DockerHub - Razor](https://hub.docker.com/r/tiagosaldanha/razor)

---

## 📄 Licença

Este projeto pode ser licenciado conforme sua preferência. Adicione um arquivo `LICENSE` com os termos desejados.

---

## 👨‍💻 Desenvolvido por

Tiago (Razor XML Validator)

---
