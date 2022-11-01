db.getSiblingDB('colaborador').getCollection('colaboradores').insert([
    {
        "_id" : ObjectId("5de1a46c20b0ae0001fde6c6"),
        "id" : "22301591867",
        "nome" : "Camilo Teixeira de Melo",
        "dataNascimento" : ISODate("1981-11-12T00:00:00Z"),
        "cpf" : "22301591867",
        "celular" : "11922442244",
        "emailPessoal" : null,
        "empresas" : [
            {
                "_id" : "34008403000107",
                "nomeFantasia" : null,
                "razaoSocial" : null,
                "segmento" : null,
                "empresaProprietariaId" : "34008403000107",
                "site" : null,
                "tipo" : null,
                "coparticipacao" : "90",
                "ativo" : true,
                "centroCusto" : "Recursos Humanos",
                "grupoOrganizacional" : null,
                "cnpj" : "34008403000107",
                "colaboradorRh" : {
                    "telefone" : "3341597218",
                    "ramal" : "799",
                    "emailCorporativo" : "leandro.santos@ferias.co",
                    "matricula" : "00000000001",
                    "descontoFolha" : true,
                    "cargo" : "Head de TI",
                    "area" : "Tecnologia",
                    "departamento" : "TI",
                    "coparticipacao" : null
                },
                "dataCriacao" : ISODate("2019-11-29T23:06:20.774Z"),
                "dataAtualizacao" : null,
                "dataDelecao" : null
            }
        ],
        "planos" : [
            {
                "_id" : UUID("0882d661-bcf4-4353-9cba-8df606441f20"),
                "empresaId" : "34008403000107",
                "titulo" : "Padrão 14 Diárias",
                "tipoPlano" : "Padrão",
                "valorPlano" : "317",
                "diariasTotais" : 14,
                "diariasDisponiveis" : 14,
                "valorDiariaMinima" : "0.01",
                "valorDiariaMaxima" : "216",
                "vigencia" : ISODate("2021-11-30T00:20:10.203Z"),
                "ativo" : true,
                "dataAdesao" : ISODate("2019-11-30T00:20:10.203Z"),
                "status" : "Ativo",
                "billing" : null,
                "fingerprint" : {
                    "timestamp" : ISODate("2019-11-30T00:20:10.220Z"),
                    "servidor" : "172.17.0.6",
                    "geolocalizacao" : "51.165691;10.451526",
                    "userAgent" : "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.120 Safari/537.36",
                    "ip" : "91.213.103.0",
                    "termoUso" : "Aqui esta o termo xpto",
                    "termoDesconto" : "Aqui esta o termo de desconto xpto"
                }
            }
        ],
        "dataCriacao" : ISODate("2019-11-29T23:06:20.774Z"),
        "dataAtualizacao" : ISODate("2020-05-12T20:44:47.990Z"),
        "dataDelecao" : null,
        "endereco" : null,
        "aceitaContatoWhatsapp" : false,
        "carteira" : {
            "pontos" : {
                "saldo" : NumberDecimal("0"),
                "quantidadePendente" : NumberDecimal("0"),
                "pontosAcumulados" : [ ],
                "historicoTransacaoPontos" : [ ]
            },
            "diarias" : {
                "historicoTransacaoDiarias" : [ ]
            }
        }
    },
    {
        "_id" : ObjectId("5de1a46e20b0ae0001fde6c7"),
        "id" : "54005010016",
        "nome" : "Leandro Santos",
        "dataNascimento" : ISODate("1981-11-12T00:00:00Z"),
        "cpf" : "54005010016",
        "celular" : "11922442244",
        "emailPessoal" : null,
        "empresas" : [
            {
                "_id" : "15696589000181",
                "nomeFantasia" : null,
                "razaoSocial" : null,
                "segmento" : null,
                "empresaProprietariaId" : "10782454000204",
                "site" : null,
                "tipo" : null,
                "coparticipacao" : "90",
                "ativo" : true,
                "centroCusto" : "Recursos Humanos",
                "grupoOrganizacional" : null,
                "cnpj" : "15696589000181",
                "colaboradorRh" : {
                    "telefone" : "3341597218",
                    "ramal" : "799",
                    "emailCorporativo" : "leandro.santos@ferias.co",
                    "matricula" : "00000000001",
                    "descontoFolha" : true,
                    "cargo" : "Head de TI",
                    "area" : "Tecnologia",
                    "departamento" : "TI",
                    "coparticipacao" : null
                },
                "dataCriacao" : ISODate("2019-11-29T23:06:22.496Z"),
                "dataAtualizacao" : null,
                "dataDelecao" : null
            }
        ],
        "planos" : [
            {
                "_id" : UUID("0882d661-bcf4-4353-9cba-8df606441f20"),
                "empresaId" : "15696589000181",
                "titulo" : "Padrão 14 Diárias",
                "tipoPlano" : "Padrão",
                "valorPlano" : "317",
                "diariasTotais" : 14,
                "diariasDisponiveis" : 14,
                "valorDiariaMinima" : "0.01",
                "valorDiariaMaxima" : "216",
                "vigencia" : ISODate("2021-11-30T00:20:13.825Z"),
                "ativo" : true,
                "dataAdesao" : ISODate("2019-11-30T00:20:13.825Z"),
                "status" : "Ativo",
                "billing" : null,
                "fingerprint" : {
                    "timestamp" : ISODate("2019-11-30T00:20:13.847Z"),
                    "servidor" : "172.17.0.6",
                    "geolocalizacao" : "51.165691;10.451526",
                    "userAgent" : "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.120 Safari/537.36",
                    "ip" : "91.213.103.0",
                    "termoUso" : "Aqui esta o termo xpto",
                    "termoDesconto" : "Aqui esta o termo de desconto xpto"
                }
            }
        ],
        "dataCriacao" : ISODate("2019-11-29T23:06:22.496Z"),
        "dataAtualizacao" : ISODate("2020-05-12T19:48:16.013Z"),
        "dataDelecao" : null,
        "endereco" : null,
        "aceitaContatoWhatsapp" : false,
        "carteira" : {
            "pontos" : {
                "saldo" : NumberDecimal("0"),
                "quantidadePendente" : NumberDecimal("0"),
                "pontosAcumulados" : [ ],
                "historicoTransacaoPontos" : [ ]
            },
            "diarias" : {
                "historicoTransacaoDiarias" : [ ]
            }
        }
    }
])
