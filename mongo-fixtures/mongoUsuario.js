db.getSiblingDB('usuario').getCollection('usuarios').insert([
  {
    "_id" : ObjectId("5dee84675b109b0001f9ae34"),
    "id" : UUID("b2687742-0b91-4602-8055-4a7c85f212a2"),
    "nome" : "Thanos Esmaga",
    "email" : "qa@ferias.co",
    "cpf" : "64949575015",
    "documentoProprietario" : [
      {
        "Tipo" : "CNPJ",
        "Numero" : "79918271000180"
      }
    ],
    "ativo" : true,
    "dataCriacao" : ISODate("2019-12-09T17:29:11.925Z"),
    "dataAtualizacao" : ISODate("2020-05-14T14:04:01.756Z"),
    "dataDelecao" : null,
    "usuario" : "64949575015",
    "perfis" : [
      {
        "_id" : UUID("23bcebd9-4011-4f05-91c8-fb329ba9aac1"),
        "nome" : "rh",
        "permissoes" : [
          {
            "recurso" : {
              "nome" : "Rh",
              "frn" : "frn:rh::*"
            },
            "visualizar" : true,
            "inserir" : true,
            "editar" : true,
            "deletar" : true
          }
        ]
      },
      {
        "_id" : UUID("23bcebd9-4011-4f05-91c8-fb329ba9aac1"),
        "nome" : "colaborador",
        "permissoes" : [
          {
            "recurso" : {
              "nome" : "colaborador",
              "frn" : "frn:colaborador::*"
            },
            "visualizar" : true,
            "inserir" : true,
            "editar" : true,
            "deletar" : true
          }
        ]
      },
      {
        "_id" : UUID("23bcebd9-4011-4f05-91c8-fb329ba9aac1"),
        "nome" : "backoffice",
        "permissoes" : [
          {
            "recurso" : {
              "nome" : "Backoffice",
              "frn" : "frn:backoffice::*"
            },
            "visualizar" : true,
            "inserir" : true,
            "editar" : true,
            "deletar" : true
          }
        ]
      }
    ],
    "senha" : "89AC7FA9AFF638E2636ABC4AD935B916EDC140E225441FBF1CAF97FDFC9FDECB77F80A351ABE2237EDE4D1363869C6520D8840DB816E32CA4ECD76CDAD0E3DC6",
    "forcarAtualizarSenha" : false,
    "dataConfirmacaoEmail" : ISODate("2019-12-09T17:49:30.595Z")
  }
])

db.getSiblingDB('perfil').getCollection('perfis').insert([
  {
    "_id" : ObjectId("5de7d198f4f7ea00014f592f"),
    "id" : UUID("1b60cc12-e782-483f-8871-1b50064e00a0"),
    "nome" : "lead",
    "ativo" : true,
    "dataCriacao" : ISODate("2019-12-04T15:32:40.806Z"),
    "dataAtualizacao" : null,
    "dataDelecao" : null,
    "permissoes" : [
      {
        "recurso" : {
          "nome" : "Hotsite",
          "frn" : "frn:hotsite::*"
        },
        "visualizar" : true,
        "inserir" : false,
        "editar" : true,
        "deletar" : false
      }
    ]
  },
  {
    "_id" : ObjectId("5de7d199f4f7ea00014f5930"),
    "id" : UUID("210ce4a4-cf98-4ef7-9508-2e2a1976344b"),
    "nome" : "rh",
    "ativo" : true,
    "dataCriacao" : ISODate("2019-12-04T15:32:41.032Z"),
    "dataAtualizacao" : null,
    "dataDelecao" : null,
    "permissoes" : [
      {
        "recurso" : {
          "nome" : "Portal do RH",
          "frn" : "frn:rh::*"
        },
        "visualizar" : true,
        "inserir" : false,
        "editar" : true,
        "deletar" : false
      }
    ]
  },
  {
    "_id" : ObjectId("5de7d199f4f7ea00014f5931"),
    "id" : UUID("888cbaac-814c-4b7f-9882-9752a5bc0bd9"),
    "nome" : "colaborador",
    "ativo" : true,
    "dataCriacao" : ISODate("2019-12-04T15:32:41.087Z"),
    "dataAtualizacao" : null,
    "dataDelecao" : null,
    "permissoes" : [
      {
        "recurso" : {
          "nome" : "Portal do Colaborador",
          "frn" : "frn:colaborador::*"
        },
        "visualizar" : true,
        "inserir" : false,
        "editar" : true,
        "deletar" : false
      }
    ]
  },
  {
    "_id" : ObjectId("5de7d199f4f7ea00014f5932"),
    "id" : UUID("952e24b5-5347-4164-b081-bb32062c4444"),
    "nome" : "backoffice",
    "ativo" : true,
    "dataCriacao" : ISODate("2019-12-04T15:32:41.751Z"),
    "dataAtualizacao" : null,
    "dataDelecao" : null,
    "permissoes" : [
      {
        "recurso" : {
          "nome" : "Backoffice",
          "frn" : "frn:backoffice::*"
        },
        "visualizar" : true,
        "inserir" : true,
        "editar" : true,
        "deletar" : true
      }
    ]
  },
  {
    "_id" : ObjectId("5ee78e60d20046485aea69d0"),
    "id" : UUID("c37dc92d-30fa-48b4-9119-d5d848fa8dcd"),
    "nome" : "sistema",
    "ativo" : true,
    "dataCriacao" : ISODate("2020-06-15T15:06:08.570Z"),
    "dataAtualizacao" : null,
    "dataDelecao" : null,
    "permissoes" : [
      {
        "recurso" : {
          "nome" : "sistema",
          "frn" : "frn:*:*:*"
        },
        "visualizar" : false,
        "inserir" : false,
        "editar" : false,
        "deletar" : false
      }
    ]
  }
])
