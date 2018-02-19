using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ShowPrices : MonoBehaviour {
    public Canvas Price1;
    public Canvas Price2;
    public Canvas Price3;
    public Canvas Price4;
    // Use this for initialization
    void Start () {
        Price1.enabled = false;
        Price2.enabled = false;
        //Price3.enabled = false;
        //Price4.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    //item1
    public void Item1Price()
    {

        Price1.enabled = true;
    }
    //item2

    public void Item2Price()
    {

        Price2.enabled = true;
    }

    public void disablePrice()
    {
        Price1.enabled = false;
        Price2.enabled = false;
        //Price3.enabled = false;
        //Price4.enabled = false;
    }

}
