using System;

class MainClass {

  //write methods
  private static int total = 0;
  private static int cardA = 0;
  private static int cardB = 0;

  public static void DrawCardA(){
  var rCardA = new Random();
  cardA = rCardA.Next(2, 12);
  Console.WriteLine("Your first card is " + cardA);
    }

  public static void DrawCardB(){
  var rCardB = new Random();
  cardB = rCardB.Next(2, 12);
  total = cardA + cardB;
  if (cardB == 11 && total > 21){
    cardB = 1;
    total = cardA + cardB;
    Console.WriteLine("Your second card is " + cardB);
    Console.WriteLine("Your total is " + total);
    is21(total);
  } else {
    Console.WriteLine("Your second card is " + cardB);
    Console.WriteLine("Your total is " + total);
    is21(total);
  }
    }

    public static void is21(int totalNums){
      if (totalNums == 21){
        Console.WriteLine("21! You win!");
      }
    }

  public static void Main (string[] args) {
    DrawCardA();
    DrawCardB();
  }
}