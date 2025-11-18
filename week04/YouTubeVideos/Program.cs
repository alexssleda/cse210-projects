using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video methodTft = new Video();
        methodTft._author = "TFToddy";
        methodTft._title = "New methods to play tft";
        methodTft._length = 1804;

        Comment methodTftPaulo = new Comment();
        methodTftPaulo._name = "Paulops52";
        methodTftPaulo._comment = "Completamente off topic mas o vídeo passou muito uma vibe canal de gameplay de 2012 pelo áudio do headset, mt nostálgico";

        Comment methodTftAntonio = new Comment();
        methodTftAntonio._name = "Antonio";
        methodTftAntonio._comment = "Toddy amassando os rioters sem dó ou piedade";

        Comment methodTftDebora = new Comment();
        methodTftDebora._name = "Debora";
        methodTftDebora._comment = "Ansiosa pra jogar também";

        methodTft._comments.Add(methodTftPaulo);
        methodTft._comments.Add(methodTftAntonio);
        methodTft._comments.Add(methodTftDebora);

        Video furiaFalcons = new Video();
        furiaFalcons._author = "Gaules";
        furiaFalcons._title = "Final Furia x Falcons";
        furiaFalcons._length = 3875;

        Comment furiaFalconsIgor = new Comment();
        furiaFalconsIgor._name = "Igor";
        furiaFalconsIgor._comment = " Furia colocou o Yekindar de volta no CS2! Que jogador.";

        Comment furiaFalconsLucas = new Comment();
        furiaFalconsLucas._name = "Lucas";
        furiaFalconsLucas._comment = "Bem vinda de volta SK Gaming";

        Comment furiaFalconsWallison = new Comment();
        furiaFalconsWallison._name = "Wallison";
        furiaFalconsWallison._comment = "YEKINDAR O NOME DESTA FINAL !!!!";

        furiaFalcons._comments.Add(furiaFalconsIgor);
        furiaFalcons._comments.Add(furiaFalconsLucas);
        furiaFalcons._comments.Add(furiaFalconsWallison);

        Video angryBird = new Video();
        angryBird._author = "DudePerfect";
        angryBird._title = "Angry bird in real life";
        angryBird._length = 6058;

        Comment angryBirdTimeBucks = new Comment();
        angryBirdTimeBucks._name = "TimeBucks";
        angryBirdTimeBucks._comment = "I love the idea";

        Comment angryBirdAaron = new Comment();
        angryBirdAaron._name = "Aaron";
        angryBirdAaron._comment = "This is the first challenge Garrett has actually tried to win in years lol ";

        Comment angryBirdTheMind = new Comment();
        angryBirdTheMind._name = "TheMind";
        angryBirdTheMind._comment = "snipped";

        angryBird._comments.Add(angryBirdTimeBucks);
        angryBird._comments.Add(angryBirdAaron);
        angryBird._comments.Add(angryBirdTheMind);

        Video bestGragas = new Video();
        bestGragas._author = "Mylon";
        bestGragas._title = "the best gragas in lol";
        bestGragas._length = 698;

        Comment bestGragasTiogojo = new Comment();
        bestGragasTiogojo._name = "Tiogojo";
        bestGragasTiogojo._comment = "Perdão mylin, irei dar";

        Comment bestGragasJmyss = new Comment();
        bestGragasJmyss._name = "Jmyss";
        bestGragasJmyss._comment = "Dia 18 pedindo pro mylon jogar de Qiyana";

        Comment bestGragasDeselegante = new Comment();
        bestGragasDeselegante._name = "Deselegante";
        bestGragasDeselegante._comment = "uai melhor gragas do mundo é o Homem Cavalo Salamaleico da Silva";

        bestGragas._comments.Add(bestGragasTiogojo);
        bestGragas._comments.Add(bestGragasJmyss);
        bestGragas._comments.Add(bestGragasDeselegante);

        videos.Add(methodTft);
        videos.Add(furiaFalcons);
        videos.Add(angryBird);
        videos.Add(bestGragas);

        foreach (Video v in videos)
        {
            v.ShowComments();
        }
    }
}