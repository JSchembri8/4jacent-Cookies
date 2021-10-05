using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutoutWalls_Script_01 : MonoBehaviour
{
    public GameObject wall;
    public bool isColliding = false;
    private Color alphaColor;
    private Color startColor;
    private float timeToFade = 5f;
    public bool fading = false;

    void Start()
    {
        startColor = wall.GetComponent<Renderer>().material.color;
        alphaColor = gameObject.GetComponent<Renderer>().material.color;
        alphaColor.a = 0;
    }
    void Update()
    {
        /*if (isColliding)
        {
            wall.GetComponent<Renderer>().material.color = Color.Lerp(wall.GetComponent<Renderer>().material.color, alphaColor, timeToFade * Time.deltaTime);
        }
        else if (!isColliding)
        {
            wall.GetComponent<Renderer>().material.color = Color.Lerp(alphaColor, startColor, timeToFade * Time.deltaTime);
        }
        */
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            fading = true;
            StartCoroutine(FadeToBlack(false));
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            fading = false;
            StartCoroutine(FadeToBlack());
        }
    }
    IEnumerator FadeToBlack(bool isFading = true, float fadeSpeed = 5f)
    {
        Color objectColor = wall.GetComponent<Renderer>().material.color;
        float fadeAmount;
        if (isFading)
        {
            while (wall.GetComponent<Renderer>().material.color.a < 1)
            {
                if (fading)
                {
                    break;
                }
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);
                wall.GetComponent<Collider>().enabled = true;
                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                wall.GetComponent<Renderer>().material.color = objectColor;
                yield return null;
            }
            wall.GetComponent<Renderer>().material.color = startColor;
        }
        if (!isFading)
        {
            while (wall.GetComponent<Renderer>().material.color.a > 0)
            {
                if (!fading)
                {
                    break;
                }
                fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);
                wall.GetComponent<Collider>().enabled = false;
                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                wall.GetComponent<Renderer>().material.color = objectColor;
                yield return null;
            }
            wall.GetComponent<Renderer>().material.color = alphaColor;
     

        }
    }
}
