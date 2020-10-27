using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TccFinal.Activitys.DefinicaoExercicios;
using TccFinal.Activitys.Alimentacao;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TccFinal.Activitys
{
    [Activity(Label = "ActivitySobrepeso")]
    public class ActivitySobrepeso : Activity
    {

        ImageButton ImgAlimentacao;
        ImageButton ImgExercicios;
        ImageButton ImgGanhoDeMassa;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.TelaSobrepeso);
            ImgAlimentacao = FindViewById<ImageButton>(Resource.Id.imgAlimentacao);
            ImgExercicios = FindViewById<ImageButton>(Resource.Id.imgExercicios);
            ImgGanhoDeMassa = FindViewById<ImageButton>(Resource.Id.imgGanhoDeMassa);


            ImgAlimentacao.Click += ImgAlimentacao_Click;

            ImgGanhoDeMassa.Click += ImgGanhoDeMassa_Click;

            ImgExercicios.Click += ImgExercicios_Click;
        }

        private void ImgExercicios_Click(object sender, EventArgs e)
        {
            var ActivityExercicios = new Intent(this, typeof(ActivityExercicios));
            StartActivity(ActivityExercicios);
        }

        private void ImgGanhoDeMassa_Click(object sender, EventArgs e)
        {
            var ActivityPerdaDeMassa = new Intent(this, typeof(ActivityPerdaDeMassa));
            StartActivity(ActivityPerdaDeMassa);
        }

        private void ImgAlimentacao_Click(object sender, EventArgs e)
        {
            var ActivityAlimentacaoSobrepeso = new Intent(this, typeof(ActivityAlimentacaoSobrepeso));
            StartActivity(ActivityAlimentacaoSobrepeso);
        }
    }
}