using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

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
    public class ActivityVizualizarAtividades : Activity
    {

        TextView txtExibirExercicio;
        TextView txtExibirData;
        TextView txtExibirPeso;
        TextView txtExibirTempo;
        TextView txtExibirUsuario;
        Spinner spinner;
        ArrayAdapter adapter;
        ArrayList datas;




        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.TelaExibirRegistros);

            spinner = FindViewById<Spinner>(Resource.Id.spnDados);
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



                //executa um 'create table if not exists' no banco de dados
                db.CreateTable<DiarioExercicio>();



                //cria uma instancia de login
                DiarioExercicio tbDiarioDeExercicios = new DiarioExercicio();



                //atribui Descrição do exercicio e data informados





                //inclui na tabela

                var dados = db.Table<DiarioExercicio>(); //Chama Tabela
                List<DiarioExercicio> lista = dados.ToList();//Se não encontrar então volte ao primeiro ou a página padrão
                ArrayList datas = new ArrayList();
                foreach (DiarioExercicio diario in lista)
                {
                    datas.Add(diario.Data);







                }
                adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, datas);
                //vincula o adaptador ao controle spinner
                spinner.Adapter = adapter;
                spinner.ItemSelected += Spinner_ItemSelected;





            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }



        }
        void Spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {

            Spinner spinner = (Spinner)sender;
            try
            {



                //combina duas cadeias de caracteres em um caminho
                string dbPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Usuario.db"); // Cria o Banco de Dados



                //cria o banco de dados se ele não existir
                var db = new SQLiteConnection(dbPath);
                var dados = db.Table<DiarioExercicio>(); //Chama Tabela


                string data = spinner.GetItemAtPosition(e.Position).ToString();
                //verifica a existência do usuário 
                DiarioExercicio tbdiario = new DiarioExercicio();
                tbdiario = dados.Where(x => x.Data == data).FirstOrDefault();
                txtExibirExercicio.Text = tbdiario.Exercicio;
                txtExibirData.Text = tbdiario.Data;
                txtExibirPeso.Text = tbdiario.Peso;
                txtExibirTempo.Text = tbdiario.Tempo;
                txtExibirUsuario.Text = tbdiario.Usuario;

            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }
        }
    }
}
    
