using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    public KeyCode resetScene, resetGame, quitGame, nextScene;

    public bool allowToGoNextScene;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ResetScene();
        ResetGame();
        QuitGame();
        
        if (allowToGoNextScene == true)
            goNextScene();
    }

    void ResetScene()
    {
        if (Input.GetKeyDown(resetScene))
        {
            Debug.Log("reserScene");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void ResetGame()
    {
        if (Input.GetKeyDown(resetGame))
        {
            Debug.Log("resetGame");
            SceneManager.LoadScene(0);
        }
    }

    void QuitGame()
    {
        if (Input.GetKeyDown(quitGame))
        {
            Debug.Log("QuitGame");
            Application.Quit();
        }
    }

    void goNextScene()
    {
        if (Input.GetKeyDown(nextScene))
        {
            Debug.Log("toNextScene");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
