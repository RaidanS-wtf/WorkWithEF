using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace WorkWithEF.ViewModels
{

    public class BugViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Укажите название")]
        [Display(Name = "Название Бага")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Заполните описание бага")]
        [MinLength(5, ErrorMessage = "Minimum length of Description should be 5 characters")]
        [MaxLength(150, ErrorMessage = "Maximum length of Description should be 150 characters")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Укажите автора")]
        public string Author { get; set; }
    }
}
