﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }


        [Required]
        [StringLength(8, MinimumLength =4,ErrorMessage ="You must specify password in range 4-8")]
        public string Password { get; set; }
    }
}
