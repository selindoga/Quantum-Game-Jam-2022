using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GamePlay : MonoBehaviour
{
    public GameObject[] buttons;
    public TextMeshProUGUI TextField;
    private bool zi_pressed;
    private bool zh_pressed;
    private bool xy_pressed;
    private bool xi_pressed;
    private bool xx_pressed;
    private bool hx_pressed;
    private bool yy_pressed;
    private bool yh_pressed;
    private bool ih_pressed;

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
            WonTheGame = true;
            LostTheGame = false;
            Debug.Log("won the game");
        }
        else
        {
            WonTheGame = false;
            LostTheGame = true;
            Debug.Log("lost the game");
        }
    }
}
