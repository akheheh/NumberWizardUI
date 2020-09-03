using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int max;
    [SerializeField] int min;
    int guess;

    // Use this for initialization
    void Start ()
    {
        StartGame();
	}
	
    void StartGame()
    {   
        max = max + 1;
        guess = (max + min) / 2 ;
    }

	// Update is called once per frame
    
    public void OnPressHigher() {
        min = guess;
        NextGuess();
    }

    public void OnPressLower() {
        max = guess;
        NextGuess();
    }

    public void OnPressCorrect() {
        Debug.Log("I am a genius!");
        StartGame();
    }
  
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than..." + guess);
    }
} 