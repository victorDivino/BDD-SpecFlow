namespace App
{
    class Modelo
    {
        public Modelo()
        {
            Ativo = true;
        }

        public bool Ativo { get; set; }

        public void Desativar() => Ativo = false;
    }
}
