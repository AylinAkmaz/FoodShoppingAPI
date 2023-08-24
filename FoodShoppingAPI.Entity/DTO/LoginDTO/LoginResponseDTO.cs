using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.LoginDTO
{
    public class LoginResponseDTO
    {


        public string AdSoyad { get; set; }
        public int UserID { get; set; }
        public string Token { get; set; }
        public string EPosta { get; set; }
        public string Adres { get; set; }

    }
}
