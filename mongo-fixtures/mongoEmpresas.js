/* eslint-disable */
db.getSiblingDB('empresa').getCollection('empresas').insert([
    {
        "_id": ObjectId("5de9957c4a091300016e1389"),
        "id": "04020662000184",
        "nomeFantasia": "Visionflex Soluções Gráficas",
        "razaoSocial": "VISIONFLEX SOLUCOES GRAFICAS LTDA",
        "segmento": "Outros",
        "site": "http://www.visionflex.com.br/",
        "tipo": "Cliente",
        "empresaProprietariaId": "04020662000184",
        "centroCusto": "",
        "gruposOrganizacionais": [],
        "documentos": [
            {
                "tipo": "CNPJ",
                "numero": "04020662000184"
            }
        ],
        "cobranca": {
            "emailAlternativo": "",
            "cobrancaAutomatica": false,
            "faturarMesFechado": false,
            "diaInicial": null,
            "diaFinal": null
        },
        "responsavel": {
            "nome": "Renata Santos Justo",
            "email": "rh@visionflex.com.br",
            "telefone": "1156413361",
            "celular": "11999999999"
        },
        "financeiro": {
            "email": "financeiro@visionflex.com.br",
            "prazoPagamento": NumberInt(30),
            "formaPagamento": "forma_xpto",
            "diaPagamento": NumberInt(7),
            "contato": "Contato financeiro",
            "telefone": "11989897878"
        },
        "comercial": {
            "email": "comercial@visionflex.com.br",
            "contato": "Contato comercial",
            "telefone": "11989897547"
        },
        "endereco": {
            "logradouro": "Rua Abílio Borin",
            "numero": "35",
            "complemento": "Portão 1",
            "bairro": "Paulista",
            "cidade": "São Paulo",
            "estado": "SP",
            "cep": "04729030",
            "pais": "BR"
        },
        "planos": [
            {
                "_id": UUID("005d9991-e7c7-49ff-a617-fa3ce1bad9e5"),
                "diarias": 4,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "90.00",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("7077243c-c72f-4f2d-8f2d-7b1ccafe1e6a"),
                "diarias": 7,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "158.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("3338f00e-8589-4113-bd09-fc66eaa832c6"),
                "diarias": 10,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "226.0",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": 226.0,
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("dadde404-6016-4d4d-b5b0-e90b2776b48f"),
                "diarias": 14,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "317.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("2c51afde-4f49-4193-a948-24018d543fb3"),
                "diarias": 4,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "117.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("30bb9449-b489-4416-9659-b8de544c10e9"),
                "diarias": 7,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "205.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("df3d6e2c-f124-4b56-b287-327cccb6bf84"),
                "diarias": 10,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "293.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("c9b53d9a-8461-4c1e-b9b6-b3d23d09211b"),
                "diarias": 14,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "411.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("13dd8ce0-8e66-40ba-82e7-75c0b0f74cb8"),
                "diarias": 4,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis 5 estrelas e resorts",
                "tipoPlano": "Especial",
                "valorPlano": "164.00",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("74fffea8-b591-492a-93c8-6331240dfd0d"),
                "diarias": 7,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis 5 estrelas e resorts",
                "tipoPlano": "Especial",
                "valorPlano": "287.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("c2a33808-d55b-412e-a97d-2b652e102006"),
                "diarias": 10,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Especial 10 Diárias",
                "tipoPlano": "Especial",
                "valorPlano": "410.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("421606e9-1b75-44c0-9879-b408028b7372"),
                "diarias": 14,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis 5 estrelas e resorts",
                "tipoPlano": "Especial",
                "valorPlano": "574.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("efa03922-e7e5-40dc-8047-329d5faef366"),
                "diarias": 4,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "246.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("eb176c76-23bd-4040-887b-721b614cbb3a"),
                "diarias": 7,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "431.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("4fefb637-a383-45e0-997c-7e892193974f"),
                "diarias": 10,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "616.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("07beedb9-5bf1-432d-bce5-de1e7a2a8e51"),
                "diarias": 14,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "863.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("ded45256-dec7-4c3a-a5e9-e491dde84a9e"),
                "diarias": 4,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "418.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("efeab279-3c8c-48ce-bf5d-994d8ffd8dda"),
                "diarias": 7,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "732.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("b32183c5-359e-4c6c-a4c0-211368dada0d"),
                "diarias": 10,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "1046.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("9418dfa3-496a-449b-b43e-63741d71f77a"),
                "diarias": 14,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": 1465.0,
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            }
        ],
        "ativo": true,
        "dataCriacao": ISODate("2019-12-05T23:40:44.615Z"),
        "dataAtualizacao": null,
        "dataDelecao": null,
        "alias": "visionflex"
    },
    {
        "_id": ObjectId("5de999674a091300016e138a"),
        "id": "31445249000134",
        "nomeFantasia": "Weclix",
        "razaoSocial": "P16 TELECOM LTDA",
        "segmento": "Servicos",
        "site": "https://weclix.com.br/",
        "tipo": "Cliente",
        "empresaProprietariaId": "31445249000134",
        "centroCusto": "",
        "gruposOrganizacionais": [],
        "documentos": [
            {
                "tipo": "CNPJ",
                "numero": "31445249000134"
            }
        ],
        "cobranca": {
            "emailAlternativo": "",
            "cobrancaAutomatica": false,
            "faturarMesFechado": false,
            "diaInicial": null,
            "diaFinal": null
        },
        "responsavel": {
            "nome": "Aline Scatena",
            "email": "ascatena@weclix.com.br",
            "telefone": "1640420092",
            "celular": ""
        },
        "endereco": {
            "logradouro": "AV. Presidente vargas",
            "numero": "387",
            "complemento": "",
            "bairro": "Jd. Califórnia",
            "cidade": "Ribeirão Preto",
            "estado": "SP",
            "cep": "14020260",
            "pais": "BR"
        },
        "financeiro": {
            "email": "financeiro@weclix.com.br",
            "prazoPagamento": NumberInt(30),
            "formaPagamento": "forma_xpto",
            "diaPagamento": NumberInt(7),
            "contato": "Contato financeiro",
            "telefone": "11989897878"
        },
        "comercial": {
            "email": "comercial@weclix.com.br",
            "contato": "Contato comercial",
            "telefone": "11989897547"
        },
        "planos": [
            {
                "_id": UUID("005d9991-e7c7-49ff-a617-fa3ce1bad9e5"),
                "diarias": 4,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "90.00",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("7077243c-c72f-4f2d-8f2d-7b1ccafe1e6a"),
                "diarias": 7,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "158.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("3338f00e-8589-4113-bd09-fc66eaa832c6"),
                "diarias": 10,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "226.0",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": 226.0,
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("dadde404-6016-4d4d-b5b0-e90b2776b48f"),
                "diarias": 14,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "317.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("2c51afde-4f49-4193-a948-24018d543fb3"),
                "diarias": 4,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "117.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("30bb9449-b489-4416-9659-b8de544c10e9"),
                "diarias": 7,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "205.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("df3d6e2c-f124-4b56-b287-327cccb6bf84"),
                "diarias": 10,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "293.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("c9b53d9a-8461-4c1e-b9b6-b3d23d09211b"),
                "diarias": 14,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "411.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("13dd8ce0-8e66-40ba-82e7-75c0b0f74cb8"),
                "diarias": 4,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis 5 estrelas e resorts",
                "tipoPlano": "Especial",
                "valorPlano": "164.00",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("74fffea8-b591-492a-93c8-6331240dfd0d"),
                "diarias": 7,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis 5 estrelas e resorts",
                "tipoPlano": "Especial",
                "valorPlano": "287.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("c2a33808-d55b-412e-a97d-2b652e102006"),
                "diarias": 10,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Especial 10 Diárias",
                "tipoPlano": "Especial",
                "valorPlano": "410.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("421606e9-1b75-44c0-9879-b408028b7372"),
                "diarias": 14,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis 5 estrelas e resorts",
                "tipoPlano": "Especial",
                "valorPlano": "574.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("efa03922-e7e5-40dc-8047-329d5faef366"),
                "diarias": 4,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "246.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("eb176c76-23bd-4040-887b-721b614cbb3a"),
                "diarias": 7,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "431.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("4fefb637-a383-45e0-997c-7e892193974f"),
                "diarias": 10,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "616.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("07beedb9-5bf1-432d-bce5-de1e7a2a8e51"),
                "diarias": 14,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "863.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("ded45256-dec7-4c3a-a5e9-e491dde84a9e"),
                "diarias": 4,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "418.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("efeab279-3c8c-48ce-bf5d-994d8ffd8dda"),
                "diarias": 7,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "732.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("b32183c5-359e-4c6c-a4c0-211368dada0d"),
                "diarias": 10,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "1046.0",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            },
            {
                "_id": UUID("9418dfa3-496a-449b-b43e-63741d71f77a"),
                "diarias": 14,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": 1465.0,
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "0"
                }
            }
        ],
        "ativo": true,
        "dataCriacao": ISODate("2019-12-05T23:57:27.795Z"),
        "dataAtualizacao": null,
        "dataDelecao": null,
        "alias": "weclix"
    },
    {
        "_id": ObjectId("5dee99044a091300016e138c"),
        "id": "65069130000126",
        "nomeFantasia": "Visionband",
        "razaoSocial": "Vision Band Soluções em Impressão LTDA",
        "segmento": "analistas",
        "site": "",
        "tipo": "Cliente",
        "empresaProprietariaId": "04020662000184",
        "centroCusto": "",
        "gruposOrganizacionais": [],
        "documentos": [
            {
                "tipo": "CNPJ",
                "numero": "65069130000126"
            }
        ],
        "cobranca": {
            "emailAlternativo": "",
            "cobrancaAutomatica": false,
            "faturarMesFechado": false,
            "diaInicial": null,
            "diaFinal": null
        },
        "responsavel": {
            "nome": "Renata Santos Justo",
            "email": "rh@visionflex.com.br",
            "telefone": "1121720255",
            "celular": "11999999999"
        },
        "endereco": {
            "logradouro": "Rua Abílio Borin",
            "numero": "35",
            "complemento": "Portão 1",
            "bairro": "Paulista",
            "cidade": "São Paulo",
            "estado": "SP",
            "cep": "04729030",
            "pais": "BR"
        },
        "financeiro": {
            "email": "financeiro@visionflex.com.br",
            "prazoPagamento": NumberInt(30),
            "formaPagamento": "forma_xpto",
            "diaPagamento": NumberInt(7),
            "contato": "Contato financeiro",
            "telefone": "11989897878"
        },
        "comercial": {
            "email": "comercial@visionflex.com.br",
            "contato": "Contato comercial",
            "telefone": "11989897547"
        },
        "planos": [
            {
                "_id": UUID("005d9991-e7c7-49ff-a617-fa3ce1bad9e5"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "90.00",
                "diarias": 4,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("7077243c-c72f-4f2d-8f2d-7b1ccafe1e6a"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "158.0",
                "diarias": 7,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("3338f00e-8589-4113-bd09-fc66eaa832c6"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "226.0",
                "diarias": 10,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "226.0",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("dadde404-6016-4d4d-b5b0-e90b2776b48f"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "317.0",
                "diarias": 14,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("2c51afde-4f49-4193-a948-24018d543fb3"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "117.0",
                "diarias": 4,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("30bb9449-b489-4416-9659-b8de544c10e9"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "205.0",
                "diarias": 7,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("df3d6e2c-f124-4b56-b287-327cccb6bf84"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "293.0",
                "diarias": 10,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("c9b53d9a-8461-4c1e-b9b6-b3d23d09211b"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "411.0",
                "diarias": 14,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("13dd8ce0-8e66-40ba-82e7-75c0b0f74cb8"),
                "titulo": "Hotéis 5 estrelas e resorts",
                "tipoPlano": "Especial",
                "valorPlano": "164.00",
                "diarias": 4,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("74fffea8-b591-492a-93c8-6331240dfd0d"),
                "titulo": "Hotéis 5 estrelas e resorts",
                "tipoPlano": "Especial",
                "valorPlano": "287.0",
                "diarias": 7,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("8ceac061-abf2-4054-9ba5-7e170e5d1b6c"),
                "titulo": "Especial 10 Diárias",
                "tipoPlano": "Especial",
                "valorPlano": "410.0",
                "diarias": 10,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("421606e9-1b75-44c0-9879-b408028b7372"),
                "titulo": "Hotéis 5 estrelas e resorts",
                "tipoPlano": "Especial",
                "valorPlano": "574.0",
                "diarias": 14,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("efa03922-e7e5-40dc-8047-329d5faef366"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "246.0",
                "diarias": 4,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("eb176c76-23bd-4040-887b-721b614cbb3a"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "431.0",
                "diarias": 7,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("4fefb637-a383-45e0-997c-7e892193974f"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "616.0",
                "diarias": 10,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("07beedb9-5bf1-432d-bce5-de1e7a2a8e51"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "863.0",
                "diarias": 14,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("ded45256-dec7-4c3a-a5e9-e491dde84a9e"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "418.0",
                "diarias": 4,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("efeab279-3c8c-48ce-bf5d-994d8ffd8dda"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "732.0",
                "diarias": 7,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("b32183c5-359e-4c6c-a4c0-211368dada0d"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "1046.0",
                "diarias": 10,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            },
            {
                "_id": UUID("9418dfa3-496a-449b-b43e-63741d71f77a"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "1465.0",
                "diarias": 14,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-09T18:57:08.467Z"),
                "ativo": true
            }
        ],
        "ativo": true,
        "dataCriacao": ISODate("2019-12-09T18:57:08.467Z"),
        "dataAtualizacao": null,
        "dataDelecao": null,
        "alias": "visionband"
    },
    {
        "_id": ObjectId("5deff8024a091300016e138d"),
        "id": "08065557000112",
        "nomeFantasia": "Tecnisa",
        "razaoSocial": "Tecnisa S.A",
        "segmento": "Outros",
        "site": "https://www.tecnisa.com.br/sp/sao-paulo",
        "tipo": "Cliente",
        "empresaProprietariaId": "08065557000112",
        "centroCusto": "",
        "gruposOrganizacionais": [],
        "documentos": [
            {
                "tipo": "CNPJ",
                "numero": "08065557000112"
            }
        ],
        "cobranca": {
            "emailAlternativo": "",
            "cobrancaAutomatica": false,
            "faturarMesFechado": false,
            "diaInicial": null,
            "diaFinal": null
        },
        "responsavel": {
            "nome": "Fernanda Pontes Maziero",
            "email": "fernanda.pontes@tecnisa.com.br",
            "telefone": "1137081166",
            "celular": "11999999999"
        },
        "endereco": {
            "logradouro": "Avenida Brigadeiro Faria Lima",
            "numero": "3729",
            "complemento": "1º Andar",
            "bairro": "Itaim",
            "cidade": "São Paulo",
            "estado": "SP",
            "cep": "04538133",
            "pais": "BR"
        },
        "financeiro": {
            "email": "financeiro@tecnisa.com.br",
            "prazoPagamento": NumberInt(30),
            "formaPagamento": "forma_xpto",
            "diaPagamento": NumberInt(7),
            "contato": "Contato financeiro",
            "telefone": "11989897878"
        },
        "comercial": {
            "email": "comercial@tecnisa.com.br",
            "contato": "Contato comercial",
            "telefone": "11989897547"
        },
        "planos": [
            {
                "_id": UUID("005d9991-e7c7-49ff-a617-fa3ce1bad9e5"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "90.00",
                "diarias": 4,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("7077243c-c72f-4f2d-8f2d-7b1ccafe1e6a"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "158.0",
                "diarias": 7,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("3338f00e-8589-4113-bd09-fc66eaa832c6"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "226.0",
                "diarias": 10,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "226.0",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("dadde404-6016-4d4d-b5b0-e90b2776b48f"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "317.0",
                "diarias": 14,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("2c51afde-4f49-4193-a948-24018d543fb3"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "117.0",
                "diarias": 4,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("30bb9449-b489-4416-9659-b8de544c10e9"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "205.0",
                "diarias": 7,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("df3d6e2c-f124-4b56-b287-327cccb6bf84"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "293.0",
                "diarias": 10,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("c9b53d9a-8461-4c1e-b9b6-b3d23d09211b"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "411.0",
                "diarias": 14,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("13dd8ce0-8e66-40ba-82e7-75c0b0f74cb8"),
                "titulo": "Hotéis 5 estrelas e resorts",
                "tipoPlano": "Especial",
                "valorPlano": "164.00",
                "diarias": 4,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("74fffea8-b591-492a-93c8-6331240dfd0d"),
                "titulo": "Hotéis 5 estrelas e resorts",
                "tipoPlano": "Especial",
                "valorPlano": "287.0",
                "diarias": 7,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("8ceac061-abf2-4054-9ba5-7e170e5d1b6c"),
                "titulo": "Especial 10 Diárias",
                "tipoPlano": "Especial",
                "valorPlano": "410.0",
                "diarias": 10,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("421606e9-1b75-44c0-9879-b408028b7372"),
                "titulo": "Hotéis 5 estrelas e resorts",
                "tipoPlano": "Especial",
                "valorPlano": "574.0",
                "diarias": 14,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("efa03922-e7e5-40dc-8047-329d5faef366"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "246.0",
                "diarias": 4,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("eb176c76-23bd-4040-887b-721b614cbb3a"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "431.0",
                "diarias": 7,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("4fefb637-a383-45e0-997c-7e892193974f"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "616.0",
                "diarias": 10,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("07beedb9-5bf1-432d-bce5-de1e7a2a8e51"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "863.0",
                "diarias": 14,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("ded45256-dec7-4c3a-a5e9-e491dde84a9e"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "418.0",
                "diarias": 4,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("efeab279-3c8c-48ce-bf5d-994d8ffd8dda"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "732.0",
                "diarias": 7,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("b32183c5-359e-4c6c-a4c0-211368dada0d"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "1046.0",
                "diarias": 10,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            },
            {
                "_id": UUID("9418dfa3-496a-449b-b43e-63741d71f77a"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "1465.0",
                "diarias": 14,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2020-12-10T19:54:42.230Z"),
                "ativo": true
            }
        ],
        "ativo": true,
        "dataCriacao": ISODate("2019-12-10T19:54:42.230Z"),
        "dataAtualizacao": null,
        "dataDelecao": null,
        "alias": "tecnisa"
    },
    {
        "_id": ObjectId("5e1cb183e2dbf800019fdf43"),
        "id": "04532167000154",
        "nomeFantasia": "Bmb Mode Center",
        "razaoSocial": "Bmb Mode Center Indústria, Comércio e Serviços LTDA",
        "segmento": "Outros",
        "site": "www.modecenter.com.br",
        "tipo": "Cliente",
        "empresaProprietariaId": "04532167000154",
        "centroCusto": "10000005",
        "gruposOrganizacionais": [],
        "documentos": [
            {
                "tipo": "CNPJ",
                "numero": "04532167000154"
            }
        ],
        "cobranca": {
            "emailAlternativo": "",
            "cobrancaAutomatica": false,
            "faturarMesFechado": false,
            "diaInicial": null,
            "diaFinal": null
        },
        "responsavel": {
            "nome": "Samara Louback Ferreira",
            "email": "samara.ferreira@modecenter.com.br",
            "telefone": "2433609912",
            "celular": "11999999999"
        },
        "endereco": {
            "logradouro": "Av. Renato Monteiro",
            "numero": "8005",
            "complemento": "",
            "bairro": "Polo Urbo Agro Industrial",
            "cidade": "Porto Real",
            "estado": "RJ",
            "cep": "27570000",
            "pais": "BR"
        },
        "financeiro": {
            "email": "financeiro@modecenter.com.br",
            "prazoPagamento": NumberInt(30),
            "formaPagamento": "forma_xpto",
            "diaPagamento": NumberInt(7),
            "contato": "Contato financeiro",
            "telefone": "11989897878"
        },
        "comercial": {
            "email": "comercial@modecenter.com.br",
            "contato": "Contato comercial",
            "telefone": "11989897547"
        },
        "planos": [
            {
                "_id": UUID("005d9991-e7c7-49ff-a617-fa3ce1bad9e5"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "90.00",
                "diarias": 4,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("7077243c-c72f-4f2d-8f2d-7b1ccafe1e6a"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "158.0",
                "diarias": 7,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("3338f00e-8589-4113-bd09-fc66eaa832c6"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "226.0",
                "diarias": 10,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "226.0",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("dadde404-6016-4d4d-b5b0-e90b2776b48f"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "317.0",
                "diarias": 14,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("2c51afde-4f49-4193-a948-24018d543fb3"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "117.0",
                "diarias": 4,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("30bb9449-b489-4416-9659-b8de544c10e9"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "205.0",
                "diarias": 7,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("df3d6e2c-f124-4b56-b287-327cccb6bf84"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "293.0",
                "diarias": 10,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("c9b53d9a-8461-4c1e-b9b6-b3d23d09211b"),
                "titulo": "Hotéis de 4 e 5 estrelas",
                "tipoPlano": "Superior",
                "valorPlano": "411.0",
                "diarias": 14,
                "valorDiariaMinima": "216.01",
                "valorDiariaMaxima": "280.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("13dd8ce0-8e66-40ba-82e7-75c0b0f74cb8"),
                "titulo": "Hotéis 5 estrelas e resorts",
                "tipoPlano": "Especial",
                "valorPlano": "164.00",
                "diarias": 4,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("74fffea8-b591-492a-93c8-6331240dfd0d"),
                "titulo": "Hotéis 5 estrelas e resorts",
                "tipoPlano": "Especial",
                "valorPlano": "287.0",
                "diarias": 7,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("8ceac061-abf2-4054-9ba5-7e170e5d1b6c"),
                "titulo": "Especial 10 Diárias",
                "tipoPlano": "Especial",
                "valorPlano": "410.0",
                "diarias": 10,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("421606e9-1b75-44c0-9879-b408028b7372"),
                "titulo": "Hotéis 5 estrelas e resorts",
                "tipoPlano": "Especial",
                "valorPlano": "574.0",
                "diarias": 14,
                "valorDiariaMinima": "280.01",
                "valorDiariaMaxima": "393.00",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("efa03922-e7e5-40dc-8047-329d5faef366"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "246.0",
                "diarias": 4,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("eb176c76-23bd-4040-887b-721b614cbb3a"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "431.0",
                "diarias": 7,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("4fefb637-a383-45e0-997c-7e892193974f"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "616.0",
                "diarias": 10,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("07beedb9-5bf1-432d-bce5-de1e7a2a8e51"),
                "titulo": "Resorts e all inclusive",
                "tipoPlano": "Premium",
                "valorPlano": "863.0",
                "diarias": 14,
                "valorDiariaMinima": "393.01",
                "valorDiariaMaxima": "589.50",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("ded45256-dec7-4c3a-a5e9-e491dde84a9e"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "418.0",
                "diarias": 4,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("efeab279-3c8c-48ce-bf5d-994d8ffd8dda"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "732.0",
                "diarias": 7,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("b32183c5-359e-4c6c-a4c0-211368dada0d"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "1046.0",
                "diarias": 10,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            },
            {
                "_id": UUID("9418dfa3-496a-449b-b43e-63741d71f77a"),
                "titulo": "Resorts de luxo",
                "tipoPlano": "Exclusivo",
                "valorPlano": "1465.0",
                "diarias": 14,
                "valorDiariaMinima": "589.51",
                "valorDiariaMaxima": "1002.15",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-13T18:05:55.090Z"),
                "ativo": true
            }
        ],
        "ativo": true,
        "dataCriacao": ISODate("2020-01-13T18:05:55.090Z"),
        "dataAtualizacao": null,
        "dataDelecao": null,
        "alias": "bmb"
    },
    {
        "_id": ObjectId("5dd6f5af3caaad378c407ca1"),
        "id": "70631694000140",
        "nomeFantasia": "Voe Com a Gente",
        "razaoSocial": "Voe Com a Gente LTDA",
        "segmento": "Turismo",
        "site": "www.voecomagente.com.br",
        "tipo": "O+",
        "empresaProprietariaId": "70631694000140",
        "centroCusto": "",
        "gruposOrganizacionais": [
            "Vila dos Sapos"
        ],
        "documentos": [
            {
                "tipo": "CNPJ",
                "numero": "70631694000140"
            },
            {
                "tipo": "IE",
                "numero": "32138826000190"
            }
        ],
        "cobranca": {
            "emailAlternativo": "",
            "cobrancaAutomatica": false,
            "faturarMesFechado": false,
            "diaInicial": null,
            "diaFinal": null
        },
        "responsavel": {
            "nome": "Marlene da Silva",
            "email": "marlene.silva@zipmail.com.br",
            "telefone": "1433426289",
            "celular": "14998196768"
        },
        "endereco": {
            "logradouro": "Rua dos Bodes",
            "numero": "51",
            "complemento": "",
            "bairro": "Jardim das Cabritas",
            "cidade": "Chavantes",
            "estado": "SP",
            "cep": "18970000",
            "pais": "BR"
        },
        "financeiro": {
            "email": "financeiro@zipmail.com.br",
            "prazoPagamento": NumberInt(30),
            "formaPagamento": "forma_xpto",
            "diaPagamento": NumberInt(7),
            "contato": "Contato financeiro",
            "telefone": "11989897878"
        },
        "comercial": {
            "email": "comercial@zipmail.com.br",
            "contato": "Contato comercial",
            "telefone": "11989897547"
        },
        "planos": [
            {
                "_id": UUID("005d9991-e7c7-49ff-a617-fa3ce1bad9e5"),
                "diarias": 4,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "90.00",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "30"
                }
            }
        ],
        "ativo": true,
        "dataCriacao": ISODate("2019-11-21T20:38:07.919Z"),
        "dataAtualizacao": null,
        "dataDelecao": null,
        "alias": "portal-all-hotsite-app"
    },
    {
        "_id": ObjectId("5dfb8a5bcd2c830001e40f15"),
        "id": "28274164000126",
        "nomeFantasia": "Carlos Magnuus",
        "razaoSocial": "Carllus Magnux",
        "segmento": "analistas",
        "site": "",
        "tipo": "Cliente",
        "empresaProprietariaId": "70631694000140",
        "centroCusto": "Matriz",
        "gruposOrganizacionais": [
            "Vila Olimpia"
        ],
        "documentos": [
            {
                "tipo": "CNPJ",
                "numero": "28274164000126"
            }
        ],
        "cobranca": {
            "emailAlternativo": "",
            "cobrancaAutomatica": false,
            "faturarMesFechado": false,
            "diaInicial": null,
            "diaFinal": null
        },
        "responsavel": {
            "nome": "Henrique Martins",
            "email": "qa@ferias.co",
            "telefone": "1144224422",
            "celular": "11944224422"
        },
        "endereco": {
            "logradouro": "Avenida Paulista 2001",
            "numero": "663",
            "complemento": "",
            "bairro": "Jardim Paraíso",
            "cidade": "Botucatu",
            "estado": "SP",
            "cep": "18610261",
            "pais": "BR"
        },
        "financeiro": {
            "email": "financeiro@ferias.co",
            "prazoPagamento": NumberInt(30),
            "formaPagamento": "forma_xpto",
            "diaPagamento": NumberInt(7),
            "contato": "Contato financeiro",
            "telefone": "11989897878"
        },
        "comercial": {
            "email": "comercial@ferias.co",
            "contato": "Contato comercial",
            "telefone": "11989897547"
        },
        "planos": [
            {
                "_id": UUID("005d9991-e7c7-49ff-a617-fa3ce1bad9e5"),
                "diarias": 4,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216.00",
                "ativo": true,
                "vigencia": ISODate("2021-09-28T00:00:00.000Z"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "90.00",
                "billing": {
                    "formaPagamento": "577",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 56,
                    "coparticipacao": "30"
                }
            }
        ],
        "ativo": true,
        "dataCriacao": ISODate("2019-12-19T14:34:03.190Z"),
        "dataAtualizacao": null,
        "dataDelecao": null,
        "alias": "carlos"
    },
    {
        "_id": ObjectId("5e31dca8dc168d00012ac159"),
        "id": "84008569000193",
        "nomeFantasia": "Carol Teste",
        "razaoSocial": "CAROL TESTE",
        "segmento": "Indústria",
        "site": "www.ferias.co",
        "tipo": "Cliente",
        "empresaProprietariaId": "84008569000193",
        "centroCusto": "",
        "gruposOrganizacionais": [],
        "documentos": [
            {
                "tipo": "CNPJ",
                "numero": "84008569000193"
            }
        ],
        "cobranca": {
            "emailAlternativo": "",
            "cobrancaAutomatica": true,
            "faturarMesFechado": false,
            "diaInicial": null,
            "diaFinal": null
        },
        "responsavel": {
            "nome": "Carol Gasparini",
            "email": "carol.ferias@ferias.co",
            "telefone": "1196872000",
            "celular": "11968720000"
        },
        "endereco": {
            "logradouro": "Rua João Pais 112",
            "numero": "12",
            "complemento": "as",
            "bairro": "aaa",
            "cidade": "São Paulo",
            "estado": "SP",
            "cep": "04603039",
            "pais": "BR"
        },
        "financeiro": {
            "email": "financeiro@ferias.co",
            "prazoPagamento": NumberInt(30),
            "formaPagamento": "forma_xpto",
            "diaPagamento": NumberInt(7),
            "contato": "Contato financeiro",
            "telefone": "11989897878"
        },
        "comercial": {
            "email": "comercial@ferias.co",
            "contato": "Contato comercial",
            "telefone": "11989897547"
        },
        "planos": [
            {
                "_id": UUID("005d9991-e7c7-49ff-a617-fa3ce1bad9e5"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "90",
                "diarias": 4,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 123,
                    "coparticipacao": "10"
                },
                "vigencia": ISODate("2021-01-29T19:27:36.980Z"),
                "ativo": true
            }
        ],
        "ativo": true,
        "dataCriacao": ISODate("2020-01-29T19:27:36.980Z"),
        "dataAtualizacao": null,
        "dataDelecao": null,
        "alias": "84008569000193"
    },
    {
        "_id": ObjectId("5e3493ded9bc8f0001e207a4"),
        "id": "04224173000144",
        "nomeFantasia": "Beit Yaacov",
        "razaoSocial": "Escola Beit Yaacov",
        "segmento": "Outros",
        "site": "www.beityaacov.com.br",
        "tipo": "Cliente",
        "empresaProprietariaId": "04224173000144",
        "centroCusto": "",
        "gruposOrganizacionais": [],
        "documentos": [
            {
                "tipo": "CNPJ",
                "numero": "04224173000144"
            }
        ],
        "cobranca": {
            "emailAlternativo": "",
            "cobrancaAutomatica": true,
            "faturarMesFechado": false,
            "diaInicial": null,
            "diaFinal": null
        },
        "responsavel": {
            "nome": "Cinthia Ferreira dos Santos",
            "email": "cinthia.santos@beityaacov.com.br",
            "telefone": "1136126150",
            "celular": "11999999999"
        },
        "endereco": {
            "logradouro": "Av. Marques de São Vicente",
            "numero": "1478",
            "complemento": "",
            "bairro": "Barra Funda",
            "cidade": "São Paulo",
            "estado": "SP",
            "cep": "01139002",
            "pais": "BR"
        },
        "financeiro": {
            "email": "financeiro@beityaacov.com.br",
            "prazoPagamento": NumberInt(30),
            "formaPagamento": "forma_xpto",
            "diaPagamento": NumberInt(7),
            "contato": "Contato financeiro",
            "telefone": "11989897878"
        },
        "comercial": {
            "email": "comercial@beityaacov.com.br",
            "contato": "Contato comercial",
            "telefone": "11989897547"
        },
        "planos": [
            {
                "_id": UUID("005d9991-e7c7-49ff-a617-fa3ce1bad9e5"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "90",
                "diarias": 4,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "60"
                },
                "vigencia": ISODate("2021-01-31T20:53:50.829Z"),
                "ativo": true
            }
        ],
        "ativo": true,
        "dataCriacao": ISODate("2020-01-31T20:53:50.829Z"),
        "dataAtualizacao": null,
        "dataDelecao": null,
        "alias": "04224173000144"
    },
    {
        "_id": ObjectId("5e39a943d9bc8f0001e207a6"),
        "id": "50545036000129",
        "nomeFantasia": "ABB Brasil 1",
        "razaoSocial": "teste integração 1",
        "segmento": "Indústria",
        "site": "site.com",
        "tipo": "Cliente",
        "empresaProprietariaId": "50545036000129",
        "centroCusto": "",
        "gruposOrganizacionais": [],
        "documentos": [
            {
                "tipo": "CNPJ",
                "numero": "50545036000129"
            }
        ],
        "cobranca": {
            "emailAlternativo": "",
            "cobrancaAutomatica": true,
            "faturarMesFechado": false,
            "diaInicial": null,
            "diaFinal": null
        },
        "responsavel": {
            "nome": "Patricia Galante",
            "email": "teste@email.com",
            "telefone": "1912344321",
            "celular": null
        },
        "endereco": {
            "logradouro": "rua",
            "numero": "1",
            "complemento": "C",
            "bairro": "bairro",
            "cidade": "Mogi Mirim",
            "estado": "SP",
            "cep": "13800033",
            "pais": "BR"
        },
        "financeiro": {
            "email": "financeiro@email.com.br",
            "prazoPagamento": NumberInt(30),
            "formaPagamento": "forma_xpto",
            "diaPagamento": NumberInt(7),
            "contato": "Contato financeiro",
            "telefone": "11989897878"
        },
        "comercial": {
            "email": "comercial@email.com.br",
            "contato": "Contato comercial",
            "telefone": "11989897547"
        },
        "planos": [
            {
                "_id": UUID("005d9991-e7c7-49ff-a617-fa3ce1bad9e5"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "90",
                "diarias": 4,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216",
                "billing": {
                    "formaPagamento": "boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2021-02-04T17:26:27.398Z"),
                "ativo": true
            }
        ],
        "ativo": true,
        "dataCriacao": ISODate("2020-02-04T17:26:27.398Z"),
        "dataAtualizacao": null,
        "dataDelecao": null,
        "alias": "50545036000129"
    },
    {
        "_id": ObjectId("5e3ab1f5d9bc8f0001e207a7"),
        "id": "11701789000124",
        "nomeFantasia": "ABB Brasil 2",
        "razaoSocial": "TESTE INTEGRAÇÃO 2",
        "segmento": "Indústria",
        "site": "site.com",
        "tipo": "Cliente",
        "empresaProprietariaId": "11701789000124",
        "centroCusto": "",
        "gruposOrganizacionais": [],
        "documentos": [
            {
                "tipo": "CNPJ",
                "numero": "11701789000124"
            }
        ],
        "cobranca": {
            "emailAlternativo": "",
            "cobrancaAutomatica": true,
            "faturarMesFechado": false,
            "diaInicial": null,
            "diaFinal": null
        },
        "responsavel": {
            "nome": "Patricia Galante",
            "email": "teste@teste.com",
            "telefone": "1912344321",
            "celular": null
        },
        "endereco": {
            "logradouro": "Padre Roque",
            "numero": "Pendente",
            "complemento": "Pendente",
            "bairro": "Pendente",
            "cidade": "Mogi Mirim",
            "estado": "SP",
            "cep": "13800033",
            "pais": "BR"
        },
        "financeiro": {
            "email": "financeiro@teste.com",
            "prazoPagamento": NumberInt(30),
            "formaPagamento": "forma_xpto",
            "diaPagamento": NumberInt(7),
            "contato": "Contato financeiro",
            "telefone": "11989897878"
        },
        "comercial": {
            "email": "comercial@teste.com",
            "contato": "Contato comercial",
            "telefone": "11989897547"
        },
        "planos": [
            {
                "_id": UUID("005d9991-e7c7-49ff-a617-fa3ce1bad9e5"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "90",
                "diarias": 4,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216",
                "billing": {
                    "formaPagamento": "Boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "10"
                },
                "vigencia": ISODate("2021-02-05T12:15:49.374Z"),
                "ativo": true
            }
        ],
        "ativo": true,
        "dataCriacao": ISODate("2020-02-05T12:15:49.374Z"),
        "dataAtualizacao": null,
        "dataDelecao": null,
        "alias": "11701789000124"
    },
    {
        "_id": ObjectId("5e3c5db3d9bc8f0001e207f2"),
        "id": "18633234000131",
        "nomeFantasia": "Integração teste 3",
        "razaoSocial": "TESTE INTEGRAÇÃO 3",
        "segmento": "Varejo",
        "site": "testesite.com",
        "tipo": "Cliente",
        "empresaProprietariaId": "18633234000131",
        "centroCusto": "",
        "gruposOrganizacionais": [],
        "documentos": [
            {
                "tipo": "CNPJ",
                "numero": "18633234000131"
            }
        ],
        "cobranca": {
            "emailAlternativo": "",
            "cobrancaAutomatica": true,
            "faturarMesFechado": false,
            "diaInicial": null,
            "diaFinal": null
        },
        "responsavel": {
            "nome": "Contato Teste Integração",
            "email": "contato@teste.com",
            "telefone": "1912344321",
            "celular": "19943211234"
        },
        "endereco": {
            "logradouro": "Rua Padre Roque",
            "numero": "0",
            "complemento": "",
            "bairro": "bairro",
            "cidade": "Mogi Mirim",
            "estado": "SP",
            "cep": "13800033",
            "pais": "BR"
        },
        "financeiro": {
            "email": "financeiro@teste.com",
            "prazoPagamento": NumberInt(30),
            "formaPagamento": "forma_xpto",
            "diaPagamento": NumberInt(7),
            "contato": "Contato financeiro",
            "telefone": "11989897878"
        },
        "comercial": {
            "email": "comercial@teste.com",
            "contato": "Contato comercial",
            "telefone": "11989897547"
        },
        "planos": [
            {
                "_id": UUID("005d9991-e7c7-49ff-a617-fa3ce1bad9e5"),
                "titulo": "Hotéis de 3 e 4 estrelas",
                "tipoPlano": "Padrão",
                "valorPlano": "90",
                "diarias": 4,
                "valorDiariaMinima": "0.01",
                "valorDiariaMaxima": "216",
                "billing": {
                    "formaPagamento": "Boleto",
                    "valorTotalAtual": "0",
                    "totalAssinantes": 0,
                    "totalColaboradores": 50,
                    "coparticipacao": "0"
                },
                "vigencia": ISODate("2021-02-06T18:40:51.011Z"),
                "ativo": true
            }
        ],
        "ativo": true,
        "dataCriacao": ISODate("2020-02-06T18:40:51.011Z"),
        "dataAtualizacao": null,
        "dataDelecao": null,
        "alias": "18633234000131"
    }
])

db.getSiblingDB('plano').getCollection('planos').insert([
    {
        "_id": ObjectId("5e4c494e8441081a9bf4b164"),
        "id": UUID("005d9991-e7c7-49ff-a617-fa3ce1bad9e5"),
        "titulo": "Hotéis de 3 e 4 estrelas",
        "tipoPlano": "Padrão",
        "valorPlano": "90.00",
        "diarias": 4,
        "valorDiariaMinima": "0.01",
        "valorDiariaMaxima": "216.00",
        "vigencia": ISODate("2021-09-28T00:00:00Z"),
        "ativo": true,
        "dataCriacao": ISODate("2019-12-03T14:05:35.519Z"),
        "dataAtualizacao": null,
        "dataDelecao": null,
        "billing": {
            "parcelas": 12,
            "valorTotalAnual": "1080.00",
            "receitaPorDiaria": "270.00",
            "custoPorcentual": "0.8",
            "reajustePorcentual": "0.05"
        }
    }
])
