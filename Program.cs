using System;

namespace if_else_if{
    class Program{
        static void Main(string[] args){
            
            int time = DateTime.Now.Hour;

            if(time >=6 && time <=11 )
                Console.WriteLine("Günaydın.");
            else if(time > 11 && time <= 18 )
                Console.WriteLine("İyi günler");
            else
                Console.WriteLine("İyi geceler");
            string sonuc = time <=18 ? "İyi Günler" : "İyi geceler";
            Console.WriteLine("Saat" + " "+ time +" "+ sonuc); 
            sonuc = time <=11 && time >=6 ?"günaydın" : time <=18 ?" İyi Günler" : "İyi geceler";
            Console.WriteLine(sonuc);       
        }
    }
}
