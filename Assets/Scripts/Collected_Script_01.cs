using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collected_Script_01 : MonoBehaviour
{
    public bool collectedStatus = false;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {

            collectedStatus = true;
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
