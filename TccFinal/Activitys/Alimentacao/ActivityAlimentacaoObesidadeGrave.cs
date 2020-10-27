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
    [Activity(Label = "ActivityAlimentacaoObesidadeGrave")]
    public class ActivityAlimentacaoObesidadeGrave : ListActivity
    {
        static readonly string[] alimentosObesidadeGrave = new String[]
        {   "Peixes e frutos do mar:  inflamação é um dos principais responsáveis pelo ganho de peso. Peixes e frutos do mar, por serem ricos em ômega 3, um ácido graxo essencial, ajudam a desinflamar as células de gordura, atuando no controle do problema e ajudando a perder barriga. Além disso, esses alimentos também aceleram a transformação da glicose em energia, impedindo que ela seja estocada sob a forma de gordura. A inclusão desses alimentos no cardápio pode ser feita pelo menos três vezes por semana.",
            " Óleo de cártamo e outros óleos funcionais: Os óleos funcionais atuam no metabolismo das gorduras, aumentando a quebra da dos ácidos graxos para produção de energia e, consequentemente, diminuindo as reservas de gordura. O óleo de cártamo e o óleo de coco agem também na aceleração do metabolismo.",
            "Iogurtes com probióticos: Alguns lactobacilos produzem um tipo de gordura, o CLA (ácido linoléico conjugado), que é capaz de reduzir o porcentual de gordura. Além disso, esse tipo de alimento tem como função básica equilibrar a flora intestinal. Um estudo publicado em 2006 pela revista científica Nature mostrou que as bactérias presentes na flora intestinal de pessoas com obesidade são muito diferentes das de pessoas com peso adequado. A descoberta sugere que a absorção inadequada de gorduras no intestino, que ocorre nas pessoas com flora comprometida, pode estar relacionada ao ganho de peso.",
            "Integrais: Os integrais são ricos em fibras, que são importantes aliadas no processo de perder barriga. O primeiro motivo é que consumir fibras com bastante água ajuda a melhorar o trânsito intestinal, o que evita que a barriga fique estufada e inchada. Além disso, alimentos ricos em fibras tendem a ter um índice glicêmico mais baixo. Isso porque as fibras desaceleram a absorção da glicose dos alimentos, evitando picos de glicemia e do hormônio insulina, responsável por levar o açúcar para as células. Os carboidratos com menor índice glicêmico são: batata doce, mandioquinha, arroz integral e chia.",
            "Frutas vermelhas: As frutinhas vermelho-arroxeadas (framboesa, amora, morango, cereja, jabuticaba, mirtilo, melancia e uva roxa) são poderosas aliadas para perder barriga. Existem, nas cascas dessas frutas, substâncias fitoquímicas com ação antioxidante, como a antocianina, que mantém o sistema circulatório eficiente, melhorando a irrigação dos tecidos e ajudando na queima de gordura abdominal. É recomendado o consumo de uma ou duas xícaras por dia, sem adição de açúcar.",
            "Chá verde: Além de atuarem no sistema nervoso central acelerando o metabolismo e aumentando a temperatura corporal, as xantinas (cafeína, teofilina e teobromina) presentes no café, chá verde, chá preto, chá mate e chocolate aumentam a mobilização de gorduras estocadas, ajudando a perder barriga. Você pode tomar uma xícara de chá de 30 a 40 minutos após almoço e jantar, com cuidado especial para não consumi-lo antes de dormir (o que pode atrapalhar o sono) e se você for hipertenso, porque essas substâncias aumentam a pressão arterial.",
            "Chá de hibisco: Uma pesquisa publicada no Journal of Ethnopharmacology da Sociedade Internacional de Etnofarmacologia concluiu que o chá de hibisco é capaz de reduzir a adipogênese, processo em que as células amadurecem e se tornam capazes de acumular gordura, ou seja, é um excelente aliado para perder barriga. Ainda não está claro qual é a substância presente na bebida que é responsável pelo benefício. Porém, acredita-se que a ação antioxidantes dos flavonoides antocianina e quercetina contribuem para reduzir o depósito de gordura.",
            "Gengibre: O gengibre é um alimento termogênico, o que ajuda a acelerar o metabolismo e aumentar a queima de gordura, sendo um excelente apoio ao projeto perder barriga. O gingerol, composto principal, exerce funções antioxidantes, antifúngicas, anti-inflamatórias, inibe a agregação das plaquetas evitando o aparecimento de trombos. A quantidade indicada de gengibre são duas fatias pequenas por dia. Isto é o suficiente para se ter o efeito termogênico.",
            " Azeite: Uma pesquisa realizada pelo Instituto Salud Carlos III, da Espanha, em parceria com a Universidade de Cambridge, da Inglaterra, aponta que a ingestão diária de azeite evita a formação de gorduras na região da cintura. O estudo foi publicado na revista Diabetes Care e afirma que as gorduras monoinsaturadas presentes do azeite previne o acúmulo de gordura na região.",
            " Água:Todas as reações do nosso organismo dependem da água. Para queimar gordura, eliminar toxinas, o intestino funcionar corretamente e evitar retenção de líquidos precisamos beber água. "

        };
        
            protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.list_item, alimentosObesidadeGrave);

            ListView.TextFilterEnabled = true;

            ListView.FastScrollEnabled = true;

            ListView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short).Show();
            };
        }
    }
}
