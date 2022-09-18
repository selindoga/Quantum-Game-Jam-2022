using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GamePlay : MonoBehaviour
{
    public TextMeshProUGUI TextField;
    public GameObject gameplayDisplay;
    public GameObject WinDisplay;
    public GameObject LostDisplay;

    public static bool WonTheGame;
    public static bool LostTheGame;

    private void Start()
    {
        WonTheGame = false;
        LostTheGame = false;
    }

    public void zi()
    {
        TextField.text += "ZI";
        TextField.text += " ";
    }
    public void zh()
    {
        TextField.text += "ZH";
        TextField.text += " ";
    }
    public void xy()
    {
        TextField.text += "XY";
        TextField.text += " ";
    }
    public void xi()
    {
        TextField.text += "XI";
        TextField.text += " ";
    }
    public void xx()
    {
        TextField.text += "XX";
        TextField.text += " ";
    }
    public void hx()
    {
        TextField.text += "HX";
        TextField.text += " ";
    }
    public void yy()
    {
        TextField.text += "YY";
        TextField.text += " ";
    }
    public void yh()
    {
        TextField.text += "YH";
        TextField.text += " ";
    }
    public void ih()
    {
        TextField.text += "IH";
        TextField.text += " ";
    }

    public void resetText()
    {
        TextField.text = "";
    }

    public void OK()
    {
        if (TextField.text.Equals("XI IH "))
        {
            resetText();
            WonTheGame = true;
            LostTheGame = false;
            Debug.Log("won the game");
            WinDisplay.SetActive(true);
            LostDisplay.SetActive(false);
            gameplayDisplay.SetActive(false);
        }
        else
        {
            resetText();
            WonTheGame = false;
            LostTheGame = true;
            Debug.Log("lost the game");
            WinDisplay.SetActive(false);
            LostDisplay.SetActive(true);
            gameplayDisplay.SetActive(false);
        }
    }

    public void CloseScreenButton()
    {
        resetText();
        WinDisplay.SetActive(false);
        LostDisplay.SetActive(false);
        gameplayDisplay.SetActive(true);
    }
}
