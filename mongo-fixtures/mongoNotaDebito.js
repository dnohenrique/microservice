/* eslint-disable */
db.getSiblingDB('financeiro').getCollection('nota_debito').insert([
    {
        "_id" : ObjectId("5f1e1bcf5325b50001fa6efc"),
        "id" : UUID("07c50f19-2307-44db-9d9e-b35977a08927"),
        "metaData" : {
            "ativo" : true,
            "dataCriacao" : ISODate("2020-07-27T00:11:59.605Z"),
            "dataAtualizacao" : ISODate("2020-07-27T00:12:10.902Z"),
            "dataDelecao" : null
        },
        "contaReceberId": UUID("01ab783d-872c-4506-91fc-555bc879ccda"),
        "numero" : 1,
        "titular" : "Bmb Mode Center Indústria, Comércio e Serviços LTDA",
        "documento" : "04532167000154",
        "valorDesconto" : NumberDecimal("0"),
        "valorNominal" : NumberDecimal("180"),
        "dataEmissao" : ISODate("2020-07-27T00:11:59.602Z"),
        "dadosReferencia": {
            "endereco": "Rua Paraguassu, 8424 - Vila Firmiano Pinto",
            "cep": "05006011",
            "email": "treinamento@julianaeanalucasanoturnaltda.com.br",
            "referencia": ISODate("2020-08-13T18:25:39.209Z"),
        },
        "informacoes" : {
            "descricao" : "Recebimento de valores relativos a Assinatura anual dos Planos dos colaboradores referente ao período de 01/01 a 31/01/2020.",
            "observacoes" : "O pagamento desta Nota de Débito deverá ser realizado por boleto bancário enviado ao responsável por e-mail, assim como o Relatório de Assinaturas do período mencionado. Caso não tenham recebido, pedimos a gentileza de entrar em contato conosco pelo e-mail financeiro@ferias.co. A cobrança desta Nota de Débito será efetuada em duas parcelas: R$ 1.340,00 com Vencimento em 01/07/2020 e R$ 1.380,00 com Vencimento em 30/08/2020."
        },
        "condicoesPagamento" : [ 
            {
                "diasVencimento" : 30
            }
        ],
        "periodo" : {
            "de" : ISODate("2020-05-02T03:01:00.000Z"),
            "ate" : ISODate("2020-06-01T03:01:00.000Z")
        },
        "enviada" : false,
        "dataEnvio" : null,
        "situacao" : "EMITIDA",
        "dataCancelamento" : null
    },
    {
        "_id" : ObjectId("5f43d304a6dead0001c94a5c"),
        "id" : UUID("9fffd9b0-cc3d-4d92-b8f5-a209116f803f"),
        "metaData" : {
            "ativo" : true,
            "dataCriacao" : ISODate("2020-08-24T14:47:32.817Z"),
            "dataAtualizacao" : ISODate("2020-08-24T14:47:45.236Z"),
            "dataDelecao" : null
        },
        "contaReceberId": UUID("3270070a-f376-4d32-b613-dc50943b258c"),
        "numero" : 2,
        "titular" : "VISIONFLEX SOLUCOES GRAFICAS LTDA",
        "documento" : "04020662000184",
        "valorDesconto" : NumberDecimal("0"),
        "valorNominal" : NumberDecimal("990"),
        "dataEmissao" : ISODate("2020-08-24T03:01:00.000Z"),
        "dadosReferencia" : {
            "endereco" : "Rua Abílio Borin, 35 Portão 1 - Paulista - São Paulo / SP",
            "cep" : "04729030",
            "email" : "rh@visionflex.com.br",
            "referencia" : ISODate("2020-08-24T03:01:00.000Z")
        },
        "informacoes" : {
            "descricao" : "Recebimento de valores relativos a Assinatura anual dos Planos dos colaboradores referente ao período de 01/01 a 31/01/2020.",
            "observacoes" : "O pagamento desta Nota de Débito deverá ser realizado por boleto bancário enviado ao responsável por e-mail, assim como o Relatório de Assinaturas do período mencionado. Caso não tenham recebido, pedimos a gentileza de entrar em contato conosco pelo e-mail financeiro@ferias.co. O pagamento desta Nota de Débito deverá ser realizado por boleto bancário enviado ao responsável por e-mail, assim como o Relatório de Assinaturas do período mencionado."
        },
        "condicoesPagamento" : [ 
            {
                "diasVencimento" : 30
            }
        ],
        "periodo" : {
            "de" : ISODate("2020-05-01T03:01:00.000Z"),
            "ate" : ISODate("2020-05-31T03:01:00.000Z")
        },
        "enviada" : false,
        "dataEnvio" : null,
        "situacao" : "EMITIDA",
        "dataCancelamento" : null
    },
    {
        "_id" : ObjectId("5f4517827faf430001495e9d"),
        "id" : UUID("7b9e2026-b5fb-4e3d-96e8-d7aa69fcb617"),
        "metaData" : {
            "ativo" : true,
            "dataCriacao" : ISODate("2020-08-25T13:52:02.510Z"),
            "dataAtualizacao" : ISODate("2020-08-25T13:52:13.247Z"),
            "dataDelecao" : null
        },
        "contaReceberId": UUID("dd84eabe-78da-44de-94db-b17dd44b723f"),
        "numero" : 3,
        "titular" : "P16 TELECOM LTDA",
        "documento" : "31445249000134",
        "valorDesconto" : NumberDecimal("0"),
        "valorNominal" : NumberDecimal("120"),
        "dataEmissao" : ISODate("2020-08-25T03:01:00.000Z"),
        "dadosReferencia" : {
            "endereco" : "AV. Presidente vargas, 387 - Jd. Califórnia - Ribeirão Preto / SP",
            "cep" : "14020260",
            "email" : "ascatena@weclix.com.br",
            "referencia" : ISODate("2020-08-25T03:01:00.000Z")
        },
        "informacoes" : {
            "descricao" : "Recebimento de valores relativos a Assinatura anual dos Planos dos colaboradores referente ao período de 01/01 a 31/01/2020.",
            "observacoes" : "O pagamento desta Nota de Débito deverá ser realizado por boleto bancário enviado ao responsável por e-mail, assim como o Relatório de Assinaturas do período mencionado. Caso não tenham recebido, pedimos a gentileza de entrar em contato conosco pelo e-mail financeiro@ferias.co. O pagamento desta Nota de Débito deverá ser realizado por boleto bancário enviado ao responsável por e-mail, assim como o Relatório de Assinaturas do período mencionado."
        },
        "condicoesPagamento" : [ 
            {
                "diasVencimento" : 30
            }, 
            {
                "diasVencimento" : 60
            }
        ],
        "periodo" : {
            "de" : ISODate("2020-05-01T03:01:00.000Z"),
            "ate" : ISODate("2020-05-31T03:01:00.000Z")
        },
        "enviada" : false,
        "dataEnvio" : null,
        "situacao" : "EMITIDA",
        "dataCancelamento" : null
    }
]);

