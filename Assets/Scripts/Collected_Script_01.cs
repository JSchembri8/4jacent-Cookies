using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collected_Script_01 : MonoBehaviour
{
    public bool collectedStatus = false;

    void OnMouseOver()
    {
        Debug.Log("MOUSEOVER");
        if (Input.GetMouseButtonDown(0))
        {

            collectedStatus = true;
            Debug.Log("Collected" + collectedStatus);
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
