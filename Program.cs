// See https://aka.ms/new-console-template for more information
int time = DateTime.Now.Hour;


if (time >= 6 && time<11)
{
    global::System.Console.WriteLine("Günaydın!");
}

if (time<= 18)
{
    global::System.Console.WriteLine("İyi Günler");
}
else
{
    global::System.Console.WriteLine("İyi Geceler");
}

string sonuc = time <= 18 ? "İyi Günler" : "İyi Geceler";

sonuc = time>6 && time<11 ? "Günaydın !" : time <= 18 ? "İyi Günler" : "İyi Geceler";
global::System.Console.WriteLine(sonuc);


