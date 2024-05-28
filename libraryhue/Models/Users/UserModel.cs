using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Models.Users
{
    public class UserModel
    {
        public int Id { get; private set; }
        public bool Admin { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$",
        ErrorMessage = "La contraseña debe contener al menos una minúscula, una mayúscula, un número y un símbolo."),
        StringLength(15, ErrorMessage = "La contraseña debe tener un mínimo de 8 caracteres y un máximo de 15", MinimumLength = 8)]
        public string Password { get; set; }

    }
}
