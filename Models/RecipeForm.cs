using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WAD_Assignment1.Models
{
    public class RecipeForm
    {
        [Key]
        [Column(TypeName = "smallint")]

        public int RecipeID { get; set; }
        
        public string Title { get; set; }

        public string Image { get; set; }

        public DateTime PublishDate { get; set; }

        public int CookingTime { get; set; }

        public string Step1 { get; set; }

        public string Step2 { get; set; }
       
        public string Step3 { get; set; }

        public string Step4 { get; set; }

        public string Ingredient1 { get; set; }

        public string Ingredient2 { get; set; }

        public string Ingredient3 { get; set; }

        public string Ingredient4 { get; set; }

        public string Ingredient5 { get; set; }

        public string Ingredient6 { get; set; }

        public string Ingredient7 { get; set; }
    }
}
