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
using TccFinal.Activitys.DefinicaoExercicios;
using TccFinal.Activitys;

namespace TccFinal.Activitys.DefinicaoExercicios
{
    [Activity(Label = "ActivityVizualizarAtividades")]
    public class ActivityVizualizarAtividades :Activity
    {
      
        TextView txtExibirExercicio;
        TextView txtExibirData;
        TextView txtExibirPeso;
        TextView txtExibirTempo;
        TextView txtExibirUsuario;
   


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.TelaExibirRegistros);

           
            txtExibirExercicio = FindViewById<TextView>(Resource.Id.txtExibirExercicio);
            txtExibirData = FindViewById<TextView>(Resource.Id.txtExibirData);
            txtExibirPeso = FindViewById<TextView>(Resource.Id.txtExibirPeso);
            txtExibirTempo = FindViewById<TextView>(Resource.Id.txtExibirTempo);
            txtExibirUsuario = FindViewById<TextView>(Resource.Id.txtExibirUsuario);



            // Create your application 

            try
            {


                //definindo caminho do banco de dados
                string dbPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Usuario.db"); // Cria o Banco de Dados
                //abre o banco se não existir
                var db = new SQLiteConnection(dbPath);

               



                var dados = db.Table<DiarioExercicio>();

               DiarioExercicio tbdiario = new DiarioExercicio();

                //verifica a existência do usuário 
                tbdiario = dados.FirstOrDefault(); //Se não encontrar então volte ao primeiro ou a página padrão


              


              
                txtExibirExercicio.Text = tbdiario.Exercicio;
                txtExibirData.Text = tbdiario.Data;
                txtExibirPeso.Text = tbdiario.Peso;
                txtExibirTempo.Text = tbdiario.Tempo;
                txtExibirUsuario.Text = tbdiario.Usuario;

                Toast.MakeText(this, db.ToString(), ToastLength.Short).Show();



            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }
        }
    }
}