using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float upperBound = 25.0f;
    private Balloons balloon;
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager");
        GetComponent<ScoreManager>();
        balloon = GetComponent<Balloons>(); //reference balloon gameObject
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        moveSpeed = moveSpeed + 0.001f;

        if(transform.position.y > upperBound)
        {
            Destroy(gameObject);//pop balloon
        }
    }
}
