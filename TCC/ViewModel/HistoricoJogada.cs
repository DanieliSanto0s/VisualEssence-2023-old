namespace Tcc.ViewModel
{
    public class HistoricoJogada
    {
        public int IdJogada { get; set; }
        public int IdCrianca { get; set; }
        public string NomeCrianca { get; set; }
        public string NomeJogo { get; set; }
        public int PontuacaoJogo { get; set; }
        public string DataJogou { get; set; }
        public string NomeResp{ get; set; }
        public string Email { get; set; }

        public List<HistoricoJogada> HistoricoJogadas { get; set; }


    }

}
