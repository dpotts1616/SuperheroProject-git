using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperheroProject.Models
{
    public class Superhero
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Superhero Name")]
        public string SuperName { get; set; }
        [Display(Name = "Alter Ego First Name")]
        public string AlterEgoFirst { get; set; }
        [Display(Name = "Alter Ego Last Name")]
        public string AlterEgoLast { get; set; }
        [Display(Name = "Primary Ability")]
        public string PrimaryAbility { get; set; }
        [Display(Name = "Secondary Ability")]
        public string SecondaryAbility { get; set; }
        [Display(Name = "Catchphrase")]
        public string Catchphrase { get; set; }

        public Superhero()
        {

        }
    }
}
