using CursoCSharp.Excecoes;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.OO;
using CursoCSharp.Colecoes;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Cosntantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Consersões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos- Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais- Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos- Fundamentos", OperadoresLogicos.Executar},
                {"Operadores De Atribuição - Fundamentos", OperadoresDeAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle
                { "Estrutura If - Estruturas De Controle", EstruturaIf.Executar},
                { "Estrutura If/Else - Estruturas De Controle", EstruturaIfElse.Executar},
                { "Estrutura If/Else/If - Estruturas De Controle", EstruturaIfElseIf.Executar},
                { "Estrutura Switch - Estruturas De Controle", EstruturaSwitch.Executar},
                { "Estrutura While - Estruturas De Controle", EstruturaWhile.Executar},
                { "Estrutura For - Estruturas De Controle", EstruturaFor.Executar},
                { "Estrutura Foreach - Estruturas De Controle", EstruturaForEach.Executar},
                { "Usando Break - Estruturas De Controle", UsandoBreak.Executar},
                { "Usando Continue - Estruturas De Controle", UsandoContinue.Executar},
               

                //Classes e Métodos
                { "Métodos - Classes E Métodos", Membros.Executar},
                { "Construtores - Classes E Métodos", Construtores.Executar},
                { "Métodos Com Retorno - Classes E Métodos", MetodosComRetorno.Executar},
                { "Métodos Estáticos - Classes E Métodos", MetodosEstaticos.Executar},
                { "Atirbutos Estáticos - Classes E Métodos", AtirbutosEstaticos.Executar},
                { "Desafio Atributos - Classes E Métodos", DesafioAtributo.Executar},
                { "Params - Classes E Métodos", Params.Executar},
                { "Parâmetros Nomeados - Classes E Métodos", ParametrosNomeados.Executar},
                { "Get Set - Classes E Métodos", GetSet.Executar},
                { "Props - Classes E Métodos", Props.Executar},
                { "Readonly - Classes E Métodos", Readonly.Executar},
                { "Enum - Classes E Métodos", ExemploEnum.Executar},
                { "Struct - Classes E Métodos", ExemploStruct.Executar},
                { "Struct Vs Calsse - Classes E Métodos", StructVsClasse.Executar},
                { "Valor Vs Referência - Classes E Métodos", ValorVsReferencia.Executar},
                { "Parâmetros Por Referência - Classes E Métodos", ParametrosPorReferencia.Executar},
                { "Parâmetro Com Valor Padrão - Classes E Métodos", ParametroPadrao.Executar},

                //Coleções
                 { "Array - Coleções", Colecoes.Array.Executar},
                 { "List - Coleções", ColecoesList.Executar},
                 { "Array List - Coleções", ColecoesArrayList.Executar},
                 { "Queue - Coleções", ColecaoQueue.Executar},
                 { "Igualdade - Coleções", Igualdade.Executar},
                 { "Coleções Stack - Coleções", ColecoesStack.Executar},
                 { "Coleções Dictionary - Coleções", ColecoesDictionary.Executar},

                 //POO
                { "Herança - POO", Heranca.Executar},
                { "Construtor This - POO", ConstrutorThis.Executar},
                { "Encapsulamento - POO", OO.Encapsulamento.Executar},
                { "Polimorfismo - POO", OO.Polimorfismo.Executar},
                { "Abstract - POO", OO.Abstract.Executar},
                { "Interface - POO", OO.Interface.Executar},
                { "Sealed - POO", OO.Sealed.Executar},


                //Metodos & Funções
                { "Exemplo Lambda - Métodos & Funcoes", ExemploLambda.Executar},
                { "Lambdas Como Delegates - Métodos & Funcoes", LambdasDelegate.Executar},
                { "Usando Delegates - Métodos & Funcoes", UsandoDelegates.Executar},
                { "Delegates Como Função Anonima - Métodos & Funcoes", DelegateFunAnonima.Executar},
                { "Delegates Como Parâmetros - Métodos & Funcoes", DelegatesComoParametros.Executar},
                { "Métodos De Extensão - Métodos & Funcoes", MetodosDeExtensao.Executar},



                //Exceções
                { "Primeira Exceção - Excecões", PrimeiraExcecao.Executar},



               



            });

            central.SelecionarEExecutar();
        }
    }
}