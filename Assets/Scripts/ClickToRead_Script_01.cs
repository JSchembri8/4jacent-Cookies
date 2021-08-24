using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickToRead_Script_01 : MonoBehaviour
{
    public Text textToDisplay;
    public GameObject canvas;
    public bool read = false;
    public bool doNotClose = true;
    public string individualText;
    public string individualTitle;

    void Start()
    {
        textToDisplay.text = "Mum seemed confused about why I wanted to keep the old\n dollhouse we found while cleaning out grandma’s home.\n\nOr really, she seemed confused about the dollhouse itself,\n like it was something she’d never seen before & didn’t understand.\n\nThe dollhouse was old but had been kept safely hidden away\n & covered with a dusty sheet, like grandma didn’t want\n it to get lost or broken but didn’t want to look at it either.";
        read = true;
        doNotClose = false;
    }
    void Update()
    {
        if (read)
        {
            canvas.SetActive(true);
        }
        else
        {
            canvas.SetActive(false);
        }
        if (Input.GetMouseButtonDown(0) && read && doNotClose == false)
        {
            read = !read;
        }
    }

        void OnMouseOver()
    {
        doNotClose = true;
        if (Input.GetMouseButtonDown(0))
        {
            read = true;
            textToDisplay.text = individualTitle + "\n" + individualText;
        }

    }
        void OnMouseExit()
    {
        doNotClose = false;
    }

}
