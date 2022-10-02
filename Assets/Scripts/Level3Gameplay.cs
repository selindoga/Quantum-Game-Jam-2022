using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level3Gameplay : MonoBehaviour
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

    public void ZX()
    {
        AddSpace();
        textField.text += "ZX";
    }

    public void CZ21()
    {
        AddSpace();
        textField.text += "CZ(2,1)";
    }

    public void ZZ()
    {
        AddSpace();
        textField.text += "ZZ";
    }

    public void ZH()
    {
        AddSpace();
        textField.text += "ZH";
    }

    public void IX()
    {
        AddSpace();
        textField.text += "IX";
    }
    public void CX12()
    {
        AddSpace();
        textField.text += "CX(1,2)";
    }
    public void XX()
    {
        AddSpace();
        textField.text += "XX";
    }
    public void YH()
    {
        AddSpace();
        textField.text += "YH";
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
