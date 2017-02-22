using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkWithEF.ViewModels
{
    public class TaskViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Укажите название")]
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Заполните описание")]
        [Range(3, 50, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Укажите исполнителя")]
        public string Performer { get; set; }
    }
}
