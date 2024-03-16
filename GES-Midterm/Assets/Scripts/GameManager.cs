using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using TMPro;

public class GameManager : MonoBehaviour
{
    int wrongGuesses = 0;
    [SerializeField] GameObject HangmanHead;
    [SerializeField] GameObject HangmanSmile;
    [SerializeField] GameObject HangmanTorso;
    [SerializeField] GameObject HangmanLegs;
    [SerializeField] GameObject HangmanArms;
    string[] blankWord;
    string selectedWord;

    [SerializeField] TextMeshProUGUI SelectedWordLabel;

    // Start is called before the first frame update
    void Start()
    {
        SetUp();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetUp()
    {
        //picks word from wordlist txt file
        //sets bar at top in game to read _'s in corresponding spaces

        string[] wordList = File.ReadAllLines("Assets/Scripts/WordList.txt");
        selectedWord = wordList[Random.Range(0, wordList.Length)];
        Debug.Log(wordList);
        Debug.Log(selectedWord);
        blankWord = new string[selectedWord.Length];

        for (int i = 0; i < selectedWord.Length; i++)
        {
            blankWord[i] = "_";
            SelectedWordLabel.text = string.Join("", blankWord);
        }
    }

    void MakeLetterGuess(char input)
    {
        //check if string selectedWord contains char input
        //if yes change get index of char in selectedWord
        //change index of char in selected word at index in blankWord to char input
        //edit text to match

        //if no wrongGuesses += 1;

        CheckHangmanStatus();
        CheckWin();
    }
    
    /// <summary>
    /// based on current amount of wrong guesses activates body gameobjects
    /// </summary>
    void CheckHangmanStatus()
    {
        if (wrongGuesses == 0)
        {
            HangmanHead.SetActive(true);
        }
        else if (wrongGuesses == 1)
        {
            HangmanHead.SetActive(true);
        }
        else if (wrongGuesses == 2)
        {
            HangmanSmile.SetActive(true);
            
        }
        else if (wrongGuesses == 3)
        {
            HangmanTorso.SetActive(true);
            
        }
        else if (wrongGuesses == 4)
        {
            HangmanLegs.SetActive(true);
            
        }
        else if (wrongGuesses == 5)
        {
            HangmanArms.SetActive(true);
        }
        else
        {
            //player will lose after 5 wrong guesses
            //EndGame with lose
        }

    }

    void CheckWin()
    {
        if(selectedWord == blankWord.ToString())
        {

        }
    }
}
