using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TMPro if using TextMesh Pro.  Since we aren't using this, we can ignore it
using TMPro;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Use this for initialization
    void Start ()
    {
        StartGame();
	}
	
    void StartGame()
    {   
        //guess = (max + min) / 2 ;
        NextGuess();
    }

	// Update is called once per frame
    
    public void OnPressHigher() {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower() {
        max = guess - 1;
        NextGuess();
    }

    public void OnPressCorrect() {

    }
  
    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
} 