using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickToRead_Script_01 : MonoBehaviour
{
    public Text textToDisplay;
    public GameObject canvas;
    public bool isOff = false;
    public bool doNotClose = true;
    public string individualText;
    public string individualText2;
    public string individualTitle;
    public bool active = false;
    public bool isClosed = false;
    public bool startUp = false;

    void Start()
    {
        if (startUp)
        {
            textToDisplay.text = "Mum seemed confused about why I wanted to keep the old dollhouse we found while cleaning out grandma’s home.\n\nOr really, she seemed confused about the dollhouse itself, like it was something she’d never seen before & didn’t understand.\n\nThe dollhouse was old but had been kept safely hidden away & covered with a dusty sheet, like grandma didn’t want it to get lost or broken but didn’t want to look at it either.";
            doNotClose = false;
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(isClosed + "" + canvas.activeSelf +"" + isOff);
        }
        if (active)
        {
            if (Input.GetMouseButtonDown(0) & canvas.activeSelf == false)
            {
                canvas.SetActive(true);
                isOff = false;
            }
        }
        else if (Input.GetMouseButtonDown(0) && canvas.activeSelf && active == false && isOff == false)
        {
            textToDisplay.fontSize = 29;
            canvas.SetActive(false);
            isOff = true;
        }
    }

        void OnMouseOver()
    {
        active = true;
        if (Input.GetMouseButtonDown(0))
        {
            textToDisplay.text = individualTitle + "\n" + "\n" + individualText + "\n" + individualText2;
        }

    }
        void OnMouseExit()
    {
        active = false;
    }

}
