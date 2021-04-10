using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vaccinator.Models
{
    public class VaccinType
    {
        public VaccinType()
        {
            VTInjections = new List<Injection>();
        }
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Nom { get; set; }

        [Display(Name = "Virus ciblé")]
        [MaxLength(100)]
        [Required]
        public string Cible { get; set; }


        [Display(Name = "Année de découverte")]
        [Range(1500, 2021)]
        [Required]
        public int DiscoveryYear { get; set; }

        public virtual ICollection<Injection> VTInjections { get; set; }
    }
}
