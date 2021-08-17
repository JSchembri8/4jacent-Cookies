using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class ClickToRead_Script_01 : MonoBehaviour
{
    public GameObject canvas;
    public bool read = false;
    public bool doNotClose = true;


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
        }

    }
        void OnMouseExit()
    {
        doNotClose = false;
    }

}
