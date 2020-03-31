using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public static GM singleton;

    public void Awake()
    {
        singleton = this;
    }

    public bool GameOver = false;
    public int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameOver)
        {
            SceneManager.LoadScene("Start");
        }
    }
}
