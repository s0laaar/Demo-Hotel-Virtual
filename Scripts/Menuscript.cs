using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuscript : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
