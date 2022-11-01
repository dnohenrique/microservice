/* eslint-disable */
db.getSiblingDB('financeiro').getCollection('contas_receber').insert([
    /* 1 */
    {
        "_id": ObjectId("5f0381d2063143075c3b0c50"),
        "id": UUID("01ab783d-872c-4506-91fc-555bc879ccda"),
        "metaData": {
            "ativo": true,
            "dataCriacao": ISODate("2020-07-06T19:56:01.005Z"),
            "dataAtualizacao": null,
            "dataDelecao": null
        },
        "titular": "Bernardo e Mateus Telecomunicações Ltda",
        "identificadorFiscal": "66099165000170",
        "valorNominal": NumberDecimal("2000"),
        "recebimentos":
            [
                {
                    "recebimentoId": UUID("193e9a55-6ff2-4293-abb2-476f130bec34"),
                    "billId": null,
                    "billItemId": null,
                    "chargeId": 123,
                    "dataRecebimento": "2020-12-20T15:45:01.472Z",
                    "dataVencimento": "2020-12-20T15:45:01.472Z",
                    "dataEmissao": "2020-12-20T15:45:01.472Z",
                    "dataCancelamento": null,
                    "juros": null,
                    "multa": null,
                    "desconto": null,
                    "valorNominal": 123,
                    "valorRecebido": 123,
                    "formaRecebimento": "Boleto",
                    "situacao": "PENDENTE"
                },
                {
                    "recebimentoId": UUID("ccd5584c-6e31-44d6-89d5-225033e322af"),
                    "billId": null,
                    "billItemId": null,
                    "chargeId": 657,
                    "dataRecebimento": null,
                    "dataVencimento": "2021-01-20T15:45:01.472Z",
                    "dataEmissao": null,
                    "dataCancelamento": null,
                    "juros": null,
                    "multa": null,
                    "desconto": null,
                    "valorNominal": 123.12,
                    "valorRecebido": 123.12,
                    "formaRecebimento": "Boleto",
                    "situacao": "PENDENTE"
                }
            ]
    },
    {
        "_id" : ObjectId("5f43d3045b6bdd00013ca046"),
        "id" : UUID("3270070a-f376-4d32-b613-dc50943b258c"),
        "metaData" : {
            "ativo" : true,
            "dataCriacao" : ISODate("2020-08-24T14:47:32.943Z"),
            "dataAtualizacao" : ISODate("2020-08-24T14:47:45.179Z"),
            "dataDelecao" : null
        },
        "titular" : "VISIONFLEX SOLUCOES GRAFICAS LTDA",
        "identificadorFiscal" : "04020662000184",
        "valorNominal" : NumberDecimal("990"),
        "recebimentos" : [ 
            {
                "recebimentoId" : UUID("9a73e153-aa3c-4c1d-be58-885ad1661741"),
                "billId" : 65478963,
                "billItemId" : 124579,
                "chargeId" : 5489658,
                "dataRecebimento" : ISODate("2020-08-23T03:01:00.000Z"),
                "dataVencimento" : ISODate("2020-09-23T03:01:00.000Z"),
                "dataEmissao" : ISODate("2020-10-23T03:01:00.000Z"),
                "dataCancelamento" : null,
                "juros" : null,
                "multa" : null,
                "desconto" : null,
                "valorNominal" : NumberDecimal("990"),
                "valorRecebido" : NumberDecimal("900"),
                "formaRecebimento" : "boleto",
                "situacao" : "PARCIALMENTE_RECEBIDO"
            }
        ]
    },
    {
        "_id" : ObjectId("5f451782ac515a0001c75fb4"),
        "id" : UUID("dd84eabe-78da-44de-94db-b17dd44b723f"),
        "metaData" : {
            "ativo" : true,
            "dataCriacao" : ISODate("2020-08-25T13:52:02.602Z"),
            "dataAtualizacao" : ISODate("2020-08-25T13:52:13.192Z"),
            "dataDelecao" : null
        },
        "titular" : "P16 TELECOM LTDA",
        "identificadorFiscal" : "31445249000134",
        "valorNominal" : NumberDecimal("120"),
        "recebimentos" : [ 
            {
                "recebimentoId" : UUID("fcfd83fc-2eae-4480-baf7-24184eea25a8"),
                "billId" : 9874523,
                "billItemId" : 4567785,
                "chargeId" : 548963,
                "dataRecebimento" : null,
                "dataVencimento" : ISODate("2020-09-24T03:01:00.000Z"),
                "dataEmissao" : ISODate("2020-08-24T03:01:00.000Z"),
                "dataCancelamento" : null,
                "juros" : null,
                "multa" : null,
                "desconto" : null,
                "valorNominal" : NumberDecimal("60"),
                "valorRecebido" : null,
                "formaRecebimento" : "boleto",
                "situacao" : "EMITIDO"
            }, 
            {
                "recebimentoId" : UUID("ff7f7abd-d8fd-41d8-93ba-12a0f3b5c50f"),
                "billId" : 754156,
                "billItemId" : 365848,
                "chargeId" : 231475,
                "dataRecebimento" : null,
                "dataVencimento" : ISODate("2020-10-24T03:01:00.000Z"),
                "dataEmissao" : ISODate("2020-08-24T03:01:00.000Z"),
                "dataCancelamento" : null,
                "juros" : null,
                "multa" : null,
                "desconto" : null,
                "valorNominal" : NumberDecimal("60"),
                "valorRecebido" : null,
                "formaRecebimento" : "boleto",
                "situacao" : "EMITIDO"
            }
        ]
    }
])