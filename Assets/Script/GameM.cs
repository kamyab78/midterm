using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;
public class GameM : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameoverCan;

    public void gameover()
    {
        gameoverCan.SetActive(true);
        Time.timeScale = 0;
    }
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reply()
    {
        SceneManager.LoadScene(0);
    }
}
