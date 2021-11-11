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
        distance = Mathf.Sqrt((balls[0].transform.position.x - balls[1].transform.position.x) * (balls[0].transform.position.x - balls[1].transform.position.x) + (balls[0].transform.position.y - balls[1].transform.position.y) * (balls[0].transform.position.y - balls[1].transform.position.y));

        if (distance < balls[0].radius + balls[1].radius)
        {
            Debug.Log("Pego");
        }
    }
}
