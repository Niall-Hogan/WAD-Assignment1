﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WAD_Assignment.Models
{
    public class Recipe
    {


        [Key]
        [Column(TypeName = "smallint")]

        public int RecipeID { get; set; }

        [Required]
        [Column(TypeName = "varchar(46)")]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(46)")]
        public string Image { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        [Column(TypeName = "smallint")]
        public int CookingTime { get; set; }

        [Column(TypeName = "varchar(489)")]
        public string Step1 { get; set; }
      
        [Column(TypeName = "varchar(529)")]
        public string Step2 { get; set; }
      
        [Column(TypeName = "varchar(437)")]
        public string Step3 { get; set; }
      
        [Column(TypeName = "varchar(167)")]
        public string Step4 { get; set; }
  

        [Column(TypeName = "varchar(54)")]
        public string Ingredient1 { get; set ; }
      
        [Column(TypeName = "varchar(45)")]
        public string Ingredient2 { get; set; }
       
        [Column(TypeName = "varchar(73)")]
        public string Ingredient3 { get; set; }
      
        [Column(TypeName = "varchar(49)")]
        public string Ingredient4 { get; set; }
      
        [Column(TypeName = "varchar(43)")]
        public string Ingredient5 { get; set; }
      
        [Column(TypeName = "varchar(50)")]
        public string Ingredient6 { get; set; }

        [Column(TypeName = "varchar(56)")]
        public string Ingredient7 { get; set; }



    }
}