using System.ComponentModel.DataAnnotations;

namespace PersonaWeb.Models

{
    public enum SexType
    {
        fem = 0,
        masc = 1,
    }
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Porfavor ingrese entre 5 a 60 caracteres")]
        [Display(Name = "Nombre de la persona")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Sexo")]
        public SexType Sex { get; set; }

        [Display(Name = "Pasa tiempo")]
        public string Hobbie { get; set; }
    }
}