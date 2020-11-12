using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using TccFinal.Activitys;
using Android.Content;
using System;
using SQLite;
using TccFinal.Resources.Model;
using Android.Graphics;

namespace TccFinal
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnLogin;
        Button btnRegistrar;
        Button btnRecuperar;
        TextView txtLogin;
        TextView txtSenha;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            btnRegistrar = FindViewById<Button>(Resource.Id.btnRegistrar);
            txtLogin = FindViewById<EditText>(Resource.Id.txtUsuario);
            txtSenha = FindViewById<EditText>(Resource.Id.txtSenha);
            btnRecuperar = FindViewById<Button>(Resource.Id.btnRecuperar);

            btnLogin.Click += BtnLogin_Click;
            btnRegistrar.Click += BtnRegistrar_Click;
            btnRecuperar.Click += BtnRecuperar_Click;
            CriarBancoDeDados();
        }

        private void BtnRecuperar_Click(object sender, EventArgs e)
        {
          var ActivityRecuperar =  new Intent(this, typeof(ActivityRecuperar));
            StartActivity(ActivityRecuperar);
        }

        private void BtnRegistrar_Click(object sender, System.EventArgs e)
        {

            //criar uma tela para registro de usuario 
            var Registro = new Intent(this, typeof(ActivityRegistro));

            StartActivity(Registro);

        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            try
            {

                //combina duas cadeias de caracteres em um caminho
                string dbPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Usuario.db"); // Cria o Banco de Dados

                //cria o banco de dados se ele não existir
                var db = new SQLiteConnection(dbPath);
                var dados = db.Table<Login>(); //Chama Tabela

                //verifica a existência do usuário 
                var login = dados.Where(x => x.Usuario == txtLogin.Text && x.Senha == txtSenha.Text).FirstOrDefault(); //Se não encontrar então volte ao primeiro ou a página padrão

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