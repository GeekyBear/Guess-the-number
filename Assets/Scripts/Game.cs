using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{
    public TMP_InputField input;
    public TMP_Text infoText;

    private int guessNumber;
    private int usersGuess;

    void Start()
    {
        guessNumber = Random.Range(0,100);
    }

    public void checkGuess() {
        usersGuess = int.Parse(input.text);

        if(usersGuess == guessNumber){
            infoText.text = "You guessed the number. You rock!";
        } else if(usersGuess > guessNumber){
            infoText.text = "Your number is greater than the guess number. Try again!";
        } else if(usersGuess < guessNumber){
            infoText.text = "Your number is lower than the guess number. Try again!";
        }

        input.text = "";
    }
}
