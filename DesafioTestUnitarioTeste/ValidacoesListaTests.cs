using DesafioTestUnitarioConsole.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;




namespace DesafioTestUnitarioConsole 
{

    [TestClass]


    public class ValidacoesListaTests
    {


        private ValidacoesLista _validacoes;

        public ValidacoesListaTests()
        {
            _validacoes = new ValidacoesLista();
        }

        [TestMethod]

        public void DeveRemoverNumerosNegativosDeUmaLista()
        {
            var lista = new List<int> { 5, -1, -8, 9 };
            var resultadoEsperado = new List<int> { 5, 9 };

            var resultado = _validacoes.RemoverNumeroNegativos(lista);

            Assert.AreEqual(resultadoEsperado.ToString(), resultado.ToString());
        }

        [TestMethod]

        public void DeveConterONumero9NaLista()
        {
            var lista = new List<int> { 5, -1, -8, 9 };
            var numeroParaProcurar = 9;

            var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

            Assert.IsTrue(resultado);
        }

        [TestMethod]

        public void NaoDeveConterONumero10NaLista()
        {
            var lista = new List<int> { 5, -1, -8, 9 };
            var numeroParaProcurar = 10;

            var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

            Assert.IsFalse(resultado);
        }
        [TestMethod]

        public void DeveMultiplicarOsElementosDaListaPor2()
        {
            var lista = new List<int> { 5, 7, 8, 9 };
            var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
            int num = 2;


            var resultado = _validacoes.MultiplicarNumerosLista(lista, num);

            Assert.AreEqual(resultadoEsperado.ToString(), resultado.ToString());

        }

        [TestMethod]

        public void DeveRetornar9ComoMaiorNumeroDaLista()
        {
            var lista = new List<int> { 5, -1, -8, 9};
            var resultadoEsperado = 9;
            

            var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

            Assert.AreEqual(resultadoEsperado.ToString(), resultado.ToString());
         
        }


        [TestMethod]

        public void DeveRetornarOitoNegativoComoMenosNumeroDaLista()
        {
            var lista = new List<int> { 5, -1, -8, 9 };
            var resultadoEsperado = - 8;


            var resultado = _validacoes.RetornarMenosNumeroLista(lista);

            Assert.AreEqual(resultadoEsperado.ToString(), resultado.ToString());

        }
    }
}