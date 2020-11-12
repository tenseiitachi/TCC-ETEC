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
using TccFinal.Resources.Model;

namespace TccFinal.Activitys.DefinicaoExercicios
{
    [Activity(Label = "ActivityVizualizarAtividades")]
    public class ActivityVizualizarAtividades :Activity
    {


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application 
            try
            {
                //definindo caminho do banco de dados
                string dbPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Usuario.db"); // Cria o Banco de Dados
                //abre o banco se não existir
                var db = new SQLiteConnection(dbPath);

                //executa um 'create table if not exists' no banco de dados
                db.CreateTable<DiarioExercicio>();

                //cria uma instancia de login
                DiarioExercicio tbDiarioDeExercicios = new DiarioExercicio();

                //atribui Descrição do exercicio e data informados
              


                //inclui na tabela
                db.Insert(tbDiarioDeExercicios);
                Toast.MakeText(this, db.ToString() , ToastLength.Short).Show();
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }
        }
    }
}