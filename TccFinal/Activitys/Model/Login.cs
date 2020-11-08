using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace TccFinal.Resources.Model
{
    public class Login
    {
        // Chave primária autoincremental 
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(25)]
        public string Usuario { get; set; }
        [MaxLength(15)]
        public string Senha { get; set; }

        public string Email { get; set; }

        public string Pergunta { get; set; }

        public string Resposta { get; set; }

      



    }
}