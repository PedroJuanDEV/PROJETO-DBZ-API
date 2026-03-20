# 🐉 Dragon Ball API - CRUD Completo com .NET 9 & EF Core

Esta é uma Web API de alto desempenho desenvolvida em **C# .NET 9** para o gerenciamento de personagens do universo Dragon Ball. O projeto utiliza as últimas atualizações do ecossistema .NET, focando em performance, código limpo e persistência de dados relacional.

---

## 🛠️ Tecnologias e Ferramentas

* ![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white) **Framework:** .NET 9.0 (ASP.NET Core Web API)
* ![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white) **Linguagem:** C# 13
* ![MySQL](https://img.shields.io/badge/MySQL-00000f?style=for-the-badge&logo=mysql&logoColor=white) **Banco de Dados:** MySQL (via **XAMPP**)
* ![DBeaver](https://img.shields.io/badge/DBeaver-382923?style=for-the-badge&logo=dbeaver&logoColor=white) **Gerenciador de Banco:** DBeaver
* ![VS Code](https://img.shields.io/badge/VS_Code-007ACC?style=for-the-badge&logo=visual-studio-code&logoColor=white) **Editor:** VS Code
* ![Entity Framework](https://img.shields.io/badge/EF_Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white) **ORM:** Entity Framework Core 9.0

---

## 🗄️ Configuração do Ambiente e Banco de Dados

Para a persistência dos dados, foi utilizado o **XAMPP** para gerenciar o serviço do MySQL e o **DBeaver** como interface de manipulação de dados.

* **Servidor Local:** MySQL rodando via XAMPP na porta `3306`.
* **Visualização:** Utilizado **DBeaver** para monitoramento das tabelas e execução de queries de teste.
* **Mapeamento de Dados:** As classes C# foram convertidas em tabelas SQL usando as ferramentas de **Migrations** do EF Core.

> [!IMPORTANT]
> **Conexão no DBeaver e Xamp:**
> ! (Print das tabelas no Dbeaver e Xamp)
<img width="669" height="439" alt="Captura de tela 2026-03-20 111052" src="https://github.com/user-attachments/assets/3fa10cde-4fbf-4cc8-b394-f6e5ebccce59" />
/>
<img width="1421" height="788" alt="image" src="https://github.com/user-attachments/assets/6ec67a60-43b8-467e-b12e-dd3a854ab6a1" />
)

---

## ✨ Funcionalidades e Diferenciais

### 1. Documentação Nativa (.NET 9)
O projeto utiliza o suporte nativo do .NET 9 para **OpenAPI**. A visualização e testes dos endpoints são feitos através da nova interface integrada, dispensando o uso de ferramentas externas para testes básicos.

> **API em Execução:**
> ![Screenshot da Documentação OpenAPI](
<img width="1903" height="951" alt="image" src="https://github.com/user-attachments/assets/861c9bc3-dc18-43ab-9c58-47104fc8a0e8" />
)

### 2. CRUD Assíncrono Completo
Implementação total dos métodos HTTP para manipulação de personagens:
* **GET /api/personagens**: Listagem geral.
* **GET /api/personagens/{id}**: Busca por ID com tratamento de erro.
* **POST /api/personagens**: Cadastro com validação de dados.
* **PUT /api/personagens/{id}**: Atualização completa de registros.
* **DELETE /api/personagens/{id}**: Remoção de registros via ID.

### 3. Validações com Data Annotations
Regras de integridade aplicadas diretamente no Model `Personagem.cs`:
* **[Key]**: Identificação da chave primária.
* **[Required]**: Nome e Tipo definidos como obrigatórios.
* **[MaxLength(50)]**: Limite de caracteres para consistência do banco.

---

## 4. Como Executar o Projeto

1. Certifique-se de ter o **SDK do .NET 9** instalado.
2. Inicie o módulo **MySQL** no painel de controle do **XAMPP**.
3. Clone este repositório e navegue até a pasta do projeto.
4. Execute o comando para subir o banco de dados:
   ```bash
   dotnet ef database update
## 5. Inicie a aplicação:

```Bash
dotnet run


