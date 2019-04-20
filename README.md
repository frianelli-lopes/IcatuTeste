# IcatuTeste
API Restful desenvolvida como parte de solução para processo seletivo da Icatu.


### Sobre o Desenvolvimento da Solução
Solução desenvolvida com Visual Studio 2017 Community, utilizando .Net Core 2.1
- Banco de Dados LocalDb SQL Server
- DDD
- Code First
- Injeção de dependência
- Automapper
- Autenticação JWT


### Utilização da API
Devido à implementação da autenticação JWT, é necessário passar o token bearer nos requests, que pode ser recuperado através de um endpoint específico para o login.  As configurações abaixo baseiam-se nas telas do Postman. 

1. Recuperando um token (para facilitar a implementação, a validação é feita através de usuário = senha).
```
URL: https://servidor:porta/api/login (ex.: https://localhost:44364/api/login)
Verbo: POST
Headers: 
    Key: 'Content-Type' / Value: 'application/json'
Body:
    {
      "usuario": "flavio",
      "senha": "flavio"
    }
```

2. Recuperando uma lista de clientes
```
URL: https://servidor:porta/api/clientes (ex.: https://localhost:44364/api/clientes)
Verbo: GET
Authorization: 
    Type: 'Bearer Token' / Token: token retornado pela requisição do item 1.
```

3. Recuperando um cliente
```
URL: https://servidor:porta/api/clientes/{id} (ex.: https://localhost:44364/api/clientes/1)
Verbo: GET
Authorization: 
    Type: 'Bearer Token' / Token: token retornado pela requisição do item 1.
```

4. Incluindo um cliente
```
URL: https://servidor:porta/api/clientes (ex.: https://localhost:44364/api/clientes)
Verbo: POST
Authorization: 
    Type: 'Bearer Token' / Token: token retornado pela requisição do item 1.
Headers: 
    Key: 'Content-Type' / Value: 'application/json'
Body:
    {
        "name": "Cliente ABC",
        "birthday": "29/04/1999",
        "gender": "F",
        "document": "11122233344"
    }
```

5. Alterando um cliente
```
URL: https://servidor:porta/api/clientes/{id} (ex.: https://localhost:44364/api/clientes/1)
Verbo: PUT
Authorization: 
    Type: 'Bearer Token' / Token: token retornado pela requisição do item 1.
Headers: 
    Key: 'Content-Type' / Value: 'application/json'
Body:
    {
        "name": "Cliente ABC DEF",
        "birthday": "29/04/1999",
        "gender": "F",
        "document": "11122233344"
    }
```

6. Excluindo um cliente
```
URL: https://servidor:porta/api/clientes/{id} (ex.: https://localhost:44364/api/clientes/1)
Verbo: DELETE
Authorization: 
    Type: 'Bearer Token' / Token: token retornado pela requisição do item 1.
Headers: 
    Key: 'Content-Type' / Value: 'application/json'
```


### Autor/Data
Flavio Rianelli
Abril/2019
