using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Level1Gameplay : MonoBehaviour
{
    public TextMeshProUGUI textField;

    public void ResetTextField()
    {
        textField.text = "";
    }

    public void X()
    {
        AddSpace();
        textField.text += "X";
    }

    public void H()
    {
        AddSpace();
        textField.text += "H";
    }

    public void Z()
    {
        AddSpace();
        textField.text += "Z";
    }

    public void S()
    {
        AddSpace();
        textField.text += "S";
    }

    public void Y()
    {
        AddSpace();
        textField.text += "Y";
    }

    public void I()
    {
        AddSpace();
        textField.text += "I";
    }

    private void AddSpace()
    {
        if (!textField.text.Equals(""))
        {
            textField.text += " ";
        }
    }
}
