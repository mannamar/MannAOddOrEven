// Amardeep Mann
// 10-20-22
// Mini Challenge #6 - Odds or Evens
// We will take an input and tell the user wether the number is odd or even. Then ask them to play again
// Peer reviewed by Reed Godwin: Very good code, super robust with no room for errors. Tried my hardest to break it and could not succeed. I can alwasy find good stuff from his code and I never have anything bad to say. Always an interesting and learning experience!
// https://github.com/peedrama/MannAOddOrEven

Console.Clear();

bool wantsToPlay = true;

while (wantsToPlay) {

  Console.WriteLine("Hey bud. Give me a number, any number! And I'll tell you wether it's odd or even");

  bool isValidNum = false;
  int num = 0;

  while(!isValidNum) {
    string userInput = Console.ReadLine();
    isValidNum = Int32.TryParse(userInput, out num);
    if (!isValidNum) {
      Console.WriteLine("Please enter a valid number");
    }
  }

  if (num % 2 == 0) {
    Console.WriteLine($"\n{num} is even!");
  } else {
    Console.WriteLine($"\n{num} is odd!");
  }

  string response;

  Console.WriteLine("");  // Line break for readability

  do {
    Console.WriteLine("Do you want to play again? (Please enter \"y\" or \"n\")");
    response = Console.ReadLine().ToLower();
    if (response == "no" || response == "n") {
      wantsToPlay = false;
      Console.WriteLine("\nSee ya next time!");
    } else {
      Console.WriteLine(""); // Line break for readability
    }
  } while (response != "yes" && response != "no" && response != "y" && response != "n");

}