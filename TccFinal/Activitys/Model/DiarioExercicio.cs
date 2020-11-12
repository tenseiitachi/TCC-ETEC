using System;
using SQLite;

namespace TccFinal.Resources.Model
{
    class DiarioExercicio
    {
        // Chave primária autoincremental 
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Exercicio { get; set; }

        public string Data { get; set; }

        public string peso { get; set; }

        public string Tempo { get; set; }




    }
}