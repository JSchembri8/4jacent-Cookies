using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTrigger_Script_01 : MonoBehaviour
{
    public bool isColliding = false;
    public Text roomTextObject;
    public string roomText;

    void Update()
    {
        if (isColliding)
        {
            roomTextObject.text = roomText;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isColliding = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isColliding = false;
        }
    }
}
