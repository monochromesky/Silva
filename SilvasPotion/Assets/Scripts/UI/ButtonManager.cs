using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void PlayGameBtn(string gameLevel) //Pass in the name of the screen/level we're going to load in this function
    {
        SceneManager.LoadScene(gameLevel);    //Let us do a button press
    }
    public void ExitGame()
    {
        Debug.Log("Quit!"); //Debugging purposes
        Application.Quit();
    }
}
