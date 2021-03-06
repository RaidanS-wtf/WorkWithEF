﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using WorkWithEF.Models;

namespace WorkWithEF.ViewModels
{
    public class TaskViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Укажите название")]
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Заполните описание")]
        [MinLength(5, ErrorMessage = "Minimum length of Description should be 5 characters")]
        [MaxLength(150, ErrorMessage = "Maximum length of Description should be 150 characters")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Укажите исполнителя")]
        public string Performer { get; set; }
        public Status Status { get; set; }
    }
}
