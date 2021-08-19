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
        textToDisplay.text = "Test\nText";
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
