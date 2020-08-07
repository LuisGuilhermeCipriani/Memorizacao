using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorizacao.controller
{
    class VerboController
    {
        private Verbo verbo;
        private List<Verbo> listaVerbos;
        private List<Verbo> listaCorretos;
        private List<Verbo> listaIncorretos;

        public VerboController()
        {
            verbo = new Verbo();
            listaVerbos = new List<Verbo>();
            listaCorretos = new List<Verbo>();
            listaIncorretos = new List<Verbo>();
        }

        public Verbo getVerbo()
        {
            return verbo;
        }

        public List<Verbo> getListaVerbos()
        {
            return listaVerbos;
        }

        public List<Verbo> getlistaCorretos()
        {
            return listaCorretos;
        }

        public List<Verbo> getlistaIncorretos()
        {
            return listaIncorretos;
        }

        public void preencheListaVerbos()
        {
            Verbo verbo1 = new Verbo(1, "Arise", "To arise", "Arose", "Arisen", "Erguer, levantar");
            listaVerbos.Add(verbo1);

            Verbo verbo2 = new Verbo(2, "Awake", "To awake", "Awoke", "Awoken", "Acordar, despertar");
            listaVerbos.Add(verbo2);

            Verbo verbo3 = new Verbo(3, "Be", "To be", "Was / were", "Been", "Ser, estar");
            listaVerbos.Add(verbo3);

            Verbo verbo4 = new Verbo(4, "Bear", "To bear", "Bore", "Borne", "Suportar, aguentar");
            listaVerbos.Add(verbo4);

            Verbo verbo5 = new Verbo(5, "Beat", "To beat", "Beat", "Beaten", "Bater, espancar, superar, vibrar, palpitar");
            listaVerbos.Add(verbo5);

            Verbo verbo6 = new Verbo(6, "Become", "To become", "Became", "Become", "Tornar-se");
            listaVerbos.Add(verbo6);

            Verbo verbo7 = new Verbo(7, "Begin", "To begin", "Began", "Begun", "Começar, iniciar");
            listaVerbos.Add(verbo7);

            Verbo verbo8 = new Verbo(8, "Bend", "To bend", "Bent", "Bent", "Curvar, entortar, franzir");
            listaVerbos.Add(verbo8);

            Verbo verbo9 = new Verbo(9, "Bet", "To bet", "Bet", "Bet", "Apostar");
            listaVerbos.Add(verbo9);

            Verbo verbo10 = new Verbo(10, "Bite", "To bite", "Bit", "Bitten", "Morder, engolir a isca");
            listaVerbos.Add(verbo10);

            Verbo verbo11 = new Verbo(11, "Bleed", "To bleed", "Bled", "Bled", "Sangrar");
            listaVerbos.Add(verbo11);

            Verbo verbo12 = new Verbo(12, "Blow", "To blow", "Blew", "Blown", "Soprar, assobiar");
            listaVerbos.Add(verbo12);

            Verbo verbo13 = new Verbo(13, "Break", "To break", "Broke", "Broken", "Quebrar, romper");
            listaVerbos.Add(verbo13);

            Verbo verbo14 = new Verbo(14, "Bring", "To bring", "Brought", "Brought", "Trazer, servir");
            listaVerbos.Add(verbo14);

            Verbo verbo15 = new Verbo(15, "Build", "To build", "Built", "Built", "Construir, fabricar");
            listaVerbos.Add(verbo15);

            Verbo verbo16 = new Verbo(16, "Burn", "To burn", "Burnt", "Burnt", "Queimar, incendiar, carbonizar");
            listaVerbos.Add(verbo16);

            Verbo verbo17 = new Verbo(17, "Buy", "To buy", "Bought", "Bought", "Comprar");
            listaVerbos.Add(verbo17);

            Verbo verbo18 = new Verbo(18, "Cast", "To cast", "Cast", "Cast", "Arremessar, jogar, derrubar, moldar");
            listaVerbos.Add(verbo18);

            Verbo verbo19 = new Verbo(19, "Catch", "To catch", "Caught", "Caught", "Pegar, capturar, entender, adquirir");
            listaVerbos.Add(verbo19);

            Verbo verbo20 = new Verbo(20, "Choose", "To choose", "Chose", "Chosen", "Escolher, selecionar, preferir");
            listaVerbos.Add(verbo20);

            Verbo verbo21 = new Verbo(21, "Come", "To come", "Came", "Come", "Vir, chegar");
            listaVerbos.Add(verbo21);

            Verbo verbo22 = new Verbo(22, "Cost", "To cost", "Cost", "Cost", "Custar");
            listaVerbos.Add(verbo22);

            Verbo verbo23 = new Verbo(23, "Cut", "To cut", "Cut", "Cut", "Cortar, partir, reduzir, recortar, castrar");
            listaVerbos.Add(verbo23);

            Verbo verbo24 = new Verbo(24, "Deal", "To deal", "Dealt", "Dealt", "Distribuir, repartir, espalhar, negociar");
            listaVerbos.Add(verbo24);

            Verbo verbo25 = new Verbo(25, "Dig", "To dig", "Dug", "Dug", "Cavar, escavar");
            listaVerbos.Add(verbo25);

            Verbo verbo26 = new Verbo(26, "Do", "To do", "Did", "Done", "Fazer");
            listaVerbos.Add(verbo26);

            Verbo verbo27 = new Verbo(27, "Draw", "To draw", "Drew", "Drawn", "Desenhar, extrair, sair");
            listaVerbos.Add(verbo27);

            Verbo verbo28 = new Verbo(28, "Drink", "To drink", "Drank", "Drunk", "Beber");
            listaVerbos.Add(verbo28);

            Verbo verbo29 = new Verbo(29, "Drive", "To drive", "Drove", "Driven", "Dirigir, guiar");
            listaVerbos.Add(verbo29);

            Verbo verbo30 = new Verbo(30, "Eat", "To eat", "Ate", "Eaten", "Comer");
            listaVerbos.Add(verbo30);

            Verbo verbo31 = new Verbo(31, "Fall", "To fall", "Fell", "Fallen", "Cair, abater-se, decrescer, diminuir");
            listaVerbos.Add(verbo31);

            Verbo verbo32 = new Verbo(32, "Feed", "To feed", "Fed", "Fed", "Alimentar, nutrir");
            listaVerbos.Add(verbo32);

            Verbo verbo33 = new Verbo(33, "Feel", "To feel", "Felt", "Felt", "Sentir, notar");
            listaVerbos.Add(verbo33);

            Verbo verbo34 = new Verbo(34, "Fight", "To fight", "Fought", "Fought", "Lutar, brigar");
            listaVerbos.Add(verbo34);

            Verbo verbo35 = new Verbo(35, "Find", "To find", "Found", "Found", "Achar, encontrar");
            listaVerbos.Add(verbo35);

            Verbo verbo36 = new Verbo(36, "Fly", "To fly", "Flew", "Flown", "Voar");
            listaVerbos.Add(verbo36);

            Verbo verbo37 = new Verbo(37, "Forbid", "To forbid", "Forbade", "Forbidden", "Proibir");
            listaVerbos.Add(verbo37);

            Verbo verbo38 = new Verbo(38, "Forget", "To forget", "Forgot", "Forgotten", "Esquecer(-se)");
            listaVerbos.Add(verbo38);

            Verbo verbo39 = new Verbo(39, "Forgive", "To forgive", "Forgave", "Forgiven", "Perdoar");
            listaVerbos.Add(verbo39);

            Verbo verbo40 = new Verbo(40, "Forsake", "To forsake", "Forsook", "Forsaken", "Abandonar, desertar, largar; abrir mão de");
            listaVerbos.Add(verbo40);

            Verbo verbo41 = new Verbo(41, "Freeze", "To freeze", "Froze", "Frozen", "Congelar");
            listaVerbos.Add(verbo41);

            Verbo verbo42 = new Verbo(42, "Get", "To get", "Got", "Got", "Obter, conseguir");
            listaVerbos.Add(verbo42);

            Verbo verbo43 = new Verbo(43, "Give", "To give", "Gave", "Given", "Dar");
            listaVerbos.Add(verbo43);

            Verbo verbo44 = new Verbo(44, "Go", "To go", "Went", "Gone", "Ir");
            listaVerbos.Add(verbo44);

            Verbo verbo45 = new Verbo(45, "Grow", "To grow", "Grew", "Grown", "Crescer, florescer, germinar");
            listaVerbos.Add(verbo45);

            Verbo verbo46 = new Verbo(46, "Hang", "To hang", "Hung", "Hung", "Pendurar, suspender");
            listaVerbos.Add(verbo46);

            Verbo verbo47 = new Verbo(47, "Have", "To have", "Had", "Had", "Ter, possuir");
            listaVerbos.Add(verbo47);

            Verbo verbo48 = new Verbo(48, "Hear", "To hear", "Heard", "Heard", "Ouvir, escutar, ter notícias");
            listaVerbos.Add(verbo48);

            Verbo verbo49 = new Verbo(49, "Hide", "To hide", "Hid", "Hidden", "Esconder(-se), ocultar");
            listaVerbos.Add(verbo49);

            Verbo verbo50 = new Verbo(50, "Hit", "To hit", "Hit", "Hit", "Bater, chocar-se");
            listaVerbos.Add(verbo50);

            Verbo verbo51 = new Verbo(51, "Hold", "To hold", "Held", "Held", "Segurar, agarrar");
            listaVerbos.Add(verbo51);

            Verbo verbo52 = new Verbo(52, "Hurt", "To hurt", "Hurt", "Hurt", "Ferir(-se), machucar");
            listaVerbos.Add(verbo52);

            Verbo verbo53 = new Verbo(53, "Keep", "To keep", "Kept", "Kept", "Manter, conservar, preservar");
            listaVerbos.Add(verbo53);

            Verbo verbo54 = new Verbo(54, "Kneel", "To kneel", "Knelt", "Knelt", "Ajoelhar-se");
            listaVerbos.Add(verbo54);

            Verbo verbo55 = new Verbo(55, "Knit", "To knit", "Knit", "Knit", "Tricotar");
            listaVerbos.Add(verbo55);

            Verbo verbo56 = new Verbo(56, "Know", "To know", "Knew", "Known", "Saber, conhecer");
            listaVerbos.Add(verbo56);

            Verbo verbo57 = new Verbo(57, "Lay", "To lay", "Laid", "Laid", "Pôr, colocar, derrubar, deitar");
            listaVerbos.Add(verbo57);

            Verbo verbo58 = new Verbo(58, "Lead", "To lead", "Led", "Led", "Conduzir, liderar, comandar");
            listaVerbos.Add(verbo58);

            Verbo verbo59 = new Verbo(59, "Leap", "To leap", "Leapt", "Leapt", "Saltar, pular, cobrir (os animais)");
            listaVerbos.Add(verbo59);

            Verbo verbo60 = new Verbo(60, "Learn", "To learn", "Learnt", "Learnt", "Aprender, ficar sabendo");
            listaVerbos.Add(verbo60);

            Verbo verbo61 = new Verbo(61, "Leave", "To leave", "Left", "Left", "Partir, deixar, sair");
            listaVerbos.Add(verbo61);

            Verbo verbo62 = new Verbo(62, "Lend", "To lend", "Lent", "Lent", "Emprestar");
            listaVerbos.Add(verbo62);

            Verbo verbo63 = new Verbo(63, "Let", "To let", "Let", "Let", "Permitir, deixar");
            listaVerbos.Add(verbo63);

            Verbo verbo64 = new Verbo(64, "Lie", "To lie", "Lay", "Lain", "Deitar");
            listaVerbos.Add(verbo64);

            Verbo verbo65 = new Verbo(65, "Light", "To light", "Lit", "Lit", "Acender, iluminar");
            listaVerbos.Add(verbo65);

            Verbo verbo66 = new Verbo(66, "Lose", "To lose", "Lost", "Lost", "Perder");
            listaVerbos.Add(verbo66);

            Verbo verbo67 = new Verbo(67, "Make", "To make", "Made", "Made", "Fazer, criar, elaborar");
            listaVerbos.Add(verbo67);

            Verbo verbo68 = new Verbo(68, "Mean", "To mean", "Meant", "Meant", "Significar, querer dizer");
            listaVerbos.Add(verbo68);

            Verbo verbo69 = new Verbo(69, "Meet", "To meet", "Met", "Met", "Encontrar(-se), reunir(-se)");
            listaVerbos.Add(verbo69);

            Verbo verbo70 = new Verbo(70, "Pay", "To pay", "Paid", "Paid", "Pagar");
            listaVerbos.Add(verbo70);

            Verbo verbo71 = new Verbo(71, "Put", "To put", "Put", "Put", "Pôr, colocar");
            listaVerbos.Add(verbo71);

            Verbo verbo72 = new Verbo(72, "Quit", "To quit", "Quit", "Quit", "Desistir, abandonar");
            listaVerbos.Add(verbo72);

            Verbo verbo73 = new Verbo(73, "Read", "To read", "Read", "Read", "Ler, interpretar");
            listaVerbos.Add(verbo73);

            Verbo verbo74 = new Verbo(74, "Ride", "To ride", "Rode", "Ridden", "Cavalgar, andar de bicicleta ou carro");
            listaVerbos.Add(verbo74);

            Verbo verbo75 = new Verbo(75, "Ring", "To ring", "Rang", "Rung", "Soar, tocar (campainha, telefone)");
            listaVerbos.Add(verbo75);

            Verbo verbo76 = new Verbo(76, "Rise", "To rise", "Rose", "Risen", "Erguer-se, levantar-se");
            listaVerbos.Add(verbo76);

            Verbo verbo77 = new Verbo(77, "Run", "To run", "Ran", "Run", "Correr, apressar-se");
            listaVerbos.Add(verbo77);

            Verbo verbo78 = new Verbo(78, "Saw", "To saw", "Sawed", "Sawn", "Serrar");
            listaVerbos.Add(verbo78);

            Verbo verbo79 = new Verbo(79, "Say", "To say", "Said", "Said", "Dizer");
            listaVerbos.Add(verbo79);

            Verbo verbo80 = new Verbo(80, "See", "To see", "Saw", "Seen", "Ver, perceber");
            listaVerbos.Add(verbo80);

            Verbo verbo81 = new Verbo(81, "Seek", "To seek", "Sought", "Sought", "Procurar, pedir, almejar");
            listaVerbos.Add(verbo81);

            Verbo verbo82 = new Verbo(82, "Sell", "To sell", "Sold", "Sold", "Vender");
            listaVerbos.Add(verbo82);

            Verbo verbo83 = new Verbo(83, "Send", "To send", "Sent", "Sent", "Enviar, mandar");
            listaVerbos.Add(verbo83);

            Verbo verbo84 = new Verbo(84, "Set", "To set", "Set", "Set", "Pôr, dispor, ajustar");
            listaVerbos.Add(verbo84);

            Verbo verbo85 = new Verbo(85, "Sew", "To sew", "Sewed", "Sewn", "Costurar, coser");
            listaVerbos.Add(verbo85);

            Verbo verbo86 = new Verbo(86, "Shake", "To shake", "Shook", "Shaken", "Sacudir, agitar, apertar a mão (em cumprimento)");
            listaVerbos.Add(verbo86);

            Verbo verbo87 = new Verbo(87, "Shine", "To shine", "Shone", "Shone", "Brilhar");
            listaVerbos.Add(verbo87);

            Verbo verbo88 = new Verbo(88, "Shoot", "To shoot", "Shot", "Shot", "Atirar, ferir com tiro");
            listaVerbos.Add(verbo88);

            Verbo verbo89 = new Verbo(89, "Show", "To show", "Showed", "Shown", "Mostrar, apresentar");
            listaVerbos.Add(verbo89);

            Verbo verbo90 = new Verbo(90, "Shred", "To shred", "Shred", "Shred", "Cortar em pedaços, picar, retalhar, rasgar");
            listaVerbos.Add(verbo90);

            Verbo verbo91 = new Verbo(91, "Shrink", "To shrink", "Shrank", "Shrunk", "Contrair, encolher, recuar");
            listaVerbos.Add(verbo91);

            Verbo verbo92 = new Verbo(92, "Shut", "To shut", "Shut", "Shut", "Fechar, cerrar; tampar");
            listaVerbos.Add(verbo92);

            Verbo verbo93 = new Verbo(93, "Sing", "To sing", "Sang", "Sung", "Cantar");
            listaVerbos.Add(verbo93);

            Verbo verbo94 = new Verbo(94, "Sink", "To sink", "Sank", "Sunk", "Afundar");
            listaVerbos.Add(verbo94);

            Verbo verbo95 = new Verbo(95, "Sit", "To sit", "Sat", "Sat", "Sentar(-se)");
            listaVerbos.Add(verbo95);

            Verbo verbo96 = new Verbo(96, "Slay", "To slay", "Slew", "Slain", "Matar, assassinar, destruir, arruinar");
            listaVerbos.Add(verbo96);

            Verbo verbo97 = new Verbo(97, "Sleep", "To sleep", "Slept", "Slept", "Dormir");
            listaVerbos.Add(verbo97);

            Verbo verbo98 = new Verbo(98, "Slide", "To slide", "Slid", "Slid", "Escorregar, deslizar");
            listaVerbos.Add(verbo98);

            Verbo verbo99= new Verbo(99, "Sling", "To sling", "Slung", "Slung", "Atirar, arremessar");
            listaVerbos.Add(verbo99);

            Verbo verbo100 = new Verbo(100, "Smell", "To smell", "Smelt", "Smelt", "Cheirar");
            listaVerbos.Add(verbo100);

            Verbo verbo101 = new Verbo(101, "Sow", "To sow", "Sowed", "Sown", "Semear");
            listaVerbos.Add(verbo101);

            Verbo verbo102 = new Verbo(102, "Speak", "To speak", "Spoke", "Spoken", "Falar");
            listaVerbos.Add(verbo102);

            Verbo verbo103 = new Verbo(103, "Spell", "To spell", "Spelt", "Spelt", "Soletrar");
            listaVerbos.Add(verbo103);

            Verbo verbo104 = new Verbo(104, "Spend", "To spend", "Spent", "Spent", "Gastar (dinheiro), passar (tempo)");
            listaVerbos.Add(verbo104);

            Verbo verbo105 = new Verbo(105, "Spill", "To spill", "Spilt", "Spilt", "Derramar");
            listaVerbos.Add(verbo105);

            Verbo verbo106 = new Verbo(106, "Spin", "To spin", "Spun", "Spun", "Girar");
            listaVerbos.Add(verbo106);

            Verbo verbo107 = new Verbo(107, "Spit", "To spit", "Spat", "Spit", "Cuspir");
            listaVerbos.Add(verbo107);

            Verbo verbo108 = new Verbo(108, "Spoil", "To spoil", "Spoilt", "Spoilt", "Estragar, destruir, mimar");
            listaVerbos.Add(verbo108);

            Verbo verbo109 = new Verbo(109, "Spread", "To spread", "Spread", "Spread", "Espalhar, estender");
            listaVerbos.Add(verbo109);

            Verbo verbo110 = new Verbo(110, "Spring", "To spring", "Sprang", "Sprung", "Saltar, lançar-se, libertar-se");
            listaVerbos.Add(verbo110);

            Verbo verbo111 = new Verbo(111, "Stand", "To stand", "Stood", "Stood", "Ficar ou pôr-se de pé");
            listaVerbos.Add(verbo111);

            Verbo verbo112 = new Verbo(112, "Steal", "To steal", "Stole", "Stolen", "Roubar, furtar");
            listaVerbos.Add(verbo112);

            Verbo verbo113 = new Verbo(113, "Stick", "To stick", "Stuck", "Stuck", "Cravar, fincar");
            listaVerbos.Add(verbo113);

            Verbo verbo114 = new Verbo(114, "Sting", "To sting", "Stung", "Stung", "Picar, ferroar");
            listaVerbos.Add(verbo114);

            Verbo verbo115 = new Verbo(115, "Stink", "To stink", "Stank", "Stunk", "Feder; enojar");
            listaVerbos.Add(verbo115);

            Verbo verbo116 = new Verbo(116, "Strike", "To strike", "Struck", "Struck", "Bater, golpear");
            listaVerbos.Add(verbo116);

            Verbo verbo117 = new Verbo(117, "String", "To string", "Strung", "Strung", "Amarrar, pendurar, enfiar, esticar");
            listaVerbos.Add(verbo117);

            Verbo verbo118 = new Verbo(118, "Strive", "To strive", "Strove", "Striven", "Aspirar, tentar, esforçar-se");
            listaVerbos.Add(verbo118);

            Verbo verbo119 = new Verbo(119, "Swear", "To swear", "Swore", "Sworn", "Jurar");
            listaVerbos.Add(verbo119);

            Verbo verbo120 = new Verbo(120, "Sweat", "To sweat", "Sweat", "Sweat", "Suar");
            listaVerbos.Add(verbo120);

            Verbo verbo121 = new Verbo(121, "Sweep", "To sweep", "Swept", "Swept", "Varrer");
            listaVerbos.Add(verbo121);

            Verbo verbo122 = new Verbo(122, "Swell", "To swell", "Swelled", "Swollen", "Inchar (-se), crescer, encher (os pneus)");
            listaVerbos.Add(verbo122);

            Verbo verbo123 = new Verbo(123, "Swim", "To swim", "Swam", "Swum", "Nadar");
            listaVerbos.Add(verbo123);

            Verbo verbo124 = new Verbo(124, "Swing", "To swing", "Swung", "Swung", "Balançar");
            listaVerbos.Add(verbo124);

            Verbo verbo125 = new Verbo(125, "Take", "To take", "Took", "Taken", "Tomar, pegar, levar");
            listaVerbos.Add(verbo125);

            Verbo verbo126 = new Verbo(126, "Teach", "To teach", "Taught", "Taught", "Ensinar");
            listaVerbos.Add(verbo126);

            Verbo verbo127 = new Verbo(127, "Tear", "To tear", "Tore", "Torn", "Chorar, lacrimejar; rasgar, rachar");
            listaVerbos.Add(verbo127);

            Verbo verbo128 = new Verbo(128, "Tell", "To tell", "Told", "Told", "Dizer, contar");
            listaVerbos.Add(verbo128);

            Verbo verbo129 = new Verbo(129, "Think", "To think", "Thought", "Thought", "Pensar, achar");
            listaVerbos.Add(verbo129);

            Verbo verbo130 = new Verbo(130, "Thrive", "To thrive", "Throve", "Thriven", "Ter sucesso");
            listaVerbos.Add(verbo130);

            Verbo verbo131 = new Verbo(131, "Throw", "To Throw", "Threw", "Thrown", "Lançar, atirar");
            listaVerbos.Add(verbo131);

            Verbo verbo132 = new Verbo(132, "Thrust", "To thrust", "Thrust", "Thrust", "Empurrar");
            listaVerbos.Add(verbo132);

            Verbo verbo133 = new Verbo(133, "Understand", "To understand", "Understood", "Understood", "Entender, compreender");
            listaVerbos.Add(verbo133);

            Verbo verbo134 = new Verbo(134, "Wake", "To wake", "Woke", "Woken", "Acordar");
            listaVerbos.Add(verbo134);

            Verbo verbo135 = new Verbo(135, "Wear", "To wear", "Wore", "Worn", "Vestir, usar, trajar");
            listaVerbos.Add(verbo135);

            Verbo verbo136 = new Verbo(136, "Weave", "To weave", "Wove", "Woven", "Tecer, trançar");
            listaVerbos.Add(verbo136);

            Verbo verbo137 = new Verbo(137, "Win", "To win", "Won", "Won", "Ganhar, vencer");
            listaVerbos.Add(verbo137);

            Verbo verbo138 = new Verbo(138, "Wind", "To wind", "Wound", "Wound", "Girar, enrolar-se");
            listaVerbos.Add(verbo138);

            Verbo verbo139 = new Verbo(139, "Write", "To write", "Wrote", "Written", "Escrever");
            listaVerbos.Add(verbo139);

            Verbo verbo140 = new Verbo(140, "Wring", "To wring", "Wrung", "Wrung", "Torcer");
            listaVerbos.Add(verbo140);
        }

        public Boolean verificaInfinitivo(String infinitivo, Verbo palavra)
        {
            if (infinitivo.Equals(removeAcentos(palavra.getInfinitivo().ToLower())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean verificaPassadoSimples(String passadoSimples, Verbo palavra)
        {
            String semAcentos = removeAcentos(palavra.gepassadoSimples());
                if (semAcentos.ToLower().Contains(removeAcentos(passadoSimples.ToLower())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean verificaParticipioPassado(String participioPassado, Verbo palavra)
        {
            if (participioPassado.Equals(removeAcentos(palavra.getparticipioPassado().ToLower())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean verificaTraducao(String traducao, Verbo palavra)
        {
            String semAcentos = removeAcentos(palavra.gettraducao()); 
            if (semAcentos.ToLower().Contains(removeAcentos(traducao.ToLower())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string removeAcentos(string texto)
        {
            StringBuilder textoRetorno = new StringBuilder();
            var arrayTexto = texto.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letra in arrayTexto)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letra) != UnicodeCategory.NonSpacingMark)
                    textoRetorno.Append(letra);
            }
            return textoRetorno.ToString();
        }
    }
}
