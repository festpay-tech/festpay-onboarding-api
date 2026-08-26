# 🧪 Teste Técnico - Dev Fullstack (.NET/C#) - Festpay

## 🎯 Objetivo

Construir e manter uma api em .NET 9 utilizando o padrão CQRS afim de manter um sistema de contas e transações da Festpay. Utilizando dos métodos já existentes, construa a entidade de Transações e o seu respectivo CRUD.
A entidade deve herdar a entidade base e possuir os seguintes dados:

- **Conta de destino**
- **Conta de origem**
- **Valor**
- **Cancelada**

Deverá ser desenvolvido métodos para:

- **Buscar todas as transações**
- **Buscar uma transação pelo Id**
- **Inserir uma transação**
- **Cancelar uma transação**

O projeto já traz uma entidade `Account` completa (entidade + CRUD parcial + testes) seguindo os padrões da arquitetura. Use-a como referência direta de como a entidade `Transaction` deve ser construída — mesmo padrão `Builder`, mesmas convenções de CQRS via MediatR, mesmo uso de `ICarterModule`, mesmas convenções de exceções de domínio.

---

**ATENÇÃO** - Não se esqueça de desenvolver os testes de domínio e testes de aplicação.

---

## ⏱️ Tempo esperado

Este teste foi desenhado para ser resolvido em **cerca de 3 a 4 horas**, assumindo familiaridade com o stack (CQRS, MediatR, EF Core). Não esperamos — nem avaliamos positivamente — funcionalidades além do que está descrito em Objetivo (ex: movimentação de saldo entre contas, regras de negócio adicionais, autenticação). Prefira uma entrega enxuta e correta a uma entrega ampliada e incompleta.

Antes de começar, confirme que o projeto compila e que a suíte de testes já existente passa (`dotnet build` e `dotnet test` na raiz). Se algo estiver quebrado nesse ponto, é um problema no seu ambiente, não no repositório — pare e reporte ao recrutador em vez de tentar contornar.

## 🤖 Sobre uso de ferramentas de IA

O uso de assistentes de IA (Copilot, ChatGPT, Claude, Codex, Cursor, etc.) é **permitido e não é penalizado por si só**. O que avaliamos é o seu julgamento de engenharia, não se você digitou cada linha manualmente.

Dito isso:
- Você deve ser capaz de **explicar e defender qualquer decisão do código entregue**, linha a linha, em uma etapa técnica posterior — inclusive código gerado por IA. Não saber justificar uma escolha presente na sua própria entrega é motivo de reprovação, independente de como o código foi produzido.
- Priorize resolver exatamente o que foi pedido. Pipelines elaborados de agentes, specs geradas automaticamente, ou escopo adicional não pontuam a seu favor — o critério é a qualidade e correção da entrega em relação ao Objetivo, dentro do tempo esperado acima.
- Se usar IA de forma extensiva no processo, mencione isso brevemente no README da sua entrega (quais ferramentas, para quê). Transparência é vista positivamente; omitir não é motivo de reprovação isolado, mas discrepâncias entre o que você entrega e o que consegue explicar na entrevista são.

---

## 🧱 Critérios de Avaliação

- Separação das regras de domínio e regras de aplicação
- Estrutura e funcionalidade do código existente e do código redigido
- Uso correto da arquitetura definida no projeto
- Princípios SOLID
- Tratamento de exceções
- Código limpo e organizado

---

## 📤 Entrega

- Criar um fork do projeto e submetê-lo com as implementações
- Atualizar o README com:
  - Tecnologias utilizadas
  - Instruções para rodar o projeto
- As instruções para envio do projeto deverão seguir as orientações enviadas pelo recrutador.
