namespace Veterinarios.Models {


    /// <summary>
    /// Descrição dos dados dos clientes (donos dos animais) da clínica
    /// </summary>
    public class Donos {

        public Donos() {
            ListaAnimais = new HashSet<Animais>();
       
        
        }


      /// <summary>
      /// PK para o dono
      /// </summary>
      public int Id { get; set; }

        /// <summary>
        /// Nome do Dono do Animal 
        /// </summary>

        public string Nome { get; set; }


        /// <summary>
        /// Identificação do Sexo do dono
        /// Mm - Masculino ; Ff - feminino
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// NIF do Dono
        /// </summary>
        public string NIF { get; set; }

        //List dos Animais do Dono

        public ICollection<Animais> ListaAnimais { get; set; }


    }
}
