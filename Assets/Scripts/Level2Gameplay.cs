using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Level2Gameplay : MonoBehaviour
{
    public TextMeshProUGUI textField;
    public void ResetTextField()
    {
        textField.text = "";
    }
    
    public void HH()
    {
        AddSpace();
        textField.text += "HH";
    }

    public void CX21()
    {
        AddSpace();
        textField.text += "CX(2,1)";
    }

    public void YX()
    {
        AddSpace();
        textField.text += "YX";
    }

    public void CY21()
    {
        AddSpace();
        textField.text += "CY(2,1)";
    }

    public void ZH()
    {
        AddSpace();
        textField.text += "ZH";
    }

    public void IH()
    {
        AddSpace();
        textField.text += "IH";
    }

    public void XX()
    {
        AddSpace();
        textField.text += "XX";
    }
    public void SY()
    {
        AddSpace();
        textField.text += "SY";
    }

    public void CX12()
    {
        AddSpace();
        textField.text += "CX(1,2)";
    }

    public void CZ12()
    {
        AddSpace();
        textField.text += "CZ(1,2)";
    }
    private void AddSpace()
    {
        if (!textField.text.Equals(""))
        {
            textField.text += " ";
        }
    }
}
