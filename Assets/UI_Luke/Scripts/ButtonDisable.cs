using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDisable : MonoBehaviour {

    //IndividualButtons
    public Button Back;
    public Button select;

    //char buttons
    public Button Gertrude;
    public Button Phil;
    public Button Barry;
    public Button Juan;
    public Button Sully;
    void Start()
    {
        
    }

    IEnumerator DisableButtonSelect()
    {
        Gertrude.interactable = false;
        Phil.interactable = false;
        Barry.interactable = false;
        Juan.interactable = false;
        Sully.interactable = false;

        yield return new WaitForSeconds(1.5f);

        Gertrude.interactable = true;
        Phil.interactable = true;
        Barry.interactable = true;
        Juan.interactable = true;
        Sully.interactable = true;
    }
    public void ButtonDelaySelect()
    {
        StartCoroutine("DisableButtonSelect");
    }
    public void ButtonDelayBack()
    {
        StartCoroutine("DisableButtonBack");
    }
    IEnumerator DisableButtonBack()
    {
        Back.interactable = false;
        select.interactable = false;

        yield return new WaitForSeconds(1.2f);

        Back.interactable = true;
        select.interactable = true;
    }
}
