using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAlpha_Script_01 : MonoBehaviour
{
    public GameObject keyItem;
    public bool keysCollected = false;
    public Color tempColor;
    // Start is called before the first frame update
    void Start()
    {
        tempColor = gameObject.GetComponent<Renderer>().material.color;
        tempColor.a = 1;
    }

    // Update is called once per frame
    void Update()
    {
        keysCollected = keyItem.GetComponent<Collected_Script_01>().collectedStatus;
        if (keysCollected)
        {
            gameObject.GetComponent<Renderer>().material.color = tempColor;
        }
    }
}
