namespace ProEventos.API.Models
{
    public class Eventos
    {  
        public int EventosId { get; set; }

        public string Local { get; set; }

        public string DataEvento { get; set; }

        public string Tema { get; set; } 

        public int QtdPessoa { get; set; }    

        public string Lote { get; set; }
        
        public string ImagemURL { get; set; }
    }
}