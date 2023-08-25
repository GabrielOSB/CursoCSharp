using System;
using System.Collections.Generic;

using CursoCSharpe.Fundamentos;

namespace CursoCSharpe {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Segundo Programa - Comentarios", Comentarios.Executar },
                {"Terceiro Programa - VariaveisEFundamentos", VariaveisEFundamentos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}