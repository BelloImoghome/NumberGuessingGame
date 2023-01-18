
import java.util.Random;
import java.util.Scanner;
 
public class GuessMyName {

    public static void main(String[] args) {
        boolean keep_playing = true;
        int magic_number;
        var response = "";
        
        while (keep_playing)
        {            
            Random rand = new Random();
            // Generate random integers in range 0 to 100
            magic_number = rand.nextInt(101);
            var guess_count = 0; // this variable is keeping tracking of how many guesses it will take to get the magic number
            var guess = 0;
            
            while (guess != magic_number)
            {
                System.out.println("Guess a number between 1 and 100 : ");
                Scanner scn = new Scanner(System.in);
                var x = scn.nextInt();
                guess = x;
                
                /*
                //To Check if user's guess is a number
                while  (!Character.isDigit(guess))
                { 
                    System.out.print("That's not a number.");
                    System.out.println("Enter a number between 1 and 100 : ");
                    scn = new Scanner(System.in);
                    guess = scn.nextInt();
                    if (Character.isDigit(guess))
                    {
                        continue;         
                    }  
                }
                */
            
                if (guess < magic_number)
                {
                    System.out.println("Higher");
                    guess_count++;           
                } 
                else if (guess > magic_number)
                {
                    System.out.println("Lower");
                    guess_count++; 
                }
                else
                {
                    System.out.println("You guessed it!");
                    guess_count++; 
                }
            }
            System.out.println("It took you " + guess_count + " guesses");

            System.out.print("Would you like to play again (yes/no)? ");
            Scanner myObj = new Scanner(System.in);
            response = myObj.nextLine();
            while (response == null || response.isEmpty() || response.trim().isEmpty())
            {
                System.out.print("Response can't be empty! Input your response once more");
                response = myObj.nextLine();
            }
            response = response.toUpperCase();
            System.out.println("Response is " + response);
      
            if (response.equals("YES"))
            {
                keep_playing = true;
            }
            else
            {
                keep_playing = false;
                System.out.println("Thank you for playing, otilo!");
            }

        }
  
    }

}