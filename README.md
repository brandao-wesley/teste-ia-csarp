# CRUD_clientes

Projeto C#/.NET (net9.0) gerado pelo Fabulosoft Dev Agent seguindo Clean Architecture, DDD, SOLID, injeção de dependência e testes unitários abrangentes.

## Estrutura

- `src/Crud_Clientes.Domain`: entidades, value objects, contratos e regras de domínio.
- `src/Crud_Clientes.Application`: DTOs, serviços de aplicação, validação e casos de uso.
- `src/Crud_Clientes.Infrastructure`: persistência EF Core, repositórios e injeção de infraestrutura.
- `src/Crud_Clientes.Api`: inicialização, controllers, settings, Swagger e endpoints.
- `tests/Crud_Clientes.UnitTests`: testes unitários das regras de domínio e aplicação.

## Rodar API

```powershell
.\run_backend.ps1
```

## Rodar testes com cobertura

```powershell
.\run_tests.ps1
```

## Instrução original

Criar um Crud de cliente, seguindo:

1) tela de Cadastro
2) Tela de listagem
3) Tela de deleção
4) O sistema tem q ter uma tela principal, com um logo no meio e um menu responsivo com as opções q levara a cada tela

importante, essas telas sejam modais e bem bonita.

tem q ter frontend em Blazor e backend em c# net 8. banco de dados em SQLitelocal

Cores branco, laranja e preto, cores de botões brilhantes e animações

Importande com documentação do sistema e instrução para rodar localmente

## Rotas iniciais

Ao rodar a API, a raiz `/` redireciona para `/swagger`, evitando 404 ao abrir o projeto no navegador.

Rotas úteis:

- `/` → Swagger
- `/swagger` → documentação interativa da API
- `/health` → health check
- `/api` → resumo da API
- `/api/customers` → CRUD de clientes

