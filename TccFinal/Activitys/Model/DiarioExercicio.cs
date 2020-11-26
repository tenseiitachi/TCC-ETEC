using System;
using SQLite;

namespace TccFinal.Resources.Model
{
    class DiarioExercicio: Login
    {
        // Chave primária autoincremental 
        [PrimaryKey, AutoIncrement]
       

        public string Exercicio { get; set; }

        public string Data { get; set; }

        public string Peso { get; set; }

        public string Tempo { get; set; }

      

        public DiarioExercicio()
        {

        }

    }
}