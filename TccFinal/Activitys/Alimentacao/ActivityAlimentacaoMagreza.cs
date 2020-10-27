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
    [Activity(Label = "ActivityAlimentacaoMagreza")]
    public class ActivityAlimentacaoMagreza : ListActivity
    {
        static readonly string[] alimentosMagreza = new String[] { 
            "Sucos caseiros: Há muitas receitas deliciosas de suco de proteína. Evite a maioria das versões comerciais, que podem conter adição de açúcar e não são tão nutritivos. Também lhe dá controle total sobre o sabor e o teor de nutrientes.",

            "Leite: Beber leite é uma ótima maneira de adicionar proteína à sua dieta. O leite tem sido usado como ganhador de peso ou construtor muscular por décadas. Proporciona um bom equilíbrio de proteínas, carboidratos e gorduras e é uma boa fonte de cálcio, além de outras vitaminas e minerais.",

            "Arroz: O arroz é uma excelente fonte de carboidratos fáceis de consumir e digerir. É também bastante denso em calorias, o que significa que você pode obter facilmente uma grande quantidade de carboidratos e calorias de uma única porção.",

            "Carnes vermelhas magras: Um dos melhores alimentos para construção muscular disponíveis. A carne vermelha é uma excelente fonte de proteína que ajuda a ganhar massa muscular.",

            "Batatas e amidos: São uma maneira muito fácil e econômica de adicionar calorias extras. As batatas e outros amidos não só adicionam carboidratos e calorias para ajudar você a ganhar peso – eles também aumentam os estoques de glicogênio muscular.",

            "Salmão: Assim como a carne vermelha, são excelentes fontes de proteína e uma ótima fonte de gorduras ômega-3, incrivelmente saudáveis.",

            "Suplementos proteicos: Funcionam especialmente quando combinados com treinamento de força. Como as carnes e outros produtos animais, a proteína de soro contém todos os aminoácidos essenciais necessários para estimular o crescimento muscular.",

            "Frutas secas: É um lanche altamente calórico que também fornece antioxidantes e micronutrientes. Frutos secos contêm muita fibra e a maioria de suas vitaminas e minerais permanece intacta, ou seja, não perdem os nutrientes.",

            "Pão integral: Pães integrais são outra boa fonte de carboidratos para ajudar você a ganhar peso. Você pode fazer algumas refeições muito simples, altamente calóricas e equilibradas, combinando pão com fontes de proteína, como ovos, carne e queijo.",

            "Abacate: Abacates são carregados com gorduras saudáveis e bastante calóricos. São ricos em vitaminas, minerais e vários compostos benéficos." };
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.list_item, alimentosMagreza);

            ListView.TextFilterEnabled = true;

            ListView.FastScrollEnabled = true;

            ListView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short).Show();
            };
        }
    }
}
