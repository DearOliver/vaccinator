using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vaccinator.Models
{
    public class Personne
    {
        public Personne()
        {
            PInjections = new List<Injection>();
        }

        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Nom { get; set; }

        [MaxLength(100)]
        [Required]
        public string Prenom { get; set; }

        [MaxLength(5)]
        [Required]
        public string Sexe { get; set; }

        [Display(Name = "Date de naissance")]
        [Required]
        public DateTime BirthDate { get; set; }

        [MaxLength(10)]
        [Required]
        public string Statut { get; set; }

        public virtual ICollection<Injection> PInjections { get; set; }
    }
}