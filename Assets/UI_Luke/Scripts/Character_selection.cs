using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_selection : MonoBehaviour
{

    
    public Canvas GertrudeUI;
    public Canvas PhilUI;
    public Canvas barryUI;
    public Canvas JuanUI;
    public Canvas SullyUI;
    public Canvas totalCharacterSelectionUI;

    // Use this for initialization
    void Start()
    {
        notSully();
        notPhil();
        notBarry();
        notJuan();
        notGertrude();
    }
    //UI show and Hide
    
    public void ShowUI()
    {
        totalCharacterSelectionUI.enabled = true;
    }

    public void HideUI()
    {
        totalCharacterSelectionUI.enabled = false;
    }

    //barry
    public void focusBarry()
    {
        barryUI.enabled = true;
        totalCharacterSelectionUI.enabled = false;
    }
    public void notBarry()
    {
        barryUI.enabled = false;
        totalCharacterSelectionUI.enabled = true;
    }

    //phil
    public void focusPhil()
    {
        PhilUI.enabled = true;
        totalCharacterSelectionUI.enabled = false;
    }
    public void notPhil()
    {
        PhilUI.enabled = false;
        totalCharacterSelectionUI.enabled = true;
    }
    //juan
    public void focusJuan()
    {
        JuanUI.enabled = true;
        totalCharacterSelectionUI.enabled = false;
    }
    public void notJuan()
    {
        JuanUI.enabled = false;
        totalCharacterSelectionUI.enabled = true;
    }
    //gertrude
    public void focusGertrude()
    {
        GertrudeUI.enabled = true;
        totalCharacterSelectionUI.enabled = false;
    }
    public void notGertrude()
    {
        GertrudeUI.enabled = false;
        totalCharacterSelectionUI.enabled = true;
    }
    //Sully

    public void focusSully()
    {
        SullyUI.enabled = true;
        totalCharacterSelectionUI.enabled = false;
    }
    public void notSully()
    {
        SullyUI.enabled = false;
        totalCharacterSelectionUI.enabled = true;
    }

}
