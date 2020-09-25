using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update

    //begin game for main menu button
    public void BeginGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    //retry game from end screen (same as BeginGame now but may need updates later)
    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    //return to main menu (resets the game)
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //unpause from pause menu
    public void Unpause()
    {
        Manager.instance.UnpauseGame();
    }
}
