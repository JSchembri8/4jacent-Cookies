using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChangeClick_Script_01 : MonoBehaviour
{
    //Reference: Code from Aspen in Style & Sensibility: 3D Workshop 2021 Discord under ‘#friday-9:30am’.

    //Material Change
    public Material objectMaterial; 
    private Color objectOriginal;


    // Start is called before the first frame update
    void Start()
    {
        objectOriginal = objectMaterial.color;
    }


    void OnMouseOver() //mouse hovers over cube turn its texture yellow.
    {
     objectMaterial.color = Color.red;

    }

    void OnMouseExit() //turn material back to the original.
    {
        objectMaterial.color = objectOriginal;
    }

    // Update is called once per frames
    void Update()
    {
        
    }
}
