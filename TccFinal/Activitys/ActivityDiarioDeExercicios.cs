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
using TccFinal.Activitys.DefinicaoExercicios;
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
        EditText txtUsuario;
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
            txtUsuario = FindViewById<EditText>(Resource.Id.txtUsuario);
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
                DiarioExercicio tbdiario = new DiarioExercicio();

                //atribui nome, email e senha informados
                tbdiario.Exercicio = txtExercicios.Text;
                tbdiario.Data = txtData.Text;
                tbdiario.Tempo = txtTempo.Text;
                tbdiario.Peso = txtRegistroDePeso.Text;
                tbdiario.Usuario = txtUsuario.Text;


                //inclui na tabela
               
                db.Insert(tbdiario);
                db.Update(tbdiario);
                Toast.MakeText(this, "Cadastro feito com sucesso!!", ToastLength.Short).Show();
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }

        }
    }
}
            /*
                        try
                        {
                            //definindo caminho do banco de dados
                            string dbPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Exercicio.db"); // Cria o Banco de Dados
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
                            tbDiarioDeExercicios.Peso = txtRegistroDePeso.Text;
                            tbDiarioDeExercicios.Usuario = txtUsuario.Text;


                            //inclui na tabela
                            db.Insert(tbDiarioDeExercicios);
                            Toast.MakeText(this, "Cadastro feito com sucesso!!", ToastLength.Short).Show();



                        }
                        catch (Exception ex)
                        {
                            Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
                        }
            */
