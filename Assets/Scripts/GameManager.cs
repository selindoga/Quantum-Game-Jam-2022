using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    
    // yeni sceneler ekledikçe bir sonraki index e koy
    // yapmayı planladığım levels ekranı indexi 11 olmalı gibi
    
    public static bool InLevel1;
    public static bool InLevel2;
    public static bool InLevel3;
    public static int CurrentSceneIndex;
    public static int TryAgainScene;

    public AudioSource LockSound; 
    
    private bool CurrentLevelWon = false;
    private String L1Solution = "H";
    private String L2Solution = "HH CX(1,2)";
    private String L3Solution = "IX HH CX(1,2)";
    
    private GameObject ImageOfVolume;
    private GameObject OptionsMenu;
    private GameObject GameplayParent;

    private static int IndexOfCurrentScene_BeforeGoingTo_LevelsScene;
    private void Start()
    {
        ImageOfVolume = GameObject.Find("VolumeButton/Image");
        if (ImageOfVolume != null)
        {
            if (AudioListener.volume == 0)
            {
                ImageOfVolume.GetComponent<Image>().sprite =
                    (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Sprites/Buttons/mute.png", typeof(Sprite));
            } else if (AudioListener.volume > 0)
            {
                ImageOfVolume.GetComponent<Image>().sprite =
                    (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Sprites/Buttons/volume.png", typeof(Sprite));
            }
        }
        
        OptionsMenu = GameObject.Find("/Canvas/OptionsMenu"); 
        GameplayParent = GameObject.Find("/Canvas/GameplayParent");
        
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

        try
        {
            OptionsMenu.SetActive(false);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
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
    
    public void ClickVolumeButton()
    {
        if (AudioListener.volume > 0)
        {
            AudioListener.volume = 0;
            ImageOfVolume.GetComponent<Image>().sprite =
                (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Sprites/Buttons/mute.png", typeof(Sprite));
        }
        else
        {
            AudioListener.volume = 1;
            ImageOfVolume.GetComponent<Image>().sprite =
                (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Sprites/Buttons/volume.png", typeof(Sprite));
        }
    }

    public void ClickOptionsButton()
    {
        OptionsMenu.SetActive(true);
        GameplayParent.SetActive(false);
    }

    public void ClickCloseButton()
    {       
        GameplayParent.SetActive(true);
        OptionsMenu.SetActive(false);
    }

    public void ClickGoBackToSeeQuestionButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void ClickLevelsButton()
    {
        IndexOfCurrentScene_BeforeGoingTo_LevelsScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(11);
    }

    public void ClickGoBackButton()
    {
        SceneManager.LoadScene(IndexOfCurrentScene_BeforeGoingTo_LevelsScene);
    }
    public void ClickQuitGameButton()
    {
        Application.Quit();
    }
}
