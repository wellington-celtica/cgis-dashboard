﻿using System.ComponentModel.DataAnnotations;

namespace cGisDashboard.Dto
{
    public class AuthenticateRequest
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
