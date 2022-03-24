using System.ComponentModel.DataAnnotations.Schema;

namespace Veterinarios.Models {
   public class Animais {

        public Animais()
        {
            ListaConsultas = new HashSet<Consultas>();
        }

        public int Id { get; set; }

      public string Nome { get; set; }

      public string Especie { get; set; }

      public string Raca { get; set; }

      public double Peso { get; set; }

      public string Foto { get; set; }


        /// <summary>
        /// Fk para o Donos
        /// </summary>
        [ForeignKey(nameof(Dono))]
        public int DonoFK { get; set; }
        public Donos Dono { get; set; }


        /// <summary>
        /// Lista de Consultas em que o Animal particisa
        /// </summary>
        public ICollection<Consultas> ListaConsultas { get; set; }



    }
}
