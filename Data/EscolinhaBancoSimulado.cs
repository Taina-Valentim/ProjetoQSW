using ProjetoQSW.Models;

namespace ProjetoQSW.Data
{
    public class EscolinhaBancoSimulado
    {
        public List<Professor>? Professores { get; set; }
        public List<Estado>? Estados { get; set; }
        public List<Aluno>? Alunos { get; set; }
        public List<Materia>? Materias { get; set; }
        public List<Historico>? Historicos { get; set; }
        public List<Turma>? Turmas { get; set; }

        public EscolinhaBancoSimulado()
        {
        }


        public void PopularBancoSimulado()
        {
            /****************************** INSERTS PROFESSOR  ******************************/

            var anaPaula = new Professor
            {
                Id = 1,
                Nome = "Ana Paula Muller Giancoli"
            };
            var andreLuis = new Professor
            {
                Id = 2,
                Nome = "Andre Luis Maciel Leme"
            };
            var cesarAlexandre = new Professor
            {
                Id = 3,
                Nome = "Cesar Alexandre Silva Lima"
            };
            var cristinaCorrea = new Professor
            {
                Id = 4,
                Nome = "Cristina Correa de Oliveira"
            };
            var denizePalmito = new Professor
            {
                Id = 5,
                Nome = "Denize Palmito dos Santos"
            };
            var elisandraAparecida = new Professor
            {
                Id = 6,
                Nome = "Elisandra Aparecida Alves da Silva"
            };
            var eversonNunes = new Professor
            {
                Id = 7,
                Nome = "Everson Nunes de Almeida"
            };
            var flavioCezar = new Professor
            {
                Id = 8,
                Nome = "Flavio Cezar Amate"
            };
            var lucianoBernardes = new Professor
            {
                Id = 9,
                Nome = "Luciano Bernardes de Paula"
            };
            var lucieneAngelica = new Professor
            {
                Id = 10,
                Nome = "Luciene Angelica Cardoso Valle"
            };
            var rafaelMuniz = new Professor
            {
                Id = 11,
                Nome = "Rafael da Silva Muniz"
            };
            var raphaelNaves = new Professor
            {
                Id = 12,
                Nome = "Raphael Naves"
            };
            var talitaDePaula = new Professor
            {
                Id = 13,
                Nome = "Talita de Paula Cypriano de Souza"
            };
            var wilsonVendramel = new Professor
            {
                Id = 14,
                Nome = "Wilson Vendramel"
            };
            var yuriAlbuquerque = new Professor
            {
                Id = 15,
                Nome = "Yuri Flores Albuquerque"
            };

            Professores = new List<Professor>()
            {
                anaPaula,
                andreLuis,
                cesarAlexandre,
                cristinaCorrea,
                denizePalmito,
                elisandraAparecida,
                eversonNunes,
                flavioCezar,
                lucianoBernardes,
                lucieneAngelica,
                rafaelMuniz,
                raphaelNaves,
                talitaDePaula,
                wilsonVendramel,
                yuriAlbuquerque

            };

            /****************************** INSERTS MATERIA  ******************************/

            var analiseOrientadaAObjetos = new Materia
            {
                Id = 1,
                Nome = "Análise Orientada a Objetos",
                Creditos = 4,
                Professor = anaPaula
            };
            var arquiteturaDeSoftware = new Materia
            {
                Id = 2,
                Nome = "Arquitetura de Software",
                Creditos = 4,
                Professor = wilsonVendramel
            };
            var bancoDeDadosI = new Materia
            {
                Id = 3,
                Nome = "Banco de Dados I",
                Creditos = 4,
                Professor = lucieneAngelica
            };
            var desenvolvimentoDeSistemasWeb = new Materia
            {
                Id = 4,
                Nome = "Desenvolvimento de Sistemas Web",
                Creditos = 4,
                Professor = anaPaula
            };
            var engenhariaDeSoftware = new Materia
            {
                Id = 5,
                Nome = "Engenharia de Software",
                Creditos = 4,
                Professor = raphaelNaves
            };
            var estatistica = new Materia
            {
                Id = 6,
                Nome = "Estatística",
                Creditos = 2,
                Professor = denizePalmito
            };
            var estruturaDeDadosI = new Materia
            {
                Id = 7,
                Nome = "Estrutura de Dados I",
                Creditos = 4,
                Professor = rafaelMuniz
            };
            var estruturaDeDadosII = new Materia
            {
                Id = 8,
                Nome = "Estrutura de Dados II",
                Creditos = 4,
                Professor = rafaelMuniz
            };
            var gestaoDeProjetos = new Materia
            {
                Id = 9,
                Nome = "Gestão de Projetos",
                Creditos = 4,
                Professor = andreLuis
            };
            var historiaECienciaDaTecnologia = new Materia
            {
                Id = 10,
                Nome = "História da Ciência e Tecnologia",
                Creditos = 2,
                Professor = eversonNunes
            };
            var interacaoHumanoComputador = new Materia
            {
                Id = 11,
                Nome = "Interação Humano-Computador",
                Creditos = 2,
                Professor = talitaDePaula
            };
            var linguagemDeProgramacaoIII = new Materia
            {
                Id = 12,
                Nome = "Linguagem de Programação III",
                Creditos = 4,
                Professor = flavioCezar
            };
            var matematica = new Materia
            {
                Id = 13,
                Nome = "Matemática",
                Creditos = 4,
                Professor = yuriAlbuquerque
            };
            var matematicaFinanceira = new Materia
            {
                Id = 14,
                Nome = "Matemática Financeira",
                Creditos = 2,
                Professor = yuriAlbuquerque
            };
            var metodologiaDePesquisaCientificaETecnologica = new Materia
            {
                Id = 15,
                Nome = "Metodologia de Pesquisa Científica e Tecnológica",
                Creditos = 2,
                Professor = cristinaCorrea
            };
            var metodologiasAgeis = new Materia
            {
                Id = 16,
                Nome = "Metodologias Ágeis",
                Creditos = 2,
                Professor = andreLuis
            };
            var programacaoOrientadaAObjetos = new Materia
            {
                Id = 17,
                Nome = "Programação Orientada a Objetos",
                Creditos = 4,
                Professor = elisandraAparecida
            };
            var projetosDeSistemasI = new Materia
            {
                Id = 18,
                Nome = "Projeto de Sistemas I",
                Creditos = 2,
                Professor = cesarAlexandre
            };
            var qualidadeDeSoftware = new Materia
            {
                Id = 19,
                Nome = "Qualidade de Software",
                Creditos = 4,
                Professor = wilsonVendramel
            };
            var redesDeComputadores = new Materia
            {
                Id = 20,
                Nome = "Rede de Computadores",
                Creditos = 4,
                Professor = flavioCezar
            };
            var servicoesDeRedes = new Materia
            {
                Id = 21,
                Nome = "Serviços de Rede",
                Creditos = 4,
                Professor = lucianoBernardes
            };

            arquiteturaDeSoftware.PreRequisito = engenhariaDeSoftware;
            estatistica.PreRequisito = matematica;
            estruturaDeDadosII.PreRequisito = estruturaDeDadosI;
            linguagemDeProgramacaoIII.PreRequisito = interacaoHumanoComputador;
            matematicaFinanceira.PreRequisito = matematica;
            programacaoOrientadaAObjetos.PreRequisito = analiseOrientadaAObjetos;
            qualidadeDeSoftware.PreRequisito = arquiteturaDeSoftware;
            servicoesDeRedes.PreRequisito = redesDeComputadores;


            var materiaTesteCreditos = new Materia()
            {
                Id = 100,
                Nome = "Teste Créditos",
                Creditos = 100
            };

            Materias = new List<Materia>()
            {
                analiseOrientadaAObjetos,
                arquiteturaDeSoftware,
                bancoDeDadosI,
                desenvolvimentoDeSistemasWeb,
                engenhariaDeSoftware,
                estatistica,
                estruturaDeDadosI,
                estruturaDeDadosII,
                gestaoDeProjetos,
                historiaECienciaDaTecnologia,
                interacaoHumanoComputador,
                linguagemDeProgramacaoIII,
                matematica,
                matematicaFinanceira,
                metodologiaDePesquisaCientificaETecnologica,
                metodologiasAgeis,
                programacaoOrientadaAObjetos,
                projetosDeSistemasI,
                qualidadeDeSoftware,
                redesDeComputadores,
                servicoesDeRedes,
                materiaTesteCreditos
            };

            /****************************** INSERTS ESTADO  ******************************/

            var aprovado = new Estado
            {
                Id = 1,
                Nome = "Aprovado"
            };
            var reprovado = new Estado
            {
                Id = 2,
                Nome = "Reprovado"
            };
            var naoCursado = new Estado
            {
                Id = 3,
                Nome = "Não Cursado"
            };
            var incrito = new Estado
            {
                Id = 4,
                Nome = "Inscrito"
            };
            var listaDeEspera = new Estado
            {
                Id = 5,
                Nome = "Lista de Espera"
            };

            Estados = new List<Estado>()
            {
                aprovado,
                reprovado,
                naoCursado,
                incrito,
                listaDeEspera
            };



            /****************************** INSERTS ALUNO  ******************************/

            var aluno1 = new Aluno
            {
                Id = 1,
                Nome = "Ariane Saraiva do Carmo",
                Login = "ariane.carmo",
                Senha = "Senha123"
            };
            var aluno2 = new Aluno
            {
                Id = 2,
                Nome = "Felipe Moraes Abrahão",
                Login = "felipe.abrahao",
                Senha = "Senha123"
            };
            var aluno3 = new Aluno
            {
                Id = 3,
                Nome = "Frederico Gérald de Freitas Rufino",
                Login = "frederico.rufino",
                Senha = "Senha123"
            };
            var aluno4 = new Aluno
            {
                Id = 4,
                Nome = "Gustavo Pinto da Silva",
                Login = "gustavo.silva",
                Senha = "Senha123"
            };
            var aluno5 = new Aluno
            {
                Id = 5,
                Nome = "Henrique Bertini da Cruz",
                Login = "henrique.cruz",
                Senha = "Senha123"
            };
            var aluno6 = new Aluno
            {
                Id = 6,
                Nome = "Igor Fonseca Montagnana",
                Login = "igor.montagnana",
                Senha = "Senha123"
            };
            var aluno7 = new Aluno
            {
                Id = 7,
                Nome = "Julia Andressa Costa Souza",
                Login = "julia.souza",
                Senha = "Senha123"
            };
            var aluno8 = new Aluno
            {
                Id = 8,
                Nome = "Lauro Migliorini Terribile Pimentel",
                Login = "lauro.pimentel",
                Senha = "Senha123"
            };
            var aluno9 = new Aluno
            {
                Id = 9,
                Nome = "Marcelo Yudi Okita",
                Login = "marcelo.okita",
                Senha = "Senha123"
            };
            var aluno10 = new Aluno
            {
                Id = 10,
                Nome = "Matheus de Oliveira Homem",
                Login = "matheus.homem",
                Senha = "Senha123"
            };
            var aluno11 = new Aluno
            {
                Id = 11,
                Nome = "Matheus Felipe Cardoso",
                Login = "matheus.cardoso",
                Senha = "Senha123"
            };
            var aluno12 = new Aluno
            {
                Id = 12,
                Nome = "Matheus Motta Miranda de Mattos",
                Login = "matheus.mattos",
                Senha = "Senha123"
            };
            var aluno13 = new Aluno
            {
                Id = 13,
                Nome = "Moises Tavares Magalhaes",
                Login = "moises.magalhaes",
                Senha = "Senha123"
            };
            var aluno14 = new Aluno
            {
                Id = 14,
                Nome = "Paulo Vitor Ramos Silva",
                Login = "paulo.silva",
                Senha = "Senha123"
            };
            var aluno15 = new Aluno
            {
                Id = 15,
                Nome = "Ricardo Gabriel Teixeira da Silva",
                Login = "ricardo.silva",
                Senha = "Senha123"
            };
            var aluno16 = new Aluno
            {
                Id = 16,
                Nome = "Taina Valentim de Lima",
                Login = "taina.lima",
                Senha = "Senha123"
            };

            Alunos = new List<Aluno>()
            {
                aluno1,
                aluno2,
                aluno3,
                aluno4,
                aluno5,
                aluno6,
                aluno7,
                aluno8,
                aluno9,
                aluno10,
                aluno11,
                aluno12,
                aluno13,
                aluno14,
                aluno15,
                aluno16
            };

            /****************************** INSERTS TURMA  ******************************/

            var turmaAnaliseOrientadaAObjetos = new Turma
            {
                Id = 1,
                Dia = "Terça",
                Horario = "Completo",
                Vagas = 16,
                Materia = analiseOrientadaAObjetos,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaArquiteturaDeSoftware = new Turma
            {
                Id = 2,
                Dia = "Terça",
                Horario = "Completo",
                Vagas = 16,
                Materia = arquiteturaDeSoftware,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaBancoDeDadosI = new Turma
            {
                Id = 3,
                Dia = "Segunda",
                Horario = "Completo",
                Vagas = 16,
                Materia = bancoDeDadosI,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaDesenvolvimentoDeSistemasWeb = new Turma
            {
                Id = 4,
                Dia = "Quarta",
                Horario = "Completo",
                Vagas = 16,
                Materia = desenvolvimentoDeSistemasWeb,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaEngenhariaDeSoftware = new Turma
            {
                Id = 5,
                Dia = "Quarta",
                Horario = "Completo",
                Vagas = 16,
                Materia = engenhariaDeSoftware,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaEstatistica = new Turma
            {
                Id = 6,
                Dia = "Quarta",
                Horario = "Última",
                Vagas = 8,
                Materia = estatistica,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaEstruturaDeDadosI = new Turma
            {
                Id = 7,
                Dia = "Sexta",
                Horario = "Completo",
                Vagas = 16,
                Materia = estruturaDeDadosI,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaEstruturaDeDadosII = new Turma
            {
                Id = 8,
                Dia = "Quinta",
                Horario = "Completo",
                Vagas = 16,
                Materia = estruturaDeDadosII,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaGestaoDeProjetos = new Turma
            {
                Id = 9,
                Dia = "Sexta",
                Horario = "Completo",
                Vagas = 16,
                Materia = gestaoDeProjetos,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaHistoriaECienciaDaTecnologia = new Turma
            {
                Id = 10,
                Dia = "Quinta",
                Horario = "Última",
                Vagas = 8,
                Materia = historiaECienciaDaTecnologia,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaInteracaoHumanoComputador = new Turma
            {
                Id = 11,
                Dia = "Segunda",
                Horario = "Primeira",
                Vagas = 8,
                Materia = interacaoHumanoComputador,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaLinguagemDeProgramacaoIII = new Turma
            {
                Id = 12,
                Dia = "Quinta",
                Horario = "Completo",
                Vagas = 16,
                Materia = linguagemDeProgramacaoIII,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaMatematica = new Turma
            {
                Id = 13,
                Dia = "Quinta",
                Horario = "Completo",
                Vagas = 16,
                Materia = matematica,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaMatematicaFinanceira = new Turma
            {
                Id = 14,
                Dia = "Segunda",
                Horario = "Primeira",
                Vagas = 8,
                Materia = matematicaFinanceira,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaMetodologiaDePesquisaCientificaETecnologica = new Turma
            {
                Id = 15,
                Dia = "Quarta",
                Horario = "Primeira",
                Vagas = 8,
                Materia = metodologiaDePesquisaCientificaETecnologica,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaMetodologiasAgeis = new Turma
            {
                Id = 16,
                Dia = "Segunda",
                Horario = "Primeira",
                Vagas = 8,
                Materia = metodologiasAgeis,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaProgramacaoOrientadaAObjetos = new Turma
            {
                Id = 17,
                Dia = "Segunda",
                Horario = "Completo",
                Vagas = 16,
                Materia = programacaoOrientadaAObjetos,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaProjetosDeSistemasI = new Turma
            {
                Id = 18,
                Dia = "Segunda",
                Horario = "Última",
                Vagas = 8,
                Materia = projetosDeSistemasI,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaQualidadeDeSoftware = new Turma
            {
                Id = 19,
                Dia = "Quinta",
                Horario = "Completo",
                Vagas = 16,
                Materia = qualidadeDeSoftware,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaRedesDeComputadores = new Turma
            {
                Id = 20,
                Dia = "Sexta",
                Horario = "Completo",
                Vagas = 16,
                Materia = redesDeComputadores,
                AlunosInscritos = new List<Aluno>()
            };
            var turmaServicoesDeRedes = new Turma
            {
                Id = 21,
                Dia = "Terça",
                Horario = "Completo",
                Vagas = 16,
                Materia = servicoesDeRedes,
                AlunosInscritos = new List<Aluno>()
            };



            Turmas = new List<Turma>()
            {
                turmaAnaliseOrientadaAObjetos,
                turmaArquiteturaDeSoftware,
                turmaBancoDeDadosI,
                turmaDesenvolvimentoDeSistemasWeb,
                turmaEngenhariaDeSoftware,
                turmaEstatistica,
                turmaEstruturaDeDadosI,
                turmaEstruturaDeDadosII,
                turmaGestaoDeProjetos,
                turmaHistoriaECienciaDaTecnologia,
                turmaInteracaoHumanoComputador,
                turmaLinguagemDeProgramacaoIII,
                turmaMatematica,
                turmaMatematicaFinanceira,
                turmaMetodologiaDePesquisaCientificaETecnologica,
                turmaMetodologiasAgeis,
                turmaProgramacaoOrientadaAObjetos,
                turmaProjetosDeSistemasI,
                turmaQualidadeDeSoftware,
                turmaRedesDeComputadores,
                turmaServicoesDeRedes
            };

            /****************************** INSERTS HISTORICO  ******************************/

            var materiasHistorico = new List<Materia>()
            {
                bancoDeDadosI,
                analiseOrientadaAObjetos,
                engenhariaDeSoftware,
                matematica,
                estruturaDeDadosI,

                programacaoOrientadaAObjetos,
                arquiteturaDeSoftware,
                metodologiaDePesquisaCientificaETecnologica,
                estatistica,
                estruturaDeDadosII,
                redesDeComputadores,

                metodologiasAgeis,
                projetosDeSistemasI,
                servicoesDeRedes,
                desenvolvimentoDeSistemasWeb,
                qualidadeDeSoftware,
                gestaoDeProjetos
            };

            Historicos = new List<Historico>();

            foreach (Aluno aluno in Alunos)
            {
                var id = 1;
                foreach (Materia materia in materiasHistorico)
                {
                    Historicos.Add
                    (
                        new Historico()
                        {
                            Id = id,
                            Materia = materia,
                            Estado = aprovado,
                            Aluno = aluno
                        }
                    );
                    id++;
                }
                Historicos.Add
                (
                    new Historico()
                    {
                        Id = id,
                        Materia = interacaoHumanoComputador,
                        Estado = reprovado,
                        Aluno = aluno
                    }
                );
                id++;
                Historicos.Add
                (
                    new Historico()
                    {
                        Id = id,
                        Materia = historiaECienciaDaTecnologia,
                        Estado = reprovado,
                        Aluno = aluno
                    }
                );
            }
        }
    }
}
