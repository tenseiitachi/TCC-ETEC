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
using TccFinal.Resources.Model;
using SQLite;

namespace TccFinal.Activitys
{
    [Activity(Label = "ActivityRecuperar")]
    public class ActivityRecuperar : Activity
    {
        
        TextView txtEmail;
        TextView txtResposta;
        Button btnRecuperacao;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.TelaRecuperar);

            txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
            txtResposta = FindViewById<EditText>(Resource.Id.txtResposta);
            btnRecuperacao = FindViewById<Button>(Resource.Id.btnRecuperacao);

          
            
            btnRecuperacao.Click += BtnRecuperacao_Click;
            CriarBancoDeDados();
        }

        private void BtnRecuperacao_Click(object sender, EventArgs e)
   
        {
            try
            {

                //combina duas cadeias de caracteres em um caminho
                string dbPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Usuario.db"); // Cria o Banco de Dados

                //cria o banco de dados se ele não existir
                var db = new SQLiteConnection(dbPath);
                var dados = db.Table<Login>(); //Chama Tabela

                //verifica a existência do usuário 
                var login = dados.Where(x => x.Resposta == txtResposta.Text && x.Email == txtEmail.Text).FirstOrDefault(); //Se não encontrar então volte ao primeiro ou a página padrão

                // se houver usuário então faça:
                if (login != null)
                {
                    Toast.MakeText(this, "Login realizado com sucesso", ToastLength.Short).Show();

                    var atividade2 = new Intent(this, typeof(ActivityCalculoImc));

                    //pega os dados digitados em txtLogin
                    atividade2.PutExtra("nome", FindViewById<EditText>(Resource.Id.txtUsuario).Text);
                    StartActivity(atividade2);
                }
                else
                {
                    Toast.MakeText(this, "Usuário ou senha incorretos!", ToastLength.Short).Show();
                }
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }
        }

        // ATENÇÃO 
        // ATENÇÃO 
        // ATENÇÃO 
        // ATENÇÃO 

        //versão antiga, deixei comentado caso houver erro.
        /* 
        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            var calculoImc = new Intent(this, typeof(CalculoImc));

            StartActivity(calculoImc);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        */


        private void CriarBancoDeDados()
        {
            try
            {
                //combina duas cadeias de caracteres em um caminho
                string dbPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Usuario.db"); // Cria o Banco de Dados
                //cria o banco de dados se ele não existir
                var db = new SQLiteConnection(dbPath);
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }
        }
    }
}
