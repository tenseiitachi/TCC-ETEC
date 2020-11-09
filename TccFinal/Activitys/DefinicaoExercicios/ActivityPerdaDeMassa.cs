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

namespace TccFinal.Activitys.DefinicaoExercicios
{
    [Activity(Label = "ActivityPerdaDeMassa")]
    public class ActivityPerdaDeMassa : ListActivity
    {
        static readonly string[] GanhoDeMassa = new String[] {
            "Défice energético: Atingir e manter o défice energético é o primeiro passo para o sucesso na perda de peso, e consequente perda de massa gorda. Entenda-se por défice energético (calórico) como uma diminuição da ingestão de calorias em relação à quantidade de calorias que o corpo necessita para a manutenção do peso atual (1). Este processo dinâmico pode ser criado com a redução da ingestão de calorias através da diminuição do consumo de alimentar ou com o aumento do dispêndio energético através da atividade física, sendo desejável a sinergia entre ambos (2). Para reduzir cerca de 1 kg de peso corporal é necessário fazer um défice semanal de aproximadamente 6000 kcal a 7000 kcal.",
            "Plano alimentar simples e possível: A “dieta ideal” a seguir é aquela que é segura, eficaz, saudável e nutricionalmente adequada, culturalmente aceitável, economicamente acessível e que promova a manutenção da perda de massa gorda a longo termo. Assim, para facilitar a perda de massa gorda, a dieta desejável deve respeitar as necessidades e preferências individuais e o estado de saúde da pessoa (1). A adesão à dieta irá depender destes fatores, não devendo ser estritamente restritiva e complexa. A gestão das expectativas e a criação de metas realistas para a perda de massa gorda são peças fundamentais para o sucesso do processo e evitam o surgimento do fracasso e desânimo. Uma perda de 5% a 10% do peso inicial nos primeiros 6 meses é um objetivo realista e concretizável (1).",
            "Consumo de proteína adequado: Em adição à restrição energética, a composição da dieta em macronutrientes representa uma importante função no emagrecimento, de forma a promover maior saciedade e perda de massa gorda, preservando a massa livre de gordura (1). O consumo de proteína promove a saciedade e previne a perda de massa muscular, no entanto, dietas com elevado valor proteico podem comprometer a adesão a longo termo, não devendo ser adotadas por pessoas com alterações na função renal (1, 3). Estudos têm vindo a sugerir que um consumo de proteína superior às recomendações (0,8g por kg de peso corporal/dia) é necessário e recomendado para evitar a perda de massa livre de gordura durante o défice energético (3). Este consumo elevado de proteína não levará a efeitos na saúde de pessoas saudáveis, nomeadamente problemas renais, ósseos ou hepáticos (6).",
            "Exercício Físico: Durante o processo de perda de peso, invariavelmente irá ocorrer perda de massa isenta de gordura, em particular perda de massa muscular. No entanto, a proporção de massa muscular perdida poderá ser menor quando, a um correto aporte proteico, se adiciona a prática regular de exercício físico. Por outro lado, o exercício físico sozinho sem mudança de hábitos alimentares, independentemente da intensidade e duração, levará apenas a perdas modestas de peso corporal. Assim, torna-se fundamental a sinergia entre a alimentação e o exercício (4, 5). O exercício físico, mesmo em pequenas quantidades, tem efeitos benéficos na prevenção da gordura visceral durante intervenções para perda de peso (7). Assim, quando falamos em perder massa gorda, o objetivo é reduzir o peso corporal sem comprometer a massa livre de gordura, promovendo a sua manutenção. Para isto, existe a necessidade de combinar exercícios de resistência com exercícios anaeróbicos.",
            "Priorizar alimentos com elevada densidade nutricional: Uma dieta poderá não resultar quando o foco é apenas a redução da ingestão de alimentos que habitualmente ingere. Para o sucesso do plano, é necessário alterar a qualidade das suas refeições, introduzindo vegetais, fontes de proteína magras, gordura e hidratos de carbono complexos de acordo com o seu objetivo, mantendo sempre o défice energético. Assim, irá ficar saciado sem sentir a necessidade de ingerir maior quantidade de alimentos (3). O seu padrão alimentar deverá excluir o consumo de produtos com açúcar adicionado e produtos altamente processados, e incluir fruta, vegetais, produtos lácteos magros e alimentos ricos em fibra (leguminosas, arroz e massa integrais, pão escuro).",
            "Manter um estilo de vida saudável: Intervenções no estilo de vida, incluindo a restrição dietética e o exercício, são estratégias efetivas para a diminuição da gordura visceral e subcutânea (7). A dieta para a manutenção da perda de peso e de massa gorda deve ser fácil de manter, de baixa densidade energética e de elevada densidade nutricional (1). A manutenção de um peso saudável e prevenção da acumulação de gordura na zona abdominal são essenciais para a prevenção de múltiplas doenças crónicas e promoção de um envelhecimento saudável (2). Manter uma vida diária ativa, com escolhas alimentares assertivas, deverá ser um objetivo a longo termo e não apenas uma situação transitória."
           
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