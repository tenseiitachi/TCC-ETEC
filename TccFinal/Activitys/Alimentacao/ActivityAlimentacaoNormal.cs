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

namespace TccFinal.Activitys.Alimentacao
{
    [Activity(Label = "ActivityAlimentacaoNormal")]
    public class ActivityAlimentacaoNormal : ListActivity
    {
        static readonly string[] alimentosNormal = new String[] {
            "Sucos caseiros: Há muitas receitas deliciosas de suco de proteína. Evite a maioria das versões comerciais, que podem conter adição de açúcar e não são tão nutritivos. Também lhe dá controle total sobre o sabor e o teor de nutrientes.",

            "Frutas secas: É um lanche altamente calórico que também fornece antioxidantes e micronutrientes. Frutos secos contêm muita fibra e a maioria de suas vitaminas e minerais permanece intacta, ou seja, não perdem os nutrientes.",

             "Batatas e amidos: São uma maneira muito fácil e econômica de adicionar calorias extras. As batatas e outros amidos não só adicionam carboidratos e calorias para ajudar você a ganhar e manter o peso – eles também aumentam os estoques de glicogênio muscular.",

             "Salmão: Assim como a carne vermelha, são excelentes fontes de proteína e uma ótima fonte de gorduras ômega-3, incrivelmente saudáveis.",

            "Cereais: Comer cereais pode ser uma ótima maneira de manter o peso e consumir mais fibras. No entanto, fique com formas mais saudáveis, como farinha de aveia, aveia e granola.",

            "Ovos: Os ovos são um dos alimentos mais saudáveis ​​para a construção muscular. Eles fornecem uma ótima combinação de proteínas de alta qualidade e gorduras saudáveis."
                                                           };
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.list_item, alimentosNormal);

            ListView.TextFilterEnabled = true;

            ListView.FastScrollEnabled = true;

            ListView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short).Show();
            };
        }
    }
}