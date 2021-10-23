using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Quit_Script_01 : MonoBehaviour
{

        public void LoadScene(string level)
        {
            Application.LoadLevel(level);
        }

    public void Quit()
    {
        Application.Quit();
    }
}
