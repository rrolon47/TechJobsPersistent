﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage ="Job name is required")]
        public string Name { get; set; }

        public int EmployerId { get; set; }
        [Required(ErrorMessage = "Employer is required. Add new employer if necessary.")]
        public  List<SelectListItem> Employers { get; set; }

        public int SkillId { get; set; }
        [Required(ErrorMessage ="Skills are required. Add new skill if necessary.")]
        public List<Skill> Skills { get; set; }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            Employers = new List<SelectListItem>();
            Skills = skills;


            foreach (var employer in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
        }

        public AddJobViewModel() { }
    }
}
