# 🐉 Dragon Ball API - CRUD Completo com .NET 9 & EF Core

Esta é uma Web API de alto desempenho desenvolvida em **C# .NET 9** para o gerenciamento de personagens do universo Dragon Ball. O projeto utiliza as últimas atualizações do ecossistema .NET, focando em performance, código limpo e persistência de dados relacional.

---

##  Tecnologias e Ferramentas

* **Framework:** .NET 9.0 (ASP.NET Core Web API)
* **Linguagem:** C# 13
* **ORM:** Entity Framework Core 9.0
* **Banco de Dados:** MySQL (via **XAMPP**)
* **Documentação:** OpenAPI Nativa (.NET 9)
* **Editor:** VS Code

---

##  Configuração do Banco de Dados (XAMPP)

Para a persistência dos dados, foi utilizado o **XAMPP** para gerenciar o serviço do MySQL localmente.

* **Servidor Local:** O MySQL está rodando via Apache/XAMPP na porta `3306`.
* **String de Conexão:** Configurada no `appsettings.json` apontando para o servidor local com usuário `root` e sem senha (padrão XAMPP).
* **Mapeamento de Dados:** As classes C# foram convertidas em tabelas SQL usando as ferramentas de **Migrations** do EF Core.

---

##  Funcionalidades e Diferenciais

### 1. Documentação Nativa (.NET 9)
Diferente das versões anteriores, este projeto utiliza o suporte nativo do .NET 9 para **OpenAPI**. A visualização e testes dos endpoints são feitos através da nova interface padrão, oferecendo uma experiência de teste de API mais moderna e integrada.

### 2. CRUD Assíncrono Completo
Implementação total dos métodos HTTP para manipulação de personagens:
* **GET /api/personagens**: Lista todos os registros.
* **GET /api/personagens/{id}**: Busca por um ID específico com tratamento de erro 404.
* **POST /api/personagens**: Criação de novos guerreiros com validação de corpo.
* **PUT /api/personagens/{id}**: Atualização de registros existentes no banco.
* **DELETE /api/personagens/{id}**: Remoção física do registro via ID.

### 3. Validações com Data Annotations
Regras de integridade aplicadas diretamente no Model `Personagem.cs`:
* **[Key]**: Identificação da chave primária.
* **[Required]**: Campos 'Nome' e 'Tipo' definidos como obrigatórios.
* **[MaxLength(50)]**: Limite de caracteres para otimização de espaço no banco de dados.

---

## 4. Como Executar o Projeto

1. Certifique-se de ter o **SDK do .NET 9** instalado em sua máquina.
2. Inicie o módulo **MySQL** no painel de controle do **XAMPP**.
3. Clone este repositório e navegue até a pasta do projeto.
4. Execute o comando para subir o banco de dados:
   ```bash
   dotnet ef database update

## 5. Inicie a aplicação:
   ```bash
     dotnet run

