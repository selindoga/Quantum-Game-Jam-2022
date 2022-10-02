using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //SlashScreen = 0,
    //Level1_Question = 1,
    //Level1_Gameplay = 2,
    //Level1_Win = 3,
    //Level2_Question = 4,
    //Level2_Gameplay = 5,
    //Level2_Win = 6,
    //Level3_Question = 7,
    //Level3_Gameplay = 8,
    //Level3_Win = 9,
    //GameOver = 10,
    
    public static bool InLevel1;
    public static bool InLevel2;
    public static bool InLevel3;
    public static int CurrentSceneIndex;
    public static int TryAgainScene;

    private bool CurrentLevelWon = false;
    private String L1Solution = "H";
    private String L2Solution = "HH CX(1,2)";
    private String L3Solution = "IX HH CX(1,2)";

    private void Start()
    {
        CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        switch (CurrentSceneIndex)
        {
            case 2:
                InLevel1 = true;
                InLevel2 = false;
                InLevel3 = false;
                break;
            case 5:
                InLevel1 = false;
                InLevel2 = true;
                InLevel3 = false;
                break;
            case 8:
                InLevel1 = false;
                InLevel2 = false;
                InLevel3 = true;
                break;
        }
    }

    public void GoToScene(int chosenScene)
    {
        // start with the first level
        SceneManager.LoadScene(chosenScene);
    }

    public void CheckWinStatus(TextMeshProUGUI TextField)
    {
        if (InLevel1 && (String.Compare(TextField.text, L1Solution) == 0))
        {
            // this means current level is won
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (InLevel2 && (String.Compare(TextField.text, L2Solution) == 0))
        {
            // this means current level is won
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } 
        else if (InLevel3 && (String.Compare(TextField.text, L3Solution) == 0))
        {
            // this means current level is won
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            TryAgainScene = CurrentSceneIndex;
            SceneManager.LoadScene(10);
        }
    }
    public void GameFinished(GameObject GameFinishedText)
    {
        GameFinishedText.SetActive(true);
    }

    public void ActivateExitButton(GameObject ExitGame)
    {
        ExitGame.SetActive(true);
    }
    public void TryAgainLevel()
    {
        SceneManager.LoadScene(TryAgainScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
