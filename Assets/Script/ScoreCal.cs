using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCal : MonoBehaviour
{
    // Start is called before the first frame update
    public static int scoreUser = 0 ;
    void Start()
    {
        scoreUser = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = scoreUser.ToString();
    }
}
