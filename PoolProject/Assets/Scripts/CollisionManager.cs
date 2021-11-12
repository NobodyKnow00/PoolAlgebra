using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    [SerializeField] private BallMovement[] balls;

    private float distance;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {

                if (i != j)
                {
                    distance = Mathf.Sqrt((balls[i].transform.position.x - balls[j].transform.position.x) * (balls[i].transform.position.x - balls[j].transform.position.x) + (balls[i].transform.position.y - balls[j].transform.position.y) * (balls[i].transform.position.y - balls[j].transform.position.y));
                    if (distance < balls[i].radius + balls[j].radius)
                    {
                        Debug.Log("Pego");
                    }
                }
            }
        }

    }
}
