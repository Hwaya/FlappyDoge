using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    GM gm;

    public string scoreString;
    public int scoreLength;
    public string[] scoreSplit;
    

    public Vector2 pivot;

    Object[] temp = new Object[0];

    // Start is called before the first frame update
    void Start()
    {
        gm = GetComponent<GM>();

        //Instantiate(Resources.Load("Prefabs" + GM.singleton.Score.ToString()), new Vector3(0.0f, 0.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        scoreString = GM.singleton.Score.ToString();
        scoreLength = scoreString.Length;
        scoreSplit = scoreString.Split();
        
        for(int i = 0; i < temp.Length; ++i)
        {
            if(temp[i])
            {
                Destroy(temp[i]);
            }
        }

        temp = new Object[scoreLength];


        for (int i = 0; i < scoreLength; ++i)
        {
            temp[i] = Instantiate(Resources.Load( scoreSplit[i]), new Vector3(pivot.x + (i * 50), pivot.y), Quaternion.identity);
            
        }
    }
}
