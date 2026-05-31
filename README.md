# 🐾 Pet Love Systems

O Pet Love Systems é um sistema desktop concebido para modernizar e otimizar a gestão de clínicas veterinárias e pet shops. Desenvolvido a partir de uma necessidade operacional real, o sistema substitui controles manuais e planilhas por uma plataforma digital centralizada para a gestão de clientes, estoque, controle de acesso corporativo e agendamento de serviços.

Projeto desenvolvido como trabalho prático para a disciplina de Tópicos em Linguagem de Programação I, do curso de Engenharia de Computação do Centro Universitário de Votuporanga (UNIFEV).

---

## 🛠️ Tecnologias e Ferramentas

* Back-end: C# (.NET Framework 4.7.2)
* Front-end: Windows Forms 
* Design/UI: FontAwesome.Sharp (Ícones vetorizados e interface moderna)
* Banco de Dados: Microsoft SQL Server Express
* Acesso a Dados: Micro-ORM Dapper (Alta performance e queries parametrizadas)

---

## 🏗️ Destaques de Arquitetura e Engenharia

Este projeto vai além de um simples CRUD, implementando padrões de mercado para garantir segurança, performance e integridade dos dados:

* Arquitetura SPA (Single Page Application): O formulário principal atua como um container dinâmico, injetando as telas de cadastro e listagem no painel central. Isso elimina o uso legado de múltiplas janelas flutuantes (MDI) e aprimora drasticamente a usabilidade.
* RBAC (Role-Based Access Control): Controle de segurança baseado em papéis. A interface se adapta dinamicamente, ocultando módulos (como Usuários e Produtos) de acordo com as permissões do funcionário autenticado.
* Prevenção Física de Choque de Horários: Além da inteligência na interface visual, foi implementada uma trava física no banco de dados (CONSTRAINT UNIQUE cruzando Data e Horário) para bloquear sobreposições de agendamentos em cenários de concorrência.
* Exclusão Lógica: Registros críticos (como Usuários e Produtos) são desativados (Ativo = 0) em vez de deletados fisicamente, preservando a rastreabilidade e o histórico relacional do banco de dados corporativo.
* Desnormalização Prática: Absorção de dados geográficos (Cidade/Estado) diretamente no cadastro de clientes para reduzir junções complexas (JOINs) no banco de dados, acelerando o tempo de resposta no balcão de atendimento.

---

## 📦 Módulos e Funcionalidades

- Segurança: Autenticação blindada com bloqueio de usuários inativos.
- Gestão de Clientes: Cadastro completo de tutores e gerenciamento de informações de contato.
- Controle de Estoque: Gestão de Produtos e Categorias com cálculo automático de valores e status de inatividade.
- Agendamentos Inteligentes: Registro de serviços (banho, tosa, veterinário) atrelados a horários disponíveis, calculando automaticamente o valor do serviço.
- Painel Administrativo: Manutenção de usuários do sistema, delegação de cargos e definição de níveis de acesso.

---

## 🚀 Como Executar o Projeto Localmente

1. Clone este repositório:
   git clone https://github.com/brenoalmada67-ship-it/Pet-Love-Systems.git

2. Configuração do Banco de Dados:
   * Abra o SQL Server Management Studio (SSMS).
   * Abra e execute o arquivo Script_PetShop.sql.
   * Este script criará automaticamente o banco de dados PetShopBanco, todas as tabelas, as travas de segurança e as credenciais iniciais.

3. Execução:
   * Abra o arquivo da solução (.sln) no Visual Studio.
   * Restaure os pacotes NuGet (o Dapper e o FontAwesome serão baixados automaticamente).
   * Pressione F5 (ou clique em Iniciar) para compilar e rodar a aplicação.

---

## 👨‍💻 Autor

Breno Almada Poltronieri

Graduando em Engenharia de Computação
