using DesafioTestUnitarioConsole.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTestUnitarioTeste
{
    [TestClass]
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes = new ValidacoesString();

        [TestMethod]

        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            var texto = "Matrix";
            var resultadoEsperado = 6;

            var resultado = _validacoes.RetornarQuantidadeDeCaracteres(texto);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]

        public void DeveConterAPalavraQualquerNoTexto()
        {
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "qualquer";

            var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

            Assert.IsTrue(resultado);
        }


        [TestMethod]

        public void NaoDeveConterAPalavraTesteNoTexto()
        {
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "teste";

            var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

            Assert.IsFalse(resultado);
        }

        [TestMethod]

        public void TextoDeveTerminarComAPalavraProcurado()
        {
            var texto = "Começo, meio e fim do texto procurado";
            var textoProcurado = "procurado";

            var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

            Assert.IsTrue(resultado);
        }

    }
}
