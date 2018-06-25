using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste001.Modelo
{
    class Estacionamento
    {
        public int id { get; set; }
        public string distancia { get; set; }
        public string empresa { get; set; }
        public string edificio { get; set; }
        public string endereco { get; set; }
        public string cep { get; set; }
        public int mensalidade { get; set; }
        public int mensalidade_moto { get; set; }
        public int valor_avulso_meia_hora { get; set; }
        public int valor_avulso_hora { get; set; }
        public int valor_demais_horas { get; set; }
        public int valor_diaria { get; set; }
        public string horario { get; set; }

        public static Modelo.Estacionamento[] recupera_estacionamentos()
        {
            System.Collections.Generic.List<Modelo.Estacionamento> estacionamentos =
                new System.Collections.Generic.List<Modelo.Estacionamento>();

            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 1,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "ARRUDA I",
                endereco = "RUA ARRUDA ALVIM , 119, PINHEIROS",
                cep = "05410-020",
                mensalidade = 300,
                mensalidade_moto = 250,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 12,
                valor_demais_horas = 6,
                valor_diaria = 25,
                horario = "7:00 as 20:30"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 2,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "AQUASPORT",
                endereco = "RUA GIRASSOL, 675  VILA MADALENA",
                cep = "05433-000",
                mensalidade = 250,
                mensalidade_moto = 0,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 0,
                valor_demais_horas = 0,
                valor_diaria = 0,
                horario = "7:00 as 22:00"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 3,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "G9 - 4",
                endereco = "RUA BORGES LAGOA, 1070",
                cep = "04038-002",
                mensalidade = 270,
                mensalidade_moto = 180,
                valor_avulso_meia_hora = 7,
                valor_avulso_hora = 13,
                valor_demais_horas = 7,
                valor_diaria = 25,
                horario = "7:00 as 22:00"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 4,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "ED. DIOGO (HOME)",
                endereco = "RUA DIOGO JACOME, 554 VL NOVA CONCEIÇÃO",
                cep = "04512-001",
                mensalidade = 264,
                mensalidade_moto = 0,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 0,
                valor_demais_horas = 0,
                valor_diaria = 20,
                horario = "24h"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 5,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "ED. PARK OFFICE",
                endereco = "RUA FRANCISCO MATARAZZO, 404  BARRA FUNDA",
                cep = "05001-000",
                mensalidade = 180,
                mensalidade_moto = 120,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 0,
                valor_demais_horas = 0,
                valor_diaria = 10,
                horario = "07:00 as 23:00"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 6,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "SPAZIO",
                endereco = "RUA DR. MIRANDA DE AZEVEDO, 1059 V. POMPÉIA",
                cep = "05027-000",
                mensalidade = 0,
                mensalidade_moto = 0,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 0,
                valor_demais_horas = 0,
                valor_diaria = 0,
                horario = ""
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 7,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "VILA NOVA OFFICE",
                endereco = "RUA AFONSO BRAZ, 579  VILA NOVA CONCEIÇÃO",
                cep = "04511-011",
                mensalidade = 250,
                mensalidade_moto = 200,
                valor_avulso_meia_hora = 16,
                valor_avulso_hora = 4,
                valor_demais_horas = 35,
                valor_diaria = 0,
                horario = "06:30 as 22:00"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 0,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "WORK PLACE",
                endereco = "AV. AFONSO BOVERO, 1057 PERDIZES",
                cep = "05019-011",
                mensalidade = 242,
                mensalidade_moto = 0,
                valor_avulso_meia_hora = 14,
                valor_avulso_hora = 4,
                valor_demais_horas = 25,
                valor_diaria = 0,
                horario = "07:00 AS 22:01"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 9,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "CLÍNICA MAIS",
                endereco = "AV. REPÚBLICA DO LÍBANO, 886",
                cep = "04502-001",
                mensalidade = 0,
                mensalidade_moto = 0,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 0,
                valor_demais_horas = 0,
                valor_diaria = 0,
                horario = ""
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 10,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "APAE",
                endereco = "RUA LOEFGREEN, 2070 VILA MARIANA",
                cep = "04040-003",
                mensalidade = 280,
                mensalidade_moto = 0,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 14,
                valor_demais_horas = 6,
                valor_diaria = 38,
                horario = "07:00 AS 22:01"
            });

            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 11,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "CONSELHEIRO",
                endereco = "RUA CONSELHEIRO NÉBIAS, 246 /262 - CENTRO",
                cep = "01203-000",
                mensalidade = 242,
                mensalidade_moto = 200,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 10,
                valor_demais_horas = 0,
                valor_diaria = 12,
                horario = "24H"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 12,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "ED. IRAPURU",
                endereco = "AV. BRIGADEIRO FARIA LIMA, 2081 JD. PAULISTANO",
                cep = "01452-001",
                mensalidade = 440,
                mensalidade_moto = 0,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 15,
                valor_demais_horas = 5,
                valor_diaria = 0,
                horario = "7:00 as 22:00"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 13,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "DIOGO - TERRENO",
                endereco = "AV. DOUTOR DIOGO DE FARIAS ,155  - VL CLEMENTINO",
                cep = "04037-000",
                mensalidade = 200,
                mensalidade_moto = 0,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 0,
                valor_demais_horas = 0,
                valor_diaria = 12,
                horario = "6:30: 21:00"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 14,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "FUNCHAL",
                endereco = "RUA FUNCHAL, 411 VILA OLIMPIA",
                cep = "04551-060",
                mensalidade = 350,
                mensalidade_moto = 300,
                valor_avulso_meia_hora = 10,
                valor_avulso_hora = 15,
                valor_demais_horas = 5,
                valor_diaria = 20,
                horario = "7:00 AS 22:00"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 15,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "11 DE JUNHO",
                endereco = "AV . 11 DE JUNHO, 1070",
                cep = "04041-004",
                mensalidade = 280,
                mensalidade_moto = 0,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 12,
                valor_demais_horas = 0,
                valor_diaria = 12,
                horario = "06:30 as 22:00"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 16,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "G9II",
                endereco = "RUA BORGES LAGOA , 971 VL. CLEMENTINO",
                cep = "04038-032",
                mensalidade = 330,
                mensalidade_moto = 180,
                valor_avulso_meia_hora = 10,
                valor_avulso_hora = 14,
                valor_demais_horas = 6,
                valor_diaria = 30,
                horario = "7:00 AS 22:00"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 17,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "G9III",
                endereco = "RUA BORGES LAGOA , 1083 VL. CLEMENTINO",
                cep = "04038-032",
                mensalidade = 300,
                mensalidade_moto = 160,
                valor_avulso_meia_hora = 7,
                valor_avulso_hora = 13,
                valor_demais_horas = 7,
                valor_diaria = 25,
                horario = "7:00 AS 22:01"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 18,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "GLORIA II",
                endereco = "RUA DA GLORIA, 132  LIBERDADE  (CENTRO)",
                cep = "01510-001",
                mensalidade = 250,
                mensalidade_moto = 0,
                valor_avulso_meia_hora = 120,
                valor_avulso_hora = 10,
                valor_demais_horas = 5,
                valor_diaria = 25,
                horario = "7:00 as 23:00"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 19,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "PLAZA IGUATEMI",
                endereco = "AV. BRIGADEIRO FARIA LIMA, 2277 JD. PAULISTANO",
                cep = "01452-000",
                mensalidade = 550,
                mensalidade_moto = 275,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 25,
                valor_demais_horas = 10,
                valor_diaria = 0,
                horario = "24h"
            });

            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 20,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "VIRGILIO",
                endereco = "RUA DR. VIRGILIO DE CARVALHO PINTO, 382 PINHEIROS",
                cep = "05415-020",
                mensalidade = 350,
                mensalidade_moto = 0,
                valor_avulso_meia_hora = 250,
                valor_avulso_hora = 10,
                valor_demais_horas = 5,
                valor_diaria = 0,
                horario = "24h"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 21,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "WEST TOWER",
                endereco = "RUA JERICÓ, 255 PINHEIROS",
                cep = "05435-040",
                mensalidade = 330,
                mensalidade_moto = 220,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 18,
                valor_demais_horas = 6,
                valor_diaria = 36,
                horario = "24h"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 22,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "BERRINI",
                endereco = "AV ARANDU, 205 BROOKLIN",
                cep = "04562-030",
                mensalidade = 330,
                mensalidade_moto = 250,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 15,
                valor_demais_horas = 5,
                valor_diaria = 30,
                horario = "07:00 as 21:00"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 23,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "CIDADE JARDIM",
                endereco = "RUA PROFESSOR ARTUR RAMOS, 127",
                cep = "01454-011",
                mensalidade = 400,
                mensalidade_moto = 350,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 17,
                valor_demais_horas = 5,
                valor_diaria = 35,
                horario = "06:00 AS 23:00"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 24,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "FIANDEIRAS",
                endereco = "RUA FIANDEIRAS, 306 VILA OLIMPIA",
                cep = "04545-001",
                mensalidade = 200,
                mensalidade_moto = 180,
                valor_avulso_meia_hora = 6,
                valor_avulso_hora = 0,
                valor_demais_horas = 0,
                valor_diaria = 12,
                horario = "07:00 AS 22:00"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 25,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "JK",
                endereco = "RUA CLODOMIRO AMAZONAS, 1099 VL. OLIMPIA",
                cep = "04537-012",
                mensalidade = 275,
                mensalidade_moto = 180,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 14,
                valor_demais_horas = 6,
                valor_diaria = 25,
                horario = "06:30 AS 21:00"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 26,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "JCP",
                endereco = "RUA DR. JOÃO CLIMACO PEREIRA, 65 ITAIM BIBI",
                cep = "04532-070",
                mensalidade = 280,
                mensalidade_moto = 230,
                valor_avulso_meia_hora = 10,
                valor_avulso_hora = 15,
                valor_demais_horas = 6,
                valor_diaria = 30,
                horario = "24h"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 27,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "MORUMBI",
                endereco = "RUA FRANCISCO TRAMONTANO, 101. MORUMBI",
                cep = "05686-010",
                mensalidade = 270,
                mensalidade_moto = 200,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 12,
                valor_demais_horas = 3,
                valor_diaria = 25,
                horario = "06:30 AS 21:00"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 28,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "PARQUE DA CIDADE",
                endereco = "AV. DAS NAÇÕES UNIDAS , 14401. CHACARA SANTO ANTONIO",
                cep = "04794-000",
                mensalidade = 380,
                mensalidade_moto = 250,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 0,
                valor_demais_horas = 0,
                valor_diaria = 15,
                horario = "06:30 as 22:00"
            });
            estacionamentos.Add(new Modelo.Estacionamento()
            {
                id = 29,
                distancia = "0",
                empresa = "BEST PARK",
                edificio = "WORK PLACE - FUNCHAL",
                endereco = "RUA FUNCHAL, 538 VILA OLIMPIA",
                cep = "04551-060",
                mensalidade = 435,
                mensalidade_moto = 0,
                valor_avulso_meia_hora = 0,
                valor_avulso_hora = 10,
                valor_demais_horas = 5,
                valor_diaria = 25,
                horario = "24h"
            });

            return estacionamentos.ToArray();
        }

    }// class
}// namespace