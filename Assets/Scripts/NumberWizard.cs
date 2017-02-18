using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    private const int MaxNumber = 1000;
    private const int MinMumber = 1;

    int max;
    int min;
    int guess = 500;

    // Use this for initialization
    void Start() {
        StartGame();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            print("I won!");
            StartGame();
        }
    }

    private void StartGame() {
        max = MaxNumber;
        min = MinMumber;
        guess = (max + min) / 2;

        print("========================");
        print("Welcome to number wizard");
        print("Pick a number in your head, but don't tell me.");

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than " + guess + "?");
        print("Up = higher, down = lower, return = equals.");

        //Adding 1 so that we can pick the MaxNumber number.
        max += 1;
    }

    private void NextGuess() {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess + "?");
        print("Up = higher, down = lower, return = equals.");
    }
}
