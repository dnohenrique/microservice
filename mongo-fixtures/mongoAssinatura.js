/* eslint-disable */
db.getSiblingDB('financeiro').getCollection('assinatura').insert([
	//Razao social: VISIONFLEX SOLUCOES GRAFICAS LTDA
	/* 1 */
	{
		"_id" : ObjectId("5efaa0dbaf918e5e40e575cc"),
		"id" : UUID("87d71f27-7cda-e271-4329-9d62c1458031"),
		"titular" : "José da silva",
		"documentoAssinante" : "23447868058",
		"documentoEmpresa" : "04020662000184",
		"emailAssinante" : "agcarraratestjload@ferias.co",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1.0,
		"parceladoEm" : 12.0,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : true,
		"parcelasPlano" : [ 
			{
				"parcela" : 1,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [ 
					{
						"idContaReceber" : UUID("3270070a-f376-4d32-b613-dc50943b258c"),
						"valorRecebido" : null
					}
				],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 2,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 3,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-08-24T14:47:33.054Z"),
			"dataDelecao" : null
		}
	},
	{
		"_id" : ObjectId("5f3576e34b03dd11fe97f1ea"),
		"id" : UUID("c6c7f10d-b5f5-454e-94c1-f726ebb81b6b"),
		"titular" : "Diego Samuel Bento Carvalho",
		"documentoAssinante" : "30399501185",
		"documentoEmpresa" : "04020662000184",
		"emailAssinante" : "diegosamuelbentocarvalho_@tglaw.com.br",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1.0,
		"parceladoEm" : 12.0,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : true,
		"parcelasPlano" : [ 
			{
				"parcela" : 1,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [ 
					{
						"idContaReceber" : UUID("3270070a-f376-4d32-b613-dc50943b258c"),
						"valorRecebido" : null
					}
				],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 2,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 3,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-08-24T14:47:33.134Z"),
			"dataDelecao" : null
		}
	},
	{
		"_id" : ObjectId("5f35768c4b03dd11fe97f1e7"),
		"id" : UUID("b875b0ba-923e-46d6-a1d8-541518c66f7c"),
		"titular" : "Márcio Yuri Moura",
		"documentoAssinante" : "33468319061",
		"documentoEmpresa" : "04020662000184",
		"emailAssinante" : "marcioyurimoura_@tecvap.com.br",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1.0,
		"parceladoEm" : 12.0,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : true,
		"parcelasPlano" : [ 
			{
				"parcela" : 1,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [ 
					{
						"idContaReceber" : UUID("3270070a-f376-4d32-b613-dc50943b258c"),
						"valorRecebido" : null
					}
				],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 2,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 3,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-08-24T14:47:33.136Z"),
			"dataDelecao" : null
		}
	},
	{
		"_id" : ObjectId("5e4efb6636d3b472d8437d67"),
		"id" : UUID("7ec3967b-f3f5-4747-b828-ca365eff39b8"),
		"titular" : "Maria dos Santos",
		"documentoAssinante" : "43769498844",
		"documentoEmpresa" : "04020662000184",
		"emailAssinante" : "Santos@ferias.co",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1.0,
		"parceladoEm" : 12.0,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : true,
		"parcelasPlano" : [ 
			{
				"parcela" : 1,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [ 
					{
						"idContaReceber" : UUID("3270070a-f376-4d32-b613-dc50943b258c"),
						"valorRecebido" : null
					}
				],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 2,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 3,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-08-24T14:47:33.137Z"),
			"dataDelecao" : null
		}
	},
	{
		"_id" : ObjectId("5f35866d4b03dd11fe97f1eb"),
		"id" : UUID("3040eafd-aa38-4d66-99ed-f212065a184e"),
		"titular" : "Ryan Nelson Corte Real",
		"documentoAssinante" : "13930249553",
		"documentoEmpresa" : "04020662000184",
		"emailAssinante" : "ryannelsoncortereal-94@brunofaria.com",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1.0,
		"parceladoEm" : 12.0,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : true,
		"parcelasPlano" : [ 
			{
				"parcela" : 1,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [ 
					{
						"idContaReceber" : UUID("3270070a-f376-4d32-b613-dc50943b258c"),
						"valorRecebido" : null
					}
				],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 2,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 3,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-08-24T14:47:33.139Z"),
			"dataDelecao" : null
		}
	},
	{
		"_id" : ObjectId("5f3586b04b03dd11fe97f1ec"),
		"id" : UUID("d0b848c8-985a-482a-b2d2-01bc9ad4fed8"),
		"titular" : "Elias Luís Farias",
		"documentoAssinante" : "02512903796",
		"documentoEmpresa" : "04020662000184",
		"emailAssinante" : "eliasluisfarias..eliasluisfarias@anac.gov.br",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1.0,
		"parceladoEm" : 12.0,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : true,
		"parcelasPlano" : [ 
			{
				"parcela" : 1,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [ 
					{
						"idContaReceber" : UUID("3270070a-f376-4d32-b613-dc50943b258c"),
						"valorRecebido" : null
					}
				],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 2,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 3,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-08-24T14:47:33.141Z"),
			"dataDelecao" : null
		}
	},
	{
		"_id" : ObjectId("5f3586ee4b03dd11fe97f1ed"),
		"id" : UUID("7c45c46f-9873-4b78-af31-9c699593554c"),
		"titular" : "Márcia Isadora Fogaça",
		"documentoAssinante" : "32017928704",
		"documentoEmpresa" : "04020662000184",
		"emailAssinante" : "marciaisadorafogaca_@accent.com.br",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1.0,
		"parceladoEm" : 12.0,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : true,
		"parcelasPlano" : [ 
			{
				"parcela" : 1,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [ 
					{
						"idContaReceber" : UUID("3270070a-f376-4d32-b613-dc50943b258c"),
						"valorRecebido" : null
					}
				],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 2,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 3,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-08-24T14:47:33.143Z"),
			"dataDelecao" : null
		}
	},
	{
		"_id" : ObjectId("5f35872a4b03dd11fe97f1ee"),
		"id" : UUID("98e83c33-09a8-4017-a3a0-f71e04d1df84"),
		"titular" : "Oliver Henry Rezende",
		"documentoAssinante" : "47527700165",
		"documentoEmpresa" : "04020662000184",
		"emailAssinante" : "oliverhenryrezende-94@recnev.com.br",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1.0,
		"parceladoEm" : 12.0,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : true,
		"parcelasPlano" : [ 
			{
				"parcela" : 1,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [ 
					{
						"idContaReceber" : UUID("3270070a-f376-4d32-b613-dc50943b258c"),
						"valorRecebido" : null
					}
				],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 2,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 3,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-08-24T14:47:33.144Z"),
			"dataDelecao" : null
		}
	},
	{
		"_id" : ObjectId("5f3587764b03dd11fe97f1ef"),
		"id" : UUID("4ca809f7-a95e-4539-86d4-bf805ade2b7a"),
		"titular" : "Stella Silvana Peixoto",
		"documentoAssinante" : "77160869796",
		"documentoEmpresa" : "04020662000184",
		"emailAssinante" : "stellasilvanapeixoto..stellasilvanapeixoto@marmorariauchoa.com",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1.0,
		"parceladoEm" : 12.0,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : true,
		"parcelasPlano" : [ 
			{
				"parcela" : 1,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [ 
					{
						"idContaReceber" : UUID("3270070a-f376-4d32-b613-dc50943b258c"),
						"valorRecebido" : null
					}
				],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 2,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 3,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-08-24T14:47:33.146Z"),
			"dataDelecao" : null
		}
	},
	{
		"_id" : ObjectId("5f3587a94b03dd11fe97f1f0"),
		"id" : UUID("622be7fd-3ee8-485a-814f-a3b78a58445b"),
		"titular" : "Lucca Alexandre Bento Melo",
		"documentoAssinante" : "78999048543",
		"documentoEmpresa" : "04020662000184",
		"emailAssinante" : "luccaalexandrebentomelo_@bighost.com.br",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1.0,
		"parceladoEm" : 12.0,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : true,
		"parcelasPlano" : [ 
			{
				"parcela" : 1,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [ 
					{
						"idContaReceber" : UUID("3270070a-f376-4d32-b613-dc50943b258c"),
						"valorRecebido" : null
					}
				],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 2,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 3,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-08-24T14:47:33.148Z"),
			"dataDelecao" : null
		}
	},
	{
		"_id" : ObjectId("5f3587ee4b03dd11fe97f1f1"),
		"id" : UUID("265dfbf8-0f76-4c1a-bf42-f6358524ab0f"),
		"titular" : "Juliana Liz Freitas",
		"documentoAssinante" : "92474383573",
		"documentoEmpresa" : "04020662000184",
		"emailAssinante" : "julianalizfreitas-85@mpc.com.br",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1.0,
		"parceladoEm" : 12.0,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : true,
		"parcelasPlano" : [ 
			{
				"parcela" : 1,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [ 
					{
						"idContaReceber" : UUID("3270070a-f376-4d32-b613-dc50943b258c"),
						"valorRecebido" : null
					}
				],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 2,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}, 
			{
				"parcela" : 3,
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-08-24T14:47:33.149Z"),
			"dataDelecao" : null
		}
	},

	//Razao social: P16 TELECOM LTDA
	{
		"_id" : ObjectId("5e4efb84cdd3710001c81a18"),
		"id" : UUID("2f979287-645f-4b9a-b878-18735faa7962"),
		"titular" : "Arnaldo Pereira",
		"documentoAssinante" : "49789748957",
		"documentoEmpresa" : "31445249000134",
		"emailAssinante" : "Pereira@ferias.co",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1,
		"parceladoEm" : 12,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : false,
		"parcelasPlano" : [
			{
				"parcela" : NumberInt(1),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [
					{
						"idContaReceber" : UUID("dd84eabe-78da-44de-94db-b17dd44b723f"),
						"valorRecebido" : null
					}
				],
				"contasReceberCartaoDeCreditoPlano" : []
			},
			{
				"parcela" : NumberInt(2),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			},
			{
				"parcela" : NumberInt(3),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-07-03T05:35:47.002Z"),
			"dataDelecao" : null
		}
	},
	{
		"_id" : ObjectId("5e4f024d36d3b472d8443622"),
		"id" : UUID("66731ef2-c6ae-4ba4-8622-be1cdf568581"),
		"titular" : "Carlos Amaral",
		"documentoAssinante" : "56356364114",
		"documentoEmpresa" : "31445249000134",
		"emailAssinante" : "Pereira@ferias.co",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1,
		"parceladoEm" : 12,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : false,
		"parcelasPlano" : [
			{
				"parcela" : NumberInt(1),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [
					{
						"idContaReceber" : UUID("dd84eabe-78da-44de-94db-b17dd44b723f"),
						"valorRecebido" : null
					}
				],
				"contasReceberCartaoDeCreditoPlano" : []
			},
			{
				"parcela" : NumberInt(2),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			},
			{
				"parcela" : NumberInt(3),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-07-03T05:35:47.002Z"),
			"dataDelecao" : null
		}
	},

	//Razao social: Vision Band Solucoes em Impressao LTDA
	{
		"_id" : ObjectId("5e4fdec3cdd3710001c81a19"),
		"id" : UUID("116164ed-5b2d-48f0-9c3a-df9bad44b205"),
		"titular" : "Neide Ferreira",
		"documentoAssinante" : "77597642512",
		"documentoEmpresa" : "65069130000126",
		"emailAssinante" : "Ferreira@ferias.co",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1,
		"parceladoEm" : 12,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : true,
		"parcelasPlano" : [
			{
				"parcela" : NumberInt(1),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [
				],
				"contasReceberCartaoDeCreditoPlano" : []
			},
			{
				"parcela" : NumberInt(2),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			},
			{
				"parcela" : NumberInt(3),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-07-03T05:35:47.002Z"),
			"dataDelecao" : null
		}
	},
	{
		"_id" : ObjectId("5e4fe049cdd3710001c81a1a"),
		"id" : UUID("4b47e6be-9563-4c62-80fe-e7a191eb9776"),
		"titular" : "Flavia Camargo",
		"documentoAssinante" : "97226198100",
		"documentoEmpresa" : "65069130000126",
		"emailAssinante" : "Ferreira@ferias.co",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1,
		"parceladoEm" : 12,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : true,
		"parcelasPlano" : [
			{
				"parcela" : NumberInt(1),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [
				],
				"contasReceberCartaoDeCreditoPlano" : []
			},
			{
				"parcela" : NumberInt(2),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			},
			{
				"parcela" : NumberInt(3),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-07-03T05:35:47.002Z"),
			"dataDelecao" : null
		}
	},

	//Razao social: Tecnisa SA
	{
		"_id" : ObjectId("5e4fed42cdd3710001c81a1b"),
		"id" : UUID("ffd4d3ff-e347-4636-a095-b6cc162b5871"),
		"titular" : "Natan de Oliveira",
		"documentoAssinante" : "65722926736",
		"documentoEmpresa" : "08065557000112",
		"emailAssinante" : "Oliveira@ferias.co",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1,
		"parceladoEm" : 12,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : true,
		"parcelasPlano" : [
			{
				"parcela" : NumberInt(1),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [
				],
				"contasReceberCartaoDeCreditoPlano" : []
			},
			{
				"parcela" : NumberInt(2),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			},
			{
				"parcela" : NumberInt(3),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-07-03T05:35:47.002Z"),
			"dataDelecao" : null
		}
	},
	{
		"_id" : ObjectId("5e599475c22aee0f240fc5a1"),
		"id" : UUID("af06db4a-5e63-4542-897c-0a622b5a12bc"),
		"titular" : "Lucas Melo",
		"documentoAssinante" : "55357539553",
		"documentoEmpresa" : "08065557000112",
		"emailAssinante" : "Melo@ferias.co",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1,
		"parceladoEm" : 12,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : true,
		"parcelasPlano" : [
			{
				"parcela" : NumberInt(1),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [
				],
				"contasReceberCartaoDeCreditoPlano" : []
			},
			{
				"parcela" : NumberInt(2),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			},
			{
				"parcela" : NumberInt(3),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-07-03T05:35:47.002Z"),
			"dataDelecao" : null
		}
	},

	//Razao social: Bmb Mode Center
	{
		"_id" : ObjectId("5e599565c22aee48041aef17"),
		"id" : UUID("a12cb6fb-f127-45ea-bd9c-4dd26fa39a3b"),
		"titular" : "Joaquim Aparecido",
		"documentoAssinante" : "91587636948",
		"documentoEmpresa" : "04532167000154",
		"emailAssinante" : "Aparecido@ferias.co",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1,
		"parceladoEm" : 12,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : true,
		"parcelasPlano" : [
			{
				"parcela" : NumberInt(1),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [
				],
				"contasReceberCartaoDeCreditoPlano" : []
			},
			{
				"parcela" : NumberInt(2),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			},
			{
				"parcela" : NumberInt(3),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-07-03T05:35:47.002Z"),
			"dataDelecao" : null
		}
	},
	{
		"_id" : ObjectId("5e5999c5c22aee4698688c1d"),
		"id" : UUID("09f2d4ca-44a3-4841-9eef-461983fdf549"),
		"titular" : "Gustavo Silva",
		"documentoAssinante" : "35337563602",
		"documentoEmpresa" : "04532167000154",
		"emailAssinante" : "Silva@ferias.co",
		"dataAdesao" : ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia" : ISODate("2020-06-02T00:00:00.000Z"),
		"periodo" : 1,
		"parceladoEm" : 12,
		"valorRealTotal" : NumberDecimal("1080"),
		"valorRealMensal" : NumberDecimal("90"),
		"valorNominalParcela" : NumberDecimal("30"),
		"valorCoparticipacaoEmpresa" : NumberDecimal("60"),
		"idPlano" : "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano" : "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha" : true,
		"parcelasPlano" : [
			{
				"parcela" : NumberInt(1),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			},
			{
				"parcela" : NumberInt(2),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			},
			{
				"parcela" : NumberInt(3),
				"parcelaNotaDeDebitoFinalizada" : false,
				"mesReferencia" : ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano" : [],
				"contasReceberCartaoDeCreditoPlano" : []
			}
		],
		"info" : {
			"descricao" : "Adesão de um plano padrão",
			"observacoes" : "vazio"
		},
		"metadata" : {
			"ativo" : true,
			"dataCriacao" : ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao" : ISODate("2020-07-03T05:35:47.002Z"),
			"dataDelecao" : null
		}
	},

	//Razao social: Voe Com a Gente LTDA
	{
		"_id": ObjectId("5f358c1e4b03dd11fe97f1f2"),
		"id": UUID("21dc7802-4050-44db-befd-dc725476d91a"),
		"titular": "Oliver Henry Peixoto",
		"documentoAssinante": "54604839484",
		"documentoEmpresa": "70631694000140",
		"emailAssinante": "oliverhenrypeixoto__oliverhenrypeixoto@jci.com",
		"dataAdesao": ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia": ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia": ISODate("2020-06-02T00:00:00.000Z"),
		"periodo": 1,
		"parceladoEm": 12,
		"valorRealTotal": NumberDecimal("1080"),
		"valorRealMensal": NumberDecimal("90"),
		"valorNominalParcela": NumberDecimal("30"),
		"valorCoparticipacaoEmpresa": NumberDecimal("60"),
		"idPlano": "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano": "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha": true,
		"parcelasPlano": [
			{
				"parcela": NumberInt(1),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [
					{
						"idContaReceber": UUID("665e557f-a6ba-4646-bee7-288da0092553"),
						"valorRecebido": null
					}
				],
				"contasReceberCartaoDeCreditoPlano": []
			},
			{
				"parcela": NumberInt(2),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [],
				"contasReceberCartaoDeCreditoPlano": []
			},
			{
				"parcela": NumberInt(3),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [],
				"contasReceberCartaoDeCreditoPlano": []
			}
		],
		"info": {
			"descricao": "Adesão de um plano padrão",
			"observacoes": "vazio"
		},
		"metadata": {
			"ativo": true,
			"dataCriacao": ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao": ISODate("2020-07-03T05:35:47.002Z"),
			"dataDelecao": null
		}
	},

	//Razao social: Carllus Magnux
	{
		"_id": ObjectId("5f358c864b03dd11fe97f1f3"),
		"id": UUID("f7c96200-74ac-4698-a45b-b5fb0910b8e9"),
		"titular": "Edson Severino Leandro da Rosa",
		"documentoAssinante": "25593867399",
		"documentoEmpresa": "28274164000126",
		"emailAssinante": "edsonseverinoleandrodarosa_@elconsultoria.com.br",
		"dataAdesao": ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia": ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia": ISODate("2020-06-02T00:00:00.000Z"),
		"periodo": 1,
		"parceladoEm": 12,
		"valorRealTotal": NumberDecimal("1080"),
		"valorRealMensal": NumberDecimal("90"),
		"valorNominalParcela": NumberDecimal("30"),
		"valorCoparticipacaoEmpresa": NumberDecimal("60"),
		"idPlano": "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano": "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha": true,
		"parcelasPlano": [
			{
				"parcela": NumberInt(1),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [
					{
						"idContaReceber": UUID("665e557f-a6ba-4646-bee7-288da0092553"),
						"valorRecebido": null
					}
				],
				"contasReceberCartaoDeCreditoPlano": []
			},
			{
				"parcela": NumberInt(2),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [],
				"contasReceberCartaoDeCreditoPlano": []
			},
			{
				"parcela": NumberInt(3),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [],
				"contasReceberCartaoDeCreditoPlano": []
			}
		],
		"info": {
			"descricao": "Adesão de um plano padrão",
			"observacoes": "vazio"
		},
		"metadata": {
			"ativo": true,
			"dataCriacao": ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao": ISODate("2020-07-03T05:35:47.002Z"),
			"dataDelecao": null
		}
	},

	//Razao social: CAROL TESTE
	{
		"_id": ObjectId("5f358cd24b03dd11fe97f1f4"),
		"id": UUID("7176858f-b458-41d3-bd8e-d89e9cc7b0cd"),
		"titular": "Ian Giovanni Miguel Porto",
		"documentoAssinante": "22754912282",
		"documentoEmpresa": "84008569000193",
		"emailAssinante": "iangiovannimiguelporto-86@me.com.br",
		"dataAdesao": ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia": ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia": ISODate("2020-06-02T00:00:00.000Z"),
		"periodo": 1,
		"parceladoEm": 12,
		"valorRealTotal": NumberDecimal("1080"),
		"valorRealMensal": NumberDecimal("90"),
		"valorNominalParcela": NumberDecimal("30"),
		"valorCoparticipacaoEmpresa": NumberDecimal("60"),
		"idPlano": "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano": "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha": true,
		"parcelasPlano": [
			{
				"parcela": NumberInt(1),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [
				],
				"contasReceberCartaoDeCreditoPlano": []
			},
			{
				"parcela": NumberInt(2),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [],
				"contasReceberCartaoDeCreditoPlano": []
			},
			{
				"parcela": NumberInt(3),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [],
				"contasReceberCartaoDeCreditoPlano": []
			}
		],
		"info": {
			"descricao": "Adesão de um plano padrão",
			"observacoes": "vazio"
		},
		"metadata": {
			"ativo": true,
			"dataCriacao": ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao": ISODate("2020-07-03T05:35:47.002Z"),
			"dataDelecao": null
		}
	},

	//Razao social: Escola Beit Yaacov
	{
		"_id": ObjectId("5f358d164b03dd11fe97f1f5"),
		"id": UUID("7396b77d-49b0-4c31-aa2d-cd3b11a44867"),
		"titular": "Daiane Olivia Silveira",
		"documentoAssinante": "18376271342",
		"documentoEmpresa": "04224173000144",
		"emailAssinante": "daianeoliviasilveira..daianeoliviasilveira@tvglobo.com.br",
		"dataAdesao": ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia": ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia": ISODate("2020-06-02T00:00:00.000Z"),
		"periodo": 1,
		"parceladoEm": 12,
		"valorRealTotal": NumberDecimal("1080"),
		"valorRealMensal": NumberDecimal("90"),
		"valorNominalParcela": NumberDecimal("30"),
		"valorCoparticipacaoEmpresa": NumberDecimal("60"),
		"idPlano": "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano": "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha": true,
		"parcelasPlano": [
			{
				"parcela": NumberInt(1),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [
				],
				"contasReceberCartaoDeCreditoPlano": []
			},
			{
				"parcela": NumberInt(2),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [],
				"contasReceberCartaoDeCreditoPlano": []
			},
			{
				"parcela": NumberInt(3),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [],
				"contasReceberCartaoDeCreditoPlano": []
			}
		],
		"info": {
			"descricao": "Adesão de um plano padrão",
			"observacoes": "vazio"
		},
		"metadata": {
			"ativo": true,
			"dataCriacao": ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao": ISODate("2020-07-03T05:35:47.002Z"),
			"dataDelecao": null
		}
	},

	//Razao social: teste integracao 1
	{
		"_id": ObjectId("5f358d704b03dd11fe97f1f6"),
		"id": UUID("56d90ee2-f568-49b0-9600-bf401c818f82"),
		"titular": "Vitória Emanuelly Rezende",
		"documentoAssinante": "21993271244",
		"documentoEmpresa": "50545036000129",
		"emailAssinante": "vitoriaemanuellyrezende..vitoriaemanuellyrezende@andradecamara.com.br",
		"dataAdesao": ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia": ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia": ISODate("2020-06-02T00:00:00.000Z"),
		"periodo": 1,
		"parceladoEm": 12,
		"valorRealTotal": NumberDecimal("1080"),
		"valorRealMensal": NumberDecimal("90"),
		"valorNominalParcela": NumberDecimal("30"),
		"valorCoparticipacaoEmpresa": NumberDecimal("60"),
		"idPlano": "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano": "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha": true,
		"parcelasPlano": [
			{
				"parcela": NumberInt(1),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [
				],
				"contasReceberCartaoDeCreditoPlano": []
			},
			{
				"parcela": NumberInt(2),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [],
				"contasReceberCartaoDeCreditoPlano": []
			},
			{
				"parcela": NumberInt(3),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [],
				"contasReceberCartaoDeCreditoPlano": []
			}
		],
		"info": {
			"descricao": "Adesão de um plano padrão",
			"observacoes": "vazio"
		},
		"metadata": {
			"ativo": true,
			"dataCriacao": ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao": ISODate("2020-07-03T05:35:47.002Z"),
			"dataDelecao": null
		}
	},

	//Razao social: TESTE INTEGRACAO 2
	{
		"_id": ObjectId("5f358dfc4b03dd11fe97f1f7"),
		"id": UUID("a3569021-8b3c-41c3-8522-c919efa65e8f"),
		"titular": "Diego Emanuel Lorenzo Farias",
		"documentoAssinante": "92353567410",
		"documentoEmpresa": "11701789000124",
		"emailAssinante": "ddiegoemanuellorenzofarias@emitec.com.br",
		"dataAdesao": ISODate("2019-06-02T00:00:00.000Z"),
		"dataVigencia": ISODate("2020-06-02T00:00:00.000Z"),
		"dataLimiteRecorrencia": ISODate("2020-06-02T00:00:00.000Z"),
		"periodo": 1,
		"parceladoEm": 12,
		"valorRealTotal": NumberDecimal("1080"),
		"valorRealMensal": NumberDecimal("90"),
		"valorNominalParcela": NumberDecimal("30"),
		"valorCoparticipacaoEmpresa": NumberDecimal("60"),
		"idPlano": "005d9991-e7c7-49ff-a617-fa3ce1bad9e5",
		"tituloPlano": "Plano Padrão 4 Diárias",
		"ehDescontoEmFolha": true,
		"parcelasPlano": [
			{
				"parcela": NumberInt(1),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-06-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [
				],
				"contasReceberCartaoDeCreditoPlano": []
			},
			{
				"parcela": NumberInt(2),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-07-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [],
				"contasReceberCartaoDeCreditoPlano": []
			},
			{
				"parcela": NumberInt(3),
				"parcelaNotaDeDebitoFinalizada": false,
				"mesReferencia": ISODate("2020-08-01T00:00:00.000Z"),
				"contasReceberNotaDeDebitoPlano": [],
				"contasReceberCartaoDeCreditoPlano": []
			}
		],
		"info": {
			"descricao": "Adesão de um plano padrão",
			"observacoes": "vazio"
		},
		"metadata": {
			"ativo": true,
			"dataCriacao": ISODate("2020-06-29T23:18:02.000Z"),
			"dataAtualizacao": ISODate("2020-07-03T05:35:47.002Z"),
			"dataDelecao": null
		}
	},
])