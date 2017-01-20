using NUnit.Framework;
using TechTalk.SpecFlow;

namespace App
{
    [Binding]
    public sealed class ModeloTesteSteps
    {
        private Modelo _modelo;

        [When(@"Desativar modelo")]
        public void QuandoDesativarModelo()
        {
            _modelo = new Modelo();
            _modelo.Desativar();
        }

        [Then(@"O modelo não deve estar ativo")]
        public void EntaoOModeloNaoDeveEstarAtivo()
        {
            Assert.IsFalse(_modelo.Ativo);
        }
    }
}
