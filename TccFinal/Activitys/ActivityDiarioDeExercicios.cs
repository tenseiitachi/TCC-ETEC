using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using TccFinal.Activitys;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using TccFinal.Resources.Model;

namespace TccFinal.Activitys
{
    [Activity(Label = "DiarioDeExercicios")]
    public class ActivityDiarioDeExercicios : Activity
    {
        EditText txtExercicios;
        EditText txtData;
        EditText txtTempo;
        EditText txtRegistroDePeso;
        Button btnCadastrarDiario;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.TelaDiarioDeExercicios);

            txtExercicios = FindViewById<EditText>(Resource.Id.txtExercicio);
            txtData = FindViewById<EditText>(Resource.Id.txtData);
            txtTempo = FindViewById<EditText>(Resource.Id.txtTempo);
            txtRegistroDePeso = FindViewById<EditText>(Resource.Id.txtRegistroDePeso);
            btnCadastrarDiario = FindViewById<Button>(Resource.Id.btnCadastrarDiario);


            btnCadastrarDiario.Click += BtnExerciciosDiario_Click;
        }

        private void BtnExerciciosDiario_Click(object sender, EventArgs e)
        {

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
                tbDiarioDeExercicios.Exercicio = txtExercicios.Text;
                tbDiarioDeExercicios.Data = txtData.Text;
                tbDiarioDeExercicios.Tempo = txtTempo.Text;
                tbDiarioDeExercicios.peso = txtRegistroDePeso.Text;


                //inclui na tabela
                db.Insert(tbDiarioDeExercicios);
                Toast.MakeText(this, "Cadastro feito com sucesso!!", ToastLength.Short).Show();
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }

        }
    }
}