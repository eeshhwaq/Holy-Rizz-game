using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicman : MonoBehaviour
{
    public int score;
    public Text scoretext;
    public GameObject goscreen;
    public AudioSource audio;
    public AudioClip failaudio;
    public birdie goactive;
    public bool active=true;
    [ContextMenu("score++")]
    public void addscore(int scoretoadd)
    {
        if (goactive.gocheck==false)
        {
            score = score + scoretoadd; ;
            scoretext.text = score.ToString();
        }
    }

    // Start is called before the first frame update
   
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameover()
    {
        if (active)
        {
            audio.clip = failaudio;
            audio.loop = false;
            audio.Play();

            goscreen.SetActive(true);
            active= false;
        }
    }
}
