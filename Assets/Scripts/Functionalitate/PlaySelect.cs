using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySelect : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level1");
    }

    // Update is called once per frame
    public void Play2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level2");
    }
}
