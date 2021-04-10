using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vaccinator.Models
{
    public class Injection
    {
        public int Id { get; set; }

        [Display(Name = "Type du vaccin")]
        [Required]
        public virtual VaccinType VaccinType { get; set; }

        [Display(Name = "Vacciné")]
        [Required]
        public virtual Personne Personne { get; set; }

        [Display(Name = "Marque du vaccin")]
        [MaxLength(100)]
        [Required]
        public string Marque { get; set; }

        [Display(Name = "Numéro de lot du vaccin injecté")]
        [MaxLength(100)]
        [Required]
        public string Reference { get; set; }


        [Display(Name = "Date de prise")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime PriseDate { get; set; }

        [Display(Name = "Date de rappel")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime RappelDate { get; set; }

    }
}
