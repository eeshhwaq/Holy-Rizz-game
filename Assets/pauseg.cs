using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject pauseg;
    public static bool ispaused;
    // Start is called before the first frame update
    void Start()
    {
        pauseg.SetActive(false);
    }

    public void pausegame()
    {
       pauseg.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
    }
    public void resumegame()
    {
       pauseg.SetActive(false);
        Time.timeScale = 1f;
        ispaused = false;
    }
    public void quitgame()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape ))
        {
            if (ispaused)
                resumegame();
            else
                pausegame();
        }
    }
}
