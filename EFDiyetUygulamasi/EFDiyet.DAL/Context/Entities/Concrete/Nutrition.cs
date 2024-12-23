﻿using EFDiyet.DAL.Context.Entities.Abstract;
using EFDiyet.DAL.Context.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Context.Entities.Concrete
{
    //Besinler tablosu
    public class Nutrition : EntityBase
    {
        public string NutritionName { get; set; }
        public float Calories { get; set; }
        public byte[]? Image { get; set; } = null;

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int NutritionValueId { get; set; }
        public NutritionValue NutritionValue { get; set; }

        public Portion Portion { get; set; }
        public float PortionSize { get; set; }

        public ICollection<UserNutrition> UserNutrition { get; set; } = new List<UserNutrition>();
    }
}