db.getSiblingDB('financeiro').getCollection('nota_debito_parametros').insert([{
    "_id": ObjectId("5ef6245206738ccf00058528"),
    "id": UUID("b13d6d9f-b23d-4138-9e65-a11156af6f5c"),
    "metaData": {
        "ativo": true,
        "dataCriacao": ISODate("2020-06-26T16:37:36.546Z"),
        "dataAtualizacao": null,
        "dataDelecao": null
    },
    "descricao": "Recebimento de valores relativos a Assinatura anual dos Planos dos colaboradores referente ao período de 01/01 a 31/01/2020.",
    "tipo": "descricao"
},
{
    "_id": ObjectId("5ef624c75a52ffcea83dfa2e"),
    "id": UUID("98e84059-75f7-496f-b3eb-de51a3038b90"),
    "metaData": {
        "ativo": true,
        "dataCriacao": ISODate("2020-06-26T16:39:33.880Z"),
        "dataAtualizacao": ISODate("2020-06-26T17:02:23.790Z"),
        "dataDelecao": null
    },
    "descricao": "O pagamento desta Nota de Débito deverá ser realizado por boleto bancário enviado ao responsável por e-mail, assim como o Relatório de Assinaturas do período mencionado. Caso não tenham recebido, pedimos a gentileza de entrar em contato conosco pelo e-mail financeiro@ferias.co. O pagamento desta Nota de Débito deverá ser realizado por boleto bancário enviado ao responsável por e-mail, assim como o Relatório de Assinaturas do período mencionado.",
    "tipo": "observacoes"
},
{
    "_id": ObjectId("5f0381d2063143075c3b0c50"),
    "id": UUID("a49cc5aa-8de6-4da6-b54e-761e3b674ed5"),
    "metaData": {
        "ativo": true,
        "dataCriacao": ISODate("2020-06-26T16:39:33.880Z"),
        "dataAtualizacao": ISODate("2020-06-26T17:02:23.790Z"),
        "dataDelecao": null
    },
    "descricao": "30",
    "tipo": "condicoes"
},
{
    "_id": ObjectId("5ef6399e01695aaba4dd6504"),
    "id": UUID("1c53ada8-0e0e-467e-bc54-1af0ee646a61"),
    "metaData": {
        "ativo": true,
        "dataCriacao": ISODate("2020-06-26T18:08:28.948Z"),
        "dataAtualizacao": null,
        "dataDelecao": null
    },
    "descricao": "60",
    "tipo": "condicoes"
}
]);