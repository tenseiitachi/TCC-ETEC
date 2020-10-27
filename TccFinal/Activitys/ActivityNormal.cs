using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TccFinal.Activitys.Alimentacao;
using TccFinal.Activitys.DefinicaoExercicios;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TccFinal.Activitys
{
    [Activity(Label = "ActivityNormal")]
    public class ActivityNormal : Activity
    {

        ImageButton ImgAlimentacao;
        ImageButton ImgExercicios;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.TelaNormal);
            ImgAlimentacao = FindViewById<ImageButton>(Resource.Id.imgAlimentacao);
            ImgExercicios = FindViewById<ImageButton>(Resource.Id.imgExercicios);
           


            ImgAlimentacao.Click += ImgAlimentacao_Click;

         

            ImgExercicios.Click += ImgExercicios_Click;
        }

        private void ImgExercicios_Click(object sender, EventArgs e)
        {
            var ActivityExercicios = new Intent(this, typeof(ActivityExercicios));
            StartActivity(ActivityExercicios);
        }

     

        private void ImgAlimentacao_Click(object sender, EventArgs e)
        {
            var ActivityAlimentacaoNormal = new Intent(this, typeof(ActivityAlimentacaoNormal));
            StartActivity(ActivityAlimentacaoNormal);
        }
    }
}