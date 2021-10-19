using System;


Console.WriteLine("var väljer du att gå. höger, vänster eller rakt fram?");

 string väg;
 //string grotta;
 //string sten;
 
väg = Console.ReadLine();
 if(väg == "höger" || väg == "Höger")
 {
 Console.WriteLine("Du kommer fram till en grotta!");
 }
 else if(väg == "vänster" || väg == "Vänster")
 {
 Console.WriteLine("du stöter på en gammal gubbe som blir arg på dig så du springer iväg och ramlar. Game Over!");
 väg = Console.ReadLine();
 }


Console.WriteLine("Vill du gå in eller runt grottan?");
Console.ReadLine();


 if(väg == "in" || väg == "In")
 {
 Console.WriteLine("Du går in i grottan och hittar en kista!");
 }

 else if(väg == "runt" || väg == "runt")
 {
 Console.WriteLine("Du fortsätter på din resa. Game Over!");
 väg = Console.ReadLine();
 }
 
  
Console.WriteLine("Vill du öppna kista eller ta stenen som ligger brevid?");
Console.ReadLine();

 if(väg == "öppna" || väg == "öppna")
 {
  Console.WriteLine("Du öppnar kistan och ut flyger ett spjut och dödar dig! Game Over!");  
  väg = Console.ReadLine();  
 }
 else if( väg == "Stenen" || väg == "stenen")
 {
 Console.WriteLine("Du plockar upp stenen och inser att det var en helig sten! ");    
 }

 Console.WriteLine("Du tar med stenen hem och blir byns hjälte! Game Over!"); 
väg = Console.ReadLine();


Console.ReadLine();

