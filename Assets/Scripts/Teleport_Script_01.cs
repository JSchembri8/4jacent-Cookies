using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Teleport_Script_01 : MonoBehaviour
{
    public GameObject referenceOne;
    public GameObject referenceTwo;
    public GameObject fadeScreen;
    public bool hasTeleported = false;
    public GameObject player;
    public bool isUp = true;
    public bool isCoroutineExecuting = false;
    public bool isFaded = false;
    public bool isFading = false;
 

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isFading == false)
            {
                isFading = true;
                StartCoroutine(FadeToBlack());
                StartCoroutine(Teleport(0.8f));
            }
           
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        if (isCoroutineExecuting)
            yield break;

        isCoroutineExecuting = true;
        Debug.Log("Executing");
        yield return new WaitForSeconds(time);

        hasTeleported = false;
        player.GetComponent<PlayerMovement_Script_01>().enabled = true;
        Debug.Log("COOLDOWN RESET");

        isCoroutineExecuting = false;
    }
    IEnumerator FadeToBlack(bool isFading = true, float fadeSpeed = 2f)
    {
        Color objectColor = fadeScreen.GetComponent<Image>().color;
        float fadeAmount;
        if (isFading)
        {
            while (fadeScreen.GetComponent<Image>().color.a < 1)
            {
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                fadeScreen.GetComponent<Image>().color = objectColor;
                yield return null;
            }
        }
        if (!isFading)
        {
            while (fadeScreen.GetComponent<Image>().color.a > 0)
            {
                fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                fadeScreen.GetComponent<Image>().color = objectColor;
                yield return null;
            }
        }
    }
    IEnumerator Teleport(float time)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("Clicking");
        if (hasTeleported == false)
        {
            player.GetComponent<PlayerMovement_Script_01>().enabled = false;
            player.transform.position = referenceTwo.transform.position;
            isUp = false;
            hasTeleported = true;
            Debug.Log("TELEPORTING DOWN");
            StartCoroutine(ExecuteAfterTime(0.2f));
            StartCoroutine(FadeToBlack(false));
            isFading = false;
        }
    }
}
