using MVC_CRUD_Migraciones_Automatica.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CRUD_Migraciones_Automatica.ViewModels
{
    public class UserView
    {
        public string UserID { get; set; }

        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }

        // para almacenar temporalment
        public RoleView Role { get; set; }

        public List<RoleView> Roles { get; set; }

        
    }
}