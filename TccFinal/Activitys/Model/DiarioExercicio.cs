using System;
using SQLite;

namespace TccFinal.Resources.Model
{
    public class DiarioExercicio
    {
        // Chave primária autoincremental 
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }


        public string Exercicio { get; set; }

        public string Data { get; set; }

        public string Peso { get; set; }

        public string Tempo { get; set; }

        public string Usuario { get; set; }

        public DiarioExercicio()
        {

        }

    }
}