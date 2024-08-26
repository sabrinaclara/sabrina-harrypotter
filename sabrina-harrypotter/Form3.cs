using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sabrina_harrypotter
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            listBox1.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;

            switch (comboBox1.SelectedIndex)
            {

                case 0:

                    pictureBox1.Image = Properties.Resources.harry1;
                    label2.Text = "Harry Potter é um garoto órfão que vive infeliz com seus tios, os Dursleys. Ele recebe uma carta contendo um convite para ingressar em Hogwarts, uma famosa escola especializada em formar jovens bruxos. Inicialmente, Harry é impedido de ler a carta por seu tio, mas logo recebe a visita de Hagrid, o guarda-caça de Hogwarts, que chega para levá-lo até a escola. Harry adentra um mundo mágico que jamais imaginara, vivendo diversas aventuras com seus novos amigos, Rony Weasley e Hermione Granger.";

                    pictureBox3.Visible = false;

                    label3.Visible = false;
                    label4.Visible = false;

                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;

                    radioButton1.Text = "Harry Potter";
                    radioButton2.Text = "Hermione";
                    radioButton3.Text = "Ron Weasley";
                    radioButton4.Text = "Professor Quirrell";
                    radioButton5.Text = "Professor Snape";
                    radioButton6.Text = "Dumbledore";
                    break;

                case 1:

                    pictureBox1.Image = Properties.Resources.harry2;
                    label2.Text = "Após as sofríveis férias na casa dos tios, Harry Potter se prepara para voltar a Hogwarts e começar seu segundo ano na escola de bruxos. Na véspera do início das aulas, a estranha criatura Dobby aparece em seu quarto e o avisa de que voltar é um erro e que algo muito ruim pode acontecer se Harry insistir em continuar os estudos de bruxaria. O garoto, no entanto, está disposto a correr o risco e se livrar do lar problemático.";

                    pictureBox3.Visible = false;

                    label3.Visible = false;
                    label4.Visible = false;

                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;

                    radioButton1.Text = "Harry Potter";
                    radioButton2.Text = "Hermione";
                    radioButton3.Text = "Ron Weasley";
                    radioButton4.Text = "Tom Riddle";
                    radioButton5.Text = "Ginny Weasley";
                    radioButton6.Text = "Dobby";
                    break;

                case 2:

                    pictureBox1.Image = Properties.Resources.harry3;
                    label2.Text = "É o início do terceiro ano na escola de bruxaria Hogwarts. Harry, Ron e Hermione têm muito o que aprender. Mas uma ameaça ronda a escola e ela se chama Sirius Black. Após doze anos encarcerado na prisão de Azkaban, ele consegue escapar e volta para vingar seu mestre, Lord Voldemort. Para piorar, os Dementores, guardas supostamente enviados para proteger Hogwarts e seguir os passos de Black, parecem ser ameaças ainda mais perigosas.";

                    pictureBox3.Visible = false;

                    label3.Visible = false;
                    label4.Visible = false;

                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;

                    radioButton1.Text = "Harry Potter";
                    radioButton2.Text = "Hermione";
                    radioButton3.Text = "Ron Weasley";
                    radioButton4.Text = "Sirius Black";
                    radioButton5.Text = "Remus Lupin";
                    radioButton6.Text = "Severus Snape";
                    break;


                case 3:

                    pictureBox1.Image = Properties.Resources.harry4;
                    label2.Text = "Harry retorna para seu quarto ano na Escola de Magia e Bruxaria de Hogwarts, junto com os seus amigos Ron e Hermione. Desta vez, acontece um torneio entre as três maiores escola de magia, com um participante selecionado de cada escola, pelo Cálice de Fogo. O nome de Harry aparece, mesmo não tendo se inscrito, e ele precisa competir.";

                    pictureBox3.Visible = false;

                    label3.Visible = false;
                    label4.Visible = false;

                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;

                    radioButton1.Text = "Harry Potter";
                    radioButton2.Text = "Hermione";
                    radioButton3.Text = "Ron Weasley";
                    radioButton4.Text = "Cedric Diggory";
                    radioButton5.Text = "Tom Riddle";
                    radioButton6.Text = "Bartemius";
                    break;

                case 4:

                    pictureBox1.Image = Properties.Resources.harry5;
                    label2.Text = "Após um verão desastroso, Harry volta para o seu quinto ano em Hogwarts, um dos mais difíceis que terá de encarar. Pouquíssimos alunos e pais acreditam nele ou em Dumbledore sobre a volta de Voldemort, e uma série interminável de artigos circula dizendo que eles estão completamente malucos. Ainda por cima, Dolores Umbridge, a nova professora de Defesa Contra as Artes das Trevas, prova ser a pessoa mais repugnante que Harry já conheceu.";

                    pictureBox3.Visible = false;

                    label3.Visible = false;
                    label4.Visible = false;

                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;

                    radioButton1.Text = "Harry Potter";
                    radioButton2.Text = "Hermione";
                    radioButton3.Text = "Ron Weasley";
                    radioButton4.Text = "Dolores Umbridge";
                    radioButton5.Text = "Sirius Black";
                    radioButton6.Text = "Dumbledore";
                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.harry6;
                    label2.Text = "No sexto ano de Harry em Hogwarts, Lord Voldemort e seus Comensais da Morte estão criando o terror nos mundos bruxo e trouxa. Dumbledore convence seu velho amigo Horácio Slughorn para retornar a Hogwarts como professor de poções após Harry encontrar um estranho livro escolar. Draco Malfoy se esforça para realizar uma ação destinada por Voldemort, enquanto Dumbledore e Harry secretamente trabalham juntos a fim de descobrir o método para destruir o Lorde das Trevas uma vez por todas.";

                    pictureBox3.Visible = false;

                    label3.Visible = false;
                    label4.Visible = false;

                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;

                    radioButton1.Text = "Harry Potter";
                    radioButton2.Text = "Hermione";
                    radioButton3.Text = "Ron Weasley";
                    radioButton4.Text = "Severus Snape";
                    radioButton5.Text = "Draco Malfoy";
                    radioButton6.Text = "Dumbledore";
                    break;

                case 6:

                    pictureBox1.Image = Properties.Resources.harry7pt1;
                    label2.Text = "Sem a proteção de seus professores, Harry, Rony e Hermione começam uma missão para destruir as horcruxes, que são fontes da imortalidade de Voldemort. Mais do que nunca, eles dependem uns dos outros, mas forças obscuras ameaçam separá-los.";

                    pictureBox3.Visible = false;

                    label3.Visible = false;
                    label4.Visible = false;

                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;

                    radioButton1.Text = "Harry Potter";
                    radioButton2.Text = "Hermione";
                    radioButton3.Text = "Ron Weasley";
                    radioButton4.Text = "Lorde Voldemort";
                    radioButton5.Text = "Rita Skeeter";
                    radioButton6.Text = "Xenophilius";
                    break;

                case 7:

                    pictureBox1.Image = Properties.Resources.harry7pt2;
                    label2.Text = "A batalha entre as forças do bem e do mal da magia alcançam o mundo dos trouxas. O risco nunca foi tão grande, e ninguém está seguro. Harry Potter precisa fazer um sacrifício final conforme o confronto com Lord Voldemort se aproxima.";

                    pictureBox3.Visible = false;

                    label3.Visible = false;
                    label4.Visible = false;

                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;

                    radioButton1.Text = "Harry Potter";
                    radioButton2.Text = "Hermione";
                    radioButton3.Text = "Ron Weasley";
                    radioButton4.Text = "Lorde Voldemort";
                    radioButton5.Text = "Severus Snape";
                    radioButton6.Text = "Minerva";
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                pictureBox1.Visible = true;
            }
            else if (checkBox1.Checked == false)
            {
                pictureBox1.Visible = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    
                    pictureBox3.Visible = true;
                    pictureBox3.Image = Properties.Resources.grifinoria;
                    break;
                
                case 1:

                    pictureBox3.Visible = true;
                    pictureBox3.Image = Properties.Resources.sonserina;
                    break;
                
                case 2:

                    pictureBox3.Visible = true;
                    pictureBox3.Image = Properties.Resources.corvinal;
                    break;
                
                case 3:

                    pictureBox3.Visible = true;
                    pictureBox3.Image = Properties.Resources.lufalufa;
                    break;

                
            }

            //grifinoria textos:

            if (comboBox1.SelectedIndex == 0 && listBox1.SelectedIndex == 0)
            {
                label4.Visible = true;
                label4.Text = "A Grifinória é apresentada como uma das casas mais proativas e corajosas. Harry Potter, Hermione Granger e Ron Weasley são todos selecionados para a Grifinória. A casa se destaca por sua coragem e lealdade, e a amizade dos três protagonistas é um dos principais focos do filme. A Grifinória também desempenha um papel crucial na descoberta da Pedra Filosofal e na luta contra Voldemort, com a ajuda de sua coragem e astúcia.";
            }
            else if (comboBox1.SelectedIndex == 1 && listBox1.SelectedIndex == 0)
            {
                label4.Visible = true;
                label4.Text = "Neste filme, a Grifinória enfrenta desafios relacionados ao ataque da Câmara Secreta. A casa se une para ajudar a resolver o mistério e proteger a escola. Harry, Ron e Hermione, todos da Grifinória, desempenham papéis principais na resolução do enigma da Câmara Secreta e na luta contra o basilisco.";
            }
            else if (comboBox1.SelectedIndex == 2 && listBox1.SelectedIndex == 0)
            {
                label4.Visible = true;
                label4.Text = "A Grifinória continua a mostrar sua bravura e lealdade, com Harry e seus amigos enfrentando perigos relacionados ao prisioneiro fugitivo Sirius Black. A casa se destaca pela coragem de seus membros, e Harry descobre mais sobre seu pai e seu legado enquanto defende Sirius, que é revelado como um aliado e não um traidor.";
            }
            else if (comboBox1.SelectedIndex == 3 && listBox1.SelectedIndex == 0)
            {
                label4.Visible = true;
                label4.Text = "A Grifinória participa do Torneio Tribruxo, onde Harry é inesperadamente escolhido como um dos campeões. A casa demonstra seu espírito de equipe e coragem ao apoiar Harry durante o torneio, apesar das dificuldades e perigos. A rivalidade com a Casa Sonserina também é um tema central, destacando o orgulho e a bravura da Grifinória.";
            }
            else if (comboBox1.SelectedIndex == 4 && listBox1.SelectedIndex == 0)
            {
                label4.Visible = true;
                label4.Text = "A Grifinória desempenha um papel crucial na resistência contra Voldemort e seus seguidores. Harry e seus amigos formam a Armada de Dumbledore para lutar contra o crescente poder das forças das trevas. A casa demonstra sua determinação e coragem ao enfrentar as adversidades impostas pelo Ministério da Magia e pelos Comensais da Morte.";
            }
            else if (comboBox1.SelectedIndex == 5 && listBox1.SelectedIndex == 0)
            {
                label4.Visible = true;
                label4.Text = "A Grifinória se depara com a perda e o luto, especialmente com a morte do Professor Dumbledore. A casa continua a se destacar pela coragem e pela luta contra Voldemort. Harry, Ron e Hermione continuam a buscar pistas sobre as Horcruxes e se preparam para a batalha final.";
            }
            else if (comboBox1.SelectedIndex == 6 && listBox1.SelectedIndex == 0)
            {
                label4.Visible = true;
                label4.Text = "A Grifinória é um símbolo de resistência e esperança. Embora o foco principal esteja na luta contra Voldemort e na busca das Horcruxes, a casa representa a lealdade e o espírito de luta que são fundamentais para a resistência contra as forças das trevas. Harry e seus amigos se refugiam em locais associados à Grifinória, como a casa dos pais de Harry e a tenda da Ordem da Fênix.";
            }
            else if (comboBox1.SelectedIndex == 7 && listBox1.SelectedIndex == 0)
            {
                label4.Visible = true;
                label4.Text = "A Grifinória desempenha um papel central na batalha final contra Voldemort. A casa se une em defesa de Hogwarts e da justiça, lutando bravamente na Batalha de Hogwarts. Muitos dos principais personagens da Grifinória enfrentam seus medos e lutam com coragem. A casa simboliza a vitória do bem sobre o mal e o espírito de sacrifício e bravura que é fundamental para o triunfo final.";
            }

            //sonserina textos:

            if (comboBox1.SelectedIndex == 0 && listBox1.SelectedIndex == 1)
            {
                label4.Visible = true;
                label4.Text = "A Sonserina é introduzida como uma casa rival à Grifinória. O personagem mais notável da Sonserina no filme é Draco Malfoy, que se torna um antagonista frequente para Harry e seus amigos. A rivalidade entre a Sonserina e a Grifinória é estabelecida, e a casa é mostrada como orgulhosa e competitiva. A Sonserina também é associada a objetivos ambiciosos, e seu fundador, Salazar Sonserina, é mencionado como alguém que queria que apenas bruxos de sangue puro estudassem em Hogwarts.";
            }
            else if (comboBox1.SelectedIndex == 1 && listBox1.SelectedIndex == 1)
            {
                label4.Visible = true;
                label4.Text = "A Sonserina desempenha um papel importante no mistério da Câmara Secreta. O antagonista principal, Tom Riddle (mais tarde conhecido como Voldemort), tem uma ligação com a casa, sendo um ex-aluno da Sonserina. A casa é implicada nos ataques que ocorrem na escola, e o próprio Draco Malfoy é mostrado como hostil e provocador. Além disso, é revelado que a Câmara Secreta foi criada por Salazar Sonserina, um antigo membro da casa.";
            }
            else if (comboBox1.SelectedIndex == 2 && listBox1.SelectedIndex == 1)
            {
                label4.Visible = true;
                label4.Text = "A Sonserina, representada por Draco Malfoy e seus seguidores, continua a ser uma rival para a Grifinória. O filme destaca a hostilidade entre as casas, com Malfoy e seus amigos atacando Harry e seus aliados. O personagem Severus Snape, professor de Poções e membro da Sonserina, tem um papel mais proeminente como uma figura complexa que, apesar de sua aparente hostilidade, tem suas próprias motivações e lealdades.";
            }
            else if (comboBox1.SelectedIndex == 3 && listBox1.SelectedIndex == 1)
            {
                label4.Visible = true;
                label4.Text = "A Sonserina está bastante envolvida no Torneio Tribruxo, especialmente através de seu aluno, Viktor Krum, que é um dos campeões selecionados de Durmstrang. Embora Krum não seja um aluno da Sonserina, a casa é representada pelo seu orgulho e ambição, além de sua rivalidade contínua com a Grifinória. Draco Malfoy e seus amigos continuam a criar conflitos, e a casa é associada à intriga e ao desejo de poder.";
            }
            else if (comboBox1.SelectedIndex == 4 && listBox1.SelectedIndex == 1)
            {
                label4.Visible = true;
                label4.Text = "Neste filme, a Sonserina é mais uma vez uma casa rival à Grifinória. Draco Malfoy começa a se envolver com atividades mais sinistras, sugerindo uma ligação com as forças das trevas. A casa é mostrada como sendo de importância estratégica para Voldemort e seus seguidores, e a tensão entre as casas continua a aumentar. A Sonserina também é implicada em atitudes que vão contra a resistência liderada por Harry e seus amigos.";
            }
            else if (comboBox1.SelectedIndex == 5 && listBox1.SelectedIndex == 1)
            {
                label4.Visible = true;
                label4.Text = "A influência da Sonserina se torna mais evidente, pois Draco Malfoy é central para a trama, tentando cumprir uma missão para Voldemort. O filme revela mais sobre a conexão entre a Sonserina e as forças das trevas, com Draco sendo manipulado para assumir um papel importante na trama de Voldemort. A casa é apresentada como um centro de atividades relacionadas à ascensão de Voldemort, e Severus Snape, também da Sonserina, tem um papel crucial na história.";
            }
            else if (comboBox1.SelectedIndex == 6 && listBox1.SelectedIndex == 1)
            {
                label4.Visible = true;
                label4.Text = "A Sonserina, e especialmente seus membros, estão envolvidos no crescente domínio dos Comensais da Morte. A casa é associada à influência de Voldemort, e há um foco em como a ambição e o desejo de poder dos membros da Sonserina afetam o cenário geral da luta contra as forças das trevas. A rivalidade com a Grifinória continua, e a casa é vista como uma fonte de apoio para os Comensais da Morte.";
            }
            else if (comboBox1.SelectedIndex == 7 && listBox1.SelectedIndex == 1)
            {
                label4.Visible = true;
                label4.Text = "Na batalha final de Hogwarts, a Sonserina, representada principalmente pelos Comensais da Morte e seus apoiadores, desempenha um papel antagonista. A casa é associada às forças de Voldemort e está diretamente envolvida na luta contra as forças do bem. A batalha revela a divisão final entre os ideais da Sonserina e aqueles que lutam pela justiça e igualdade.";
            }

            //corvinal textos:

            if (comboBox1.SelectedIndex == 0 && listBox1.SelectedIndex == 2)
            {
                label4.Visible = true;
                label4.Text = "Neste filme, a Corvinal é mencionada brevemente, principalmente como uma das casas rivais da Grifinória. A casa é representada por alguns personagens secundários, como Cho Chang, que aparece no final do filme, embora seu papel seja mais destacado nos filmes seguintes. A Corvinal é associada a um ambiente acadêmico e intelectual, mas não desempenha um papel significativo na trama principal.";
            }
            else if (comboBox1.SelectedIndex == 1 && listBox1.SelectedIndex == 2)
            {
                label4.Visible = true;
                label4.Text = "A Corvinal é mencionada em relação à história da Câmara Secreta e aos ataques que ocorrem na escola. O mistério envolvendo a Câmara Secreta e o basilisco afeta todos os alunos de Hogwarts, incluindo os da Corvinal. É revelado que a fundadora da Corvinal, Rowena Corvinal, teve um papel importante no passado da escola, e um dos itens deixados por ela, uma diadema, é um dos Horcruxes de Voldemort.";
            }
            else if (comboBox1.SelectedIndex == 2 && listBox1.SelectedIndex == 2)
            {
                label4.Visible = true;
                label4.Text = "A Corvinal é representada de forma mais visível neste filme, especialmente através do personagem de Cho Chang, que é uma aluna da casa. Cho é um interesse romântico temporário de Harry e é mostrada como uma estudante inteligente e respeitável. A Corvinal, no entanto, ainda não desempenha um papel central na trama principal.";
            }
            else if (comboBox1.SelectedIndex == 3 && listBox1.SelectedIndex == 2)
            {
                label4.Visible = true;
                label4.Text = "A Corvinal tem um papel mais destacado neste filme através de Cho Chang, que participa do Torneio Tribruxo como membro da equipe de quadribol da Corvinal. A casa é representada com sua natureza acadêmica e suas habilidades em quadribol. Cho também se torna um interesse romântico de Harry e é um exemplo da diversidade e da inteligência dos membros da Corvinal.";
            }
            else if (comboBox1.SelectedIndex == 4 && listBox1.SelectedIndex == 2)
            {
                label4.Visible = true;
                label4.Text = "Neste filme, a Corvinal continua a ser representada por Cho Chang, que se torna um membro importante da Armada de Dumbledore, a organização secreta formada por Harry para combater as forças das trevas. A participação de Cho na Armada destaca o compromisso da Corvinal com a luta pela justiça e a sua disposição para enfrentar o mal, embora o foco principal esteja na formação e nas atividades da Armada.";
            }
            else if (comboBox1.SelectedIndex == 5 && listBox1.SelectedIndex == 2)
            {
                label4.Visible = true;
                label4.Text = "A Corvinal é novamente representada por Cho Chang, que aparece brevemente no filme. No entanto, a casa não desempenha um papel central na trama. O foco está mais na luta crescente contra Voldemort e nas revelações sobre os Horcruxes, com menos ênfase na Corvinal em si.";
            }
            else if (comboBox1.SelectedIndex == 6 && listBox1.SelectedIndex == 2)
            {
                label4.Visible = true;
                label4.Text = "Neste filme, a Corvinal não é destacada significativamente. A história foca mais na busca de Harry e seus amigos pelos Horcruxes e na crescente ameaça de Voldemort. A casa é mencionada em contexto acadêmico, mas os personagens principais da Corvinal não têm papéis centrais na narrativa.";
            }
            else if (comboBox1.SelectedIndex == 7 && listBox1.SelectedIndex == 2)
            {
                label4.Visible = true;
                label4.Text = "Na batalha final de Hogwarts, a Corvinal é uma das casas que se une na luta contra os Comensais da Morte. A casa contribui para a defesa de Hogwarts e para a resistência geral, mas, novamente, não há um foco significativo em personagens individuais da Corvinal. A casa é vista como parte do esforço coletivo para proteger a escola e derrotar Voldemort.";
            }


            //lufalufa textos:

            if (comboBox1.SelectedIndex == 0 && listBox1.SelectedIndex == 3)
            {
                label4.Visible = true;
                label4.Text = "Neste filme, a Lufa-Lufa é mencionada brevemente. A casa é representada por alguns personagens secundários, como Cedric Diggory, que é apresentado como um aluno respeitável e um dos campeões do Torneio Tribruxo em filmes futuros. A Lufa-Lufa é mostrada como uma casa que valoriza a lealdade e o trabalho em equipe, mas não tem um papel central na trama principal deste filme.";
            }
            else if (comboBox1.SelectedIndex == 1 && listBox1.SelectedIndex == 3)
            {
                label4.Visible = true;
                label4.Text = "A Lufa-Lufa é mencionada em relação aos eventos envolvendo a Câmara Secreta e o mistério do basilisco. A casa é afetada pelos ataques que ocorrem na escola, mas não desempenha um papel central na resolução do mistério. A lealdade e o caráter dos membros da Lufa-Lufa são destacados, especialmente em como eles lidam com as adversidades.";
            }
            else if (comboBox1.SelectedIndex == 2 && listBox1.SelectedIndex == 3)
            {
                label4.Visible = true;
                label4.Text = "Neste filme, a Lufa-Lufa é representada principalmente por Cedric Diggory e Ninfadora Tonks. Cedric é introduzido como um personagem importante da casa e é mostrado como um aluno honrado e justo. A presença de Tonks, que é uma bruxa talentosa e leal da Lufa-Lufa, também destaca os valores da casa. A Lufa-Lufa, no entanto, não tem um papel central na trama principal, que se concentra na fuga de Sirius Black e nas revelações sobre o passado de Harry.";
            }
            else if (comboBox1.SelectedIndex == 3 && listBox1.SelectedIndex == 3)
            {
                label4.Visible = true;
                label4.Text = "A Lufa-Lufa tem um papel significativo neste filme através de Cedric Diggory, que é escolhido como um dos campeões do Torneio Tribruxo. A casa se destaca pela representação de Cedric como um exemplo de coragem e dignidade. Cedric é um adversário respeitável para Harry e demonstra a bravura e a integridade associadas à Lufa-Lufa. A casa também é lembrada com carinho após a trágica morte de Cedric, que afeta profundamente os outros personagens.";
            }
            else if (comboBox1.SelectedIndex == 4 && listBox1.SelectedIndex == 3)
            {
                label4.Visible = true;
                label4.Text = "Neste filme, a Lufa-Lufa é representada por Ninfadora Tonks e seu papel na resistência contra Voldemort. Tonks é uma membro ativa da Ordem da Fênix, demonstrando o compromisso da Lufa-Lufa com a luta pela justiça e pelo bem. A casa é mostrada como leal e dedicada à causa da Ordem, com Tonks usando suas habilidades para ajudar a proteger Hogwarts e combater as forças das trevas.";
            }
            else if (comboBox1.SelectedIndex == 5 && listBox1.SelectedIndex == 3)
            {
                label4.Visible = true;
                label4.Text = "A Lufa-Lufa é representada novamente por Ninfadora Tonks, que continua a desempenhar um papel ativo na luta contra Voldemort. A casa é mostrada em contexto de lealdade e dedicação à causa da Ordem da Fênix. Cedric Diggory também é lembrado com carinho, e a casa demonstra sua persistência e coragem, mesmo em tempos difíceis.";
            }
            else if (comboBox1.SelectedIndex == 6 && listBox1.SelectedIndex == 3)
            {
                label4.Visible = true;
                label4.Text = "Neste filme, a Lufa-Lufa não tem um papel proeminente na trama principal, que se concentra na busca de Harry e seus amigos pelos Horcruxes. No entanto, a casa é mencionada brevemente, e os valores de lealdade e trabalho árduo dos membros da Lufa-Lufa são destacados através das lembranças de Cedric e da presença de Tonks na resistência.";
            }
            else if (comboBox1.SelectedIndex == 7 && listBox1.SelectedIndex == 3)
            {
                label4.Visible = true;
                label4.Text = "Na batalha final de Hogwarts, a Lufa-Lufa, representada por personagens como Ninfadora Tonks, contribui para a defesa da escola. Tonks luta bravamente, e a casa como um todo se une na luta contra as forças de Voldemort. O papel da Lufa-Lufa é destacado pela coragem e lealdade de seus membros, que são fundamentais na batalha final e na defesa de Hogwarts.";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //fotos:

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    
                    pictureBox2.Image = Properties.Resources.hermione1;
                    break;
                
                case 1:
                    pictureBox2.Image = Properties.Resources.hermione2;
                    break;

                case 2:
                    pictureBox2.Image = Properties.Resources.hermione3;
                    break;
                
                case 3:
                    pictureBox2.Image = Properties.Resources.hermione4;
                    break;
                
                case 4:
                    pictureBox2.Image = Properties.Resources.hermione5;
                    break;
                
                case 5:
                    pictureBox2.Image = Properties.Resources.hermione6;
                    break;

                case 6:
                    pictureBox2.Image = Properties.Resources.hermione7;
                    break;
                
                case 7:
                    pictureBox2.Image = Properties.Resources.hermione8;
                    break;
            }
            
            if (radioButton2.Checked == true) {
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox2.Visible = false;
            }

            //textos

            if (comboBox1.SelectedIndex == 0 && radioButton2.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Hermione é uma das melhores amigas de Harry e Ron, conhecida por sua inteligência e habilidades acadêmicas. Ela é uma bruxa talentosa e dedicada. Hermione usa seus conhecimentos para ajudar a resolver o enigma da Pedra Filosofal. Sua astúcia e habilidades mágicas são essenciais para superar os obstáculos.";
            }
            else if (comboBox1.SelectedIndex == 1 && radioButton2.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Hermione é uma estudante brilhante e amiga fiel, com um intelecto excepcional e habilidades mágicas avançadas. Antes de ser petrificada, Hermione ajuda a identificar a natureza do basilisco e a solução para os ataques. Sua inteligência é crucial para resolver o mistério.";
            }
            else if (comboBox1.SelectedIndex == 2 && radioButton2.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Hermione é uma amiga inteligente e confiável, com um forte senso de moralidade e habilidades mágicas. Nesse filme, usa um vira-tempo para ajudar a resolver a situação envolvendo Sirius Black e Buckbeak. Sua intervenção é crucial para a resolução do mistério.";
            }
            else if (comboBox1.SelectedIndex == 3 && radioButton2.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Hermione ajuda Harry a se preparar para as tarefas e enfrenta sua rivalidade com Viktor Krum e outros competidores. Seu apoio é vital para Harry.";
            }
            else if (comboBox1.SelectedIndex == 4 && radioButton2.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Ajuda a formar a Armada de Dumbledore, enfrenta a opressão de Umbridge e participa da batalha no Ministério da Magia. Sua inteligência é vital para a resistência.";
            }
            else if (comboBox1.SelectedIndex == 5 && radioButton2.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Em O enigma do Principe, Hermione ajuda Harry e Dumbledore na busca pelos Horcruxes, além de lidar com suas próprias questões emocionais e relacionamentos.";
            }
            else if (comboBox1.SelectedIndex == 6 && radioButton2.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Hermione acompanha Harry e Ron na missão para encontrar e destruir os Horcruxes. Ela usa seus conhecimentos e habilidades para desvendar pistas e proteger seus amigos durante a fuga.";
            }
            else if (comboBox1.SelectedIndex == 7 && radioButton2.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Hermione continua a desempenhar um papel vital na destruição dos Horcruxes e na luta contra os Comensais da Morte. Ela é essencial para a sobrevivência e sucesso do grupo durante a batalha final em Hogwarts.";
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //fotos:
            
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    
                    pictureBox2.Image = Properties.Resources.harryfilme1;
                    break;

                case 1:
                    
                    pictureBox2.Image = Properties.Resources.harryfilme2;
                    break;

                case 2:
                    pictureBox2.Image = Properties.Resources.harryfilme3;
                    break;

                case 3:
                    pictureBox2.Image = Properties.Resources.harryfilme4;
                    break;

                case 4:
                    pictureBox2.Image = Properties.Resources.harryfilme5;
                    break;

                case 5:
                    pictureBox2.Image = Properties.Resources.harryfilme6;
                    break;

                case 6:
                    pictureBox2.Image = Properties.Resources.harryfilme7;
                    break;

                case 7:
                    pictureBox2.Image = Properties.Resources.harryfilme8;
                    break;
            }

            if (radioButton1.Checked == true)
            {
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox2.Visible = false;
            }

            //terminar abaixo: 
            //(textos dos personagens)
            
            if (comboBox1.SelectedIndex == 0 && radioButton1.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Harry Potter é o protagonista da série, conhecido como 'O Menino que Sobreviveu' após sobreviver ao ataque de Voldemort quando bebê. Ele é corajoso, leal e tem um forte senso de justiça. Nesse filme, Harry descobre que é um bruxo, entra para Hogwarts e enfrenta os perigos relacionados à Pedra Filosofal, protegendo a escola de Voldemort.";
            }
            else if (comboBox1.SelectedIndex == 1 && radioButton1.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Harry enfrenta novos desafios em seu segundo ano em Hogwarts, descobrindo a verdade sobre a Câmara Secreta e enfrentando o basilisco. Harry investiga os ataques na escola e derrota o basilisco para salvar Ginny Weasley e proteger a Câmara Secreta.";
            }
            else if (comboBox1.SelectedIndex == 2 && radioButton1.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Harry continua sua jornada como bruxo, enfrentando a ameaça de Sirius Black e lidando com a influência dos Dementadores. Investiga a verdade sobre Sirius Black e enfrenta os Dementadores. Descobre que Sirius é seu padrinho e que é inocente das acusações contra ele.";
            }
            else if (comboBox1.SelectedIndex == 3 && radioButton1.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Harry participa do Torneio Tribruxo e enfrenta novos desafios enquanto lida com o retorno iminente de Voldemort. Participa das tarefas do torneio, enfrenta perigos mortais e luta contra Voldemort no final, marcando o retorno do vilão.";
            }
            else if (comboBox1.SelectedIndex == 4 && radioButton1.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Harry lidera a resistência contra o regime opressivo de Dolores Umbridge e tenta alertar o mundo bruxo sobre o retorno de Voldemort. Forma a Armada de Dumbledore, enfrenta os desafios impostos por Umbridge e luta contra os Comensais da Morte na batalha no Ministério da Magia.";
            }
            else if (comboBox1.SelectedIndex == 5 && radioButton1.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Harry continua sua busca contra Voldemort, agora focado na investigação dos Horcruxes e enfrentando desafios pessoais. Investiga o passado de Voldemort com a ajuda de Dumbledore, aprende sobre os Horcruxes e enfrenta a crescente ameaça de Voldemort.";
            }
            else if (comboBox1.SelectedIndex == 6 && radioButton1.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Harry está em uma missão para encontrar e destruir os Horcruxes de Voldemort, que são objetos contendo fragmentos de sua alma. Ele enfrenta vários desafios e perigos enquanto está fugitivo, sempre à procura de pistas sobre os Horcruxes.";
            }
            else if (comboBox1.SelectedIndex == 7 && radioButton1.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Harry culmina sua missão de destruir os Horcruxes e enfrenta Voldemort em uma batalha final épica em Hogwarts. Sua jornada culmina em uma confrontação direta com o vilão e na resolução da luta pelo bem.";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.BackgroundImage = Properties.Resources.pause;
                var musica = new SoundPlayer("D:\\2ano\\DS\\sabrina-harrypotter\\sabrina-harrypotter\\resources\\musica_tema.wav");
                musica.Play();
                musica.PlayLooping();
            }
            else
            {
                checkBox2.BackgroundImage = Properties.Resources.play;
                var musica = new SoundPlayer("D:\\2ano\\DS\\sabrina-harrypotter\\sabrina-harrypotter\\resources\\musica_tema.wav");
                musica.Stop();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //fotos:

            switch (comboBox1.SelectedIndex)
            {
                case 0:

                    pictureBox2.Image = Properties.Resources.ron1;
                    break;

                case 1:
                    pictureBox2.Image = Properties.Resources.ron2;
                    break;

                case 2:
                    pictureBox2.Image = Properties.Resources.ron3;
                    break;

                case 3:
                    pictureBox2.Image = Properties.Resources.ron4;
                    break;

                case 4:
                    pictureBox2.Image = Properties.Resources.ron5;
                    break;

                case 5:
                    pictureBox2.Image = Properties.Resources.ron6;
                    break;

                case 6:
                    pictureBox2.Image = Properties.Resources.ron7;
                    break;

                case 7:
                    pictureBox2.Image = Properties.Resources.ron8;
                    break;
            }

            if (radioButton3.Checked == true)
            {
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox2.Visible = false;
            }

            //textos

            if (comboBox1.SelectedIndex == 0 && radioButton3.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Ron é um amigo leal de Harry e Hermione, conhecido por seu senso de humor e coragem. Ele vem de uma família grande e amorosa. Ron participa do jogo de xadrez bruxo, onde seu sacrifício é crucial para que Harry e Hermione avancem na proteção da Pedra Filosofal.";
            }
            else if (comboBox1.SelectedIndex == 1 && radioButton3.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Ron continua a ser um amigo leal e corajoso, enfrentando desafios ao lado de Harry e Hermione. Ron ajuda a enfrentar o basilisco e apoia Harry na investigação da Câmara Secreta. Sua lealdade e coragem são vitais para a trama.";
            }
            else if (comboBox1.SelectedIndex == 2 && radioButton3.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Ron enfrenta seus próprios desafios durante o ano letivo, incluindo a questão de seu ratinho, Scabbers. Apoia Harry na investigação sobre Sirius e enfrenta a revelação de que Scabbers é na verdade Peter Pettigrew.";
            }
            else if (comboBox1.SelectedIndex == 3 && radioButton3.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Ron continua sendo um amigo leal que enfrenta desafios pessoais durante o torneio. Apoia Harry durante o torneio e lida com seus sentimentos de ciúmes e rivalidade. Sua amizade e coragem são importantes para a trama.";
            }
            else if (comboBox1.SelectedIndex == 4 && radioButton3.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Participa da Armada de Dumbledore, apoia Harry na luta contra Umbridge e enfrenta os Comensais da Morte na batalha final.";
            }
            else if (comboBox1.SelectedIndex == 5 && radioButton3.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Ron ajuda a enfrentar os desafios que surgem com o retorno de Voldemort e lida com questões pessoais e relacionamentos complicados.";
            }
            else if (comboBox1.SelectedIndex == 6 && radioButton3.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Ron ajuda Harry e Hermione em sua busca pelos Horcruxes. Ele enfrenta desafios pessoais e sentimentos de ciúmes, mas sua lealdade e coragem são fundamentais para a missão. Sua relação com Hermione e Harry evolui ao longo da jornada.";
            }
            else if (comboBox1.SelectedIndex == 7 && radioButton3.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Ron participa ativamente da batalha final, ajudando a destruir os Horcruxes restantes e enfrentando os perigos em Hogwarts. Sua bravura e lealdade são fundamentais para a vitória final.";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //fotos:

            switch (comboBox1.SelectedIndex)
            {
                case 0:

                    pictureBox2.Image = Properties.Resources.quirrel;
                    break;

                case 1:
                    pictureBox2.Image = Properties.Resources.tomriddle;
                    break;

                case 2:
                    pictureBox2.Image = Properties.Resources.sirius;
                    break;

                case 3:
                    pictureBox2.Image = Properties.Resources.cedric;
                    break;

                case 4:
                    pictureBox2.Image = Properties.Resources.umbridge;
                    break;

                case 5:
                    pictureBox2.Image = Properties.Resources.snape;
                    break;

                case 6:
                    pictureBox2.Image = Properties.Resources.voldemort;
                    break;

                case 7:
                    pictureBox2.Image = Properties.Resources.voldemort;
                    break;
            }

            if (radioButton4.Checked == true)
            {
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox2.Visible = false;
            }

            //textos:
           
            if (comboBox1.SelectedIndex == 0 && radioButton4.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Quirrell é o professor de Defesa Contra as Artes das Trevas, inicialmente visto como inofensivo e um pouco desajeitado. Na verdade, ele é um traidor trabalhando para Voldemort. No filme, Quirrell tenta roubar a Pedra Filosofal para ressuscitar Voldemort. Sua verdadeira lealdade é revelada no final, quando ele é confrontado por Harry.";
            }
            else if (comboBox1.SelectedIndex == 1 && radioButton4.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Tom Riddle é a forma jovem de Voldemort e o verdadeiro vilão por trás dos eventos na Câmara Secreta. Ele é uma manifestação de suas intenções malignas. Manipula Ginny Weasley e revela a verdade sobre a Câmara Secreta e o basilisco. É derrotado por Harry no final.";
            }
            else if (comboBox1.SelectedIndex == 2 && radioButton4.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Sirius Black é o padrinho de Harry e um fugitivo que busca limpar seu nome após ser injustamente preso. Revela a verdade sobre a traição de Pettigrew e tenta ajudar Harry. Sua inocência e conexão com Harry são centrais para a trama.";
            }
            else if (comboBox1.SelectedIndex == 3 && radioButton4.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Cedric é um campeão da Lufa-Lufa no Torneio Tribruxo, conhecido por sua coragem e respeito. Ajuda Harry durante o torneio e é uma vítima dos planos de Voldemort. Sua morte marca o retorno de Voldemort e é um evento crucial.";
            }
            else if (comboBox1.SelectedIndex == 4 && radioButton4.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Umbridge é uma funcionária do Ministério da Magia que impõe um regime tirânico em Hogwarts. Ela é uma antagonista opressiva e cruel. Impõe regras severas e controla a escola com um regime opressor, o que leva Harry e seus amigos a formarem a Armada de Dumbledore.";
            }
            else if (comboBox1.SelectedIndex == 5 && radioButton4.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Snape é o professor de Poções com uma lealdade complexa e uma relação tensa com Harry. Revela ser o verdadeiro Mestre das Artes das Trevas e desempenha um papel crucial na proteção de Hogwarts e na luta contra Voldemort.";
            }
            else if (comboBox1.SelectedIndex == 6 && radioButton4.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Voldemort é o principal antagonista da série, um bruxo das trevas que busca dominar o mundo bruxo e eliminar Harry Potter. Voldemort continua a buscar o poder e a imortalidade, procurando os Horcruxes restantes e exercendo seu controle sobre o Ministério da Magia. Ele aparece em momentos-chave e sua ameaça constante é um pano de fundo para as ações dos heróis.";
            }
            else if (comboBox1.SelectedIndex == 7 && radioButton4.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Voldemort é o principal antagonista, o bruxo das trevas que busca a dominação total e a imortalidade. Voldemort enfrenta Harry em uma batalha final, onde seu destino está selado. Sua busca pelo poder e imortalidade culmina na batalha em Hogwarts, onde ele é finalmente derrotado.";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //fotos:

            switch (comboBox1.SelectedIndex)
            {
                case 0:

                    pictureBox2.Image = Properties.Resources.snape;
                    break;

                case 1:
                    pictureBox2.Image = Properties.Resources.ginny;
                    break;

                case 2:
                    pictureBox2.Image = Properties.Resources.lupin;
                    break;

                case 3:
                    pictureBox2.Image = Properties.Resources.tomriddle;
                    break;

                case 4:
                    pictureBox2.Image = Properties.Resources.sirius;
                    break;

                case 5:
                    pictureBox2.Image = Properties.Resources.draco;
                    break;
               
                case 6:
                    pictureBox2.Image = Properties.Resources.skeeter;
                    break;

                case 7:
                    pictureBox2.Image = Properties.Resources.snape;
                    break;
            }

            if (radioButton5.Checked == true)
            {
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox2.Visible = false;
            }

            //textos:

            if (comboBox1.SelectedIndex == 0 && radioButton5.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Severus Snape é o professor de Poções e é muitas vezes visto como antagonista devido à sua atitude hostil em relação a Harry. No entanto, sua verdadeira lealdade é mais complexa. Snape parece hostil, mas está secretamente tentando proteger a Pedra Filosofal e ajudar Harry, embora suas intenções não sejam completamente claras neste filme.";
            }
            else if (comboBox1.SelectedIndex == 1 && radioButton5.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Ginny é uma estudante da casa Weasley e irmã mais nova de Ron. Ela se torna um alvo dos ataques da Câmara Secreta. Possuída por Tom Riddle, Ginny é resgatada por Harry, e sua recuperação é crucial para resolver o mistério da Câmara Secreta.";
            }
            else if (comboBox1.SelectedIndex == 2 && radioButton5.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Lupin é o professor de Defesa Contra as Artes das Trevas e um lobisomem, que é amigo de Sirius Black e um mentor para Harry. Ensina Harry a enfrentar os Dementadores e ajuda a esclarecer a verdade sobre Sirius e Pettigrew. Sua presença é crucial para a trama.";
            }
            else if (comboBox1.SelectedIndex == 3 && radioButton5.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Voldemort é o principal antagonista da série, buscando retomar seu poder e eliminar Harry. Ele é um bruxo das trevas temido. Retorna ao poder e enfrenta Harry em um duelo final no final do filme, marcando seu retorno e a intensificação da luta contra as trevas.";
            }
            else if (comboBox1.SelectedIndex == 4 && radioButton5.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Sirius é o padrinho de Harry e um membro da Ordem da Fênix, lutando contra Voldemort e tentando proteger Harry. Fornece orientação e apoio a Harry e enfrenta os Comensais da Morte na batalha final. Sua morte trágica é um ponto de virada emocional.";
            }
            else if (comboBox1.SelectedIndex == 5 && radioButton5.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Draco é um estudante da Sonserina que enfrenta um conflito interno ao tentar cumprir uma missão para Voldemort. Trabalha para cumprir a missão dada por Voldemort e sua jornada interna é central para a dinâmica do filme e os eventos que se desenrolam.";
            }
            else if (comboBox1.SelectedIndex == 6 && radioButton5.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Rita Skeeter é uma jornalista sensacionalista conhecida por suas reportagens distorcidas e intrusivas. Sua presença é mais evidente na parte inicial do filme, onde suas reportagens e intrigas contribuem para a atmosfera de medo e incerteza que permeia o mundo bruxo.";
            }
            else if (comboBox1.SelectedIndex == 7 && radioButton5.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Snape é o professor de Poções que tem uma lealdade complexa e um passado sombrio. Seu verdadeiro papel na história é revelado mais profundamente neste filme. Snape é revelado como um herói trágico, cuja lealdade está com Dumbledore e Harry, apesar de sua aparência de antagonista. Seus esforços e sacrifícios são fundamentais para a derrota de Voldemort.";
            }
        
    }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //fotos:

            switch (comboBox1.SelectedIndex)
            {
                case 0:

                    pictureBox2.Image = Properties.Resources.dumbledore;
                    break;

                case 1:
                    pictureBox2.Image = Properties.Resources.dobby;
                    break;

                case 2:
                    pictureBox2.Image = Properties.Resources.snape;
                    break;

                case 3:
                    pictureBox2.Image = Properties.Resources.bartemius;
                    break;

                case 4:
                    pictureBox2.Image = Properties.Resources.dumbledore;
                    break;

                case 5:
                    pictureBox2.Image = Properties.Resources.dumbledore;
                    break;

                case 6:
                    pictureBox2.Image = Properties.Resources.xenophilius;
                    break;

                case 7:
                    pictureBox2.Image = Properties.Resources.minerva;
                    break;
            }

            if (radioButton6.Checked == true)
            {
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox2.Visible = false;
            }

            //textos:

            if (comboBox1.SelectedIndex == 0 && radioButton6.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Albus Dumbledore é o sábio e poderoso diretor de Hogwarts, mentor de Harry e líder na luta contra Voldemort. Dumbledore orienta Harry indiretamente e toma decisões estratégicas para proteger a escola e a Pedra Filosofal, influenciando a segurança de Hogwarts.";
            }
            else if (comboBox1.SelectedIndex == 1 && radioButton6.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Dobby é um elfo doméstico que serve a família Malfoy e busca ajudar Harry, apesar de suas próprias limitações e desafios. Dobby adverte Harry sobre os perigos e tenta evitar que ele volte para Hogwarts. Sua ajuda é importante para a segurança de Harry.";
            }
            else if (comboBox1.SelectedIndex == 2 && radioButton6.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Snape é o professor de Poções com uma relação tensa com Harry, cuja lealdade é ambígua. Protege Harry dos Dementadores e desempenha um papel importante na segurança de Hogwarts, apesar de sua atitude negativa.";
            }
            else if (comboBox1.SelectedIndex == 3 && radioButton6.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Bartemius é um comensal da morte que se disfarça como Alastor Moody e é um dos principais vilões do filme. Manipula o torneio para garantir que Harry seja transportado para Voldemort. Sua traição e plano são centrais para a trama.";
            }
            else if (comboBox1.SelectedIndex == 4 && radioButton6.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Dumbledore é o diretor de Hogwarts e um líder estratégico na luta contra Voldemort. Ele é sábio e poderoso. Orienta Harry e a Ordem da Fênix, fornece suporte e estratégia para enfrentar Voldemort, e sua liderança é crucial para a proteção da escola e a resistência.";
            }
            else if (comboBox1.SelectedIndex == 5 && radioButton6.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Dumbledore é o mentor de Harry e um líder na luta contra Voldemort, conhecido por sua sabedoria e poder. Orienta Harry na busca pelos Horcruxes, toma decisões estratégicas para proteger a escola e sua morte impacta profundamente a trama e o curso dos eventos.";
            }
            else if (comboBox1.SelectedIndex == 6 && radioButton6.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Xenophilius é o pai de Luna Lovegood e um entusiasta dos fenômenos mágicos pouco convencionais. Ele ajuda Harry, Hermione e Ron fornecendo informações sobre as Relíquias da Morte e o símbolo que elas representam. Sua ajuda é crucial para entender a importância das Relíquias e a missão em andamento.";
            }
            else if (comboBox1.SelectedIndex == 7 && radioButton6.Checked == true)
            {
                label3.Visible = true;
                label3.Text = "Minerva McGonagall é a professora de Transfiguração e a nova diretora de Hogwarts após a morte de Dumbledore. Ela é firme, justa e protetora da escola. McGonagall lidera a defesa de Hogwarts contra os Comensais da Morte e mostra grande coragem e liderança durante a batalha final. Sua determinação em proteger a escola é crucial para a vitória dos heróis.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
                Form3 harrypotter = new Form3();
                harrypotter.ShowDialog();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }

}
