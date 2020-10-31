using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using TaxiWPF.dto;

namespace TaxiWPF.Model
{
    class RegisterModel
    {

        public string ErrorMessage;
       

        public RegisterModel()
        {

        }

        public bool tryRegister(UserDTO user)
        {
            ErrorMessage = "error";
            return false;
        }



    }
}
