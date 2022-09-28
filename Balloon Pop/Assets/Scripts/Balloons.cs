using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloons : MonoBehaviour
{
    public int ScoreToGive = 1;
    public int clickToPop = 3;
    public float scaleToIncrease = 0.1f;
    private ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        //Reference ScoreManager Component
        scoreManager = GameObject.Find("ScoreManager");
        GetComponent<ScoreManager>();
    }

    void OnMouseDown()
    {
        //Reduce clicks by one
        clickToPop --;

        //Increase balloon size
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clickToPop == 0)
        {
            ScoreManager.IncreaseScoreText(scaleToGive);
            Destroy(gameObject);
        }
    }
}
