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
    [Activity(Label = "ActivityGanhoDeMassa")]
    public class ActivityGanhoDeMassa : ListActivity
    {
        static readonly string[] GanhoDeMassa = new String[] { "Consumir mais calorias do que gasta: Consumir mais calorias do que gasta é essencial para ganhar massa muscular de forma mais rápida, pois as calorias excedentes, juntamente com os treinos, irão permitir o aumento dos músculos. ",
            "Não pular refeições: Evitar pular refeições é importante para que seja possível atingir todas as calorias necessárias durante o dia, sem estimular possíveis perdas de massa magra durante um jejum prolongado. O ideal é que sejam feitas de 5 a 6 refeições por dia, com atenção redobrada no café da manhã, pré e pós-treino.",
            "Consumir mais proteínas: Aumentar o consumo de proteínas é necessário para permitir o crescimento muscular, sendo importante que os alimentos fontes de proteínas sejam bem distribuídos ao longo do dia, e não concentradas em apenas 2 ou 3 refeições. Esses alimentos são principalmente os de origem animal, como carnes, peixes, frango, queijos, ovos e leite e derivados, mas as proteínas também podem ser encontradas em boa quantidade em alimentos como feijão, ervilha, lentilha, amendoim e grão-de-bico.",
            "Consumir gorduras boas: Ao contrário do que se imagina, consumir gorduras boas ajuda a reduzir o acúmulo de gordura no corpo e ainda facilita o aumento de calorias na dieta para ganhar massa muscular. Essas gorduras estão presentes em alimentos como abacate, azeite, azeitona, amendoim, pasta de amendoim, semente de linhaça, castanhas, nozes, avelãs, macadâmia, peixes como atum, sardinha e salmão. Ao longo dia, esses alimentos podem ser adicionados em lanches como receitas de crepioca, bolinhos fit, nos iogurtes, em vitaminas e nas refeições principais.",
            "Beber bastante água: Beber bastante água é muito importante para estimular a hipertrofia, pois para as células musculares crescerem, é necessário mais água para preencher o seu tamanho maior. Caso não ocorra a ingestão suficiente de água, o ganho de massa muscular vai ser mais lento e dificultoso. Um adulto saudável deve consumir pelo menos 35 ml de água para cada kg de peso. Assim, uma pessoa com 70 kg precisaria consumir pelo menos 2450 ml de água por dia, sendo importante lembrar que bebidas artificiais ou açucaradas não entram nessa conta, como refrigerantes e bebidas alcoólicas.",
            "Consumir pelo menos 2 frutas por dia: Consumir pelo menos 2 frutas por dia é importante para ganhar vitaminas e minerais que favorecem a recuperação muscular após os treinos, favorecendo uma regeneração mais rápida e mais hipertrofiada da massa muscular. Além disso, as vitaminas e os minerais presentes em frutas e verduras são importantes para a contração muscular, a redução da sensação de fadiga durante os treinos e para o fortalecimento do sistema imunológico.",
            "Evitar açúcar e alimentos processados: Evitar alimentos com açúcar e muito processados é importante para não estimular o ganho de gordura no organismo, especialmente porque a dieta para ganhar massa já tem excesso de calorias. Assim, para evitar que o aumento de peso seja feito de massa gorda, é necessário retirar da dieta alimentos como doces, biscoitos, bolos, torradas, fast food, salsicha, linguiça, bacon, queijo cheddar e presunto ou apresuntado. Esses alimentos devem ser trocados pelo pão integral, biscoitos e bolos integrais, queijos como coalho, minas e mussarela, ovos, carnes e peixes."
        };
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.list_item, GanhoDeMassa);

            ListView.FastScrollEnabled = true;

            ListView.TextFilterEnabled = true;

            ListView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short).Show();
            };
        }
    }
}