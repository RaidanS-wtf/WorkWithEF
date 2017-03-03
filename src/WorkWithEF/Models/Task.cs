using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkWithEF.Models
{
    public class Task : BlankClass
    {
        public string Performer { get; set; }
        public Status Status { get; set; }
    }
}
