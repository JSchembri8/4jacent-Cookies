using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor_Script_02 : MonoBehaviour
{
    public bool keysCollected = false;
    public GameObject keyObject;
    public bool readyToOpen = false;

    // Update is called once per frame
    void Update()
    {
        if (keyObject.GetComponent<Collected_Script_01>().collectedStatus == true)
        {
            readyToOpen = true;
        }
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && readyToOpen == true)
        {
            keyObject.GetComponent<Collected_Script_01>().showInventory = false;
            gameObject.SetActive(false);
        }
    }
}
