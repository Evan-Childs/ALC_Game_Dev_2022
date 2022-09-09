using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float upperBound = 25.0f;
    private Balloons balloon;
    //public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        balloon = GetComponent<Balloons>(); //reference balloon gameObject
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        moveSpeed = moveSpeed + 0.001f;

        if(transform.position.y > upperBound)
        {
            Destroy(gameObject);
        }
    }
}
