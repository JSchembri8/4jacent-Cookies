using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColour_Script_1 : MonoBehaviour
{
    public bool collectedStatus = false;
    public int correctColour = 0;
    public int currentColour = 0;
    public Color[] colours = new Color[4];
    public GameObject light;
    public Light lightColor;

    void Start()
    {
        lightColor = light.GetComponent<Light>();
        colours[0] = Color.white;
        colours[1] = Color.blue;
        colours[2] = Color.red;
        colours[3] = Color.green;
    }
    void Update()
    {
        lightColor.color = colours[currentColour];
        Debug.Log(currentColour);
        if (currentColour == correctColour)
        {
            collectedStatus = true;
        }
        else
        {
            collectedStatus = false;
        }
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && currentColour < 3)
        {
            currentColour++;
        }
        else if (Input.GetMouseButtonDown(0))
        {
            currentColour = 0;
        }
    }
}
