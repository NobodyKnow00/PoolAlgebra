using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    [SerializeField] private BallMovement[] balls;
<<<<<<< Updated upstream
    [SerializeField] private DrawFrame[] frames;
    [SerializeField] private BallMovement[] hole;
=======
>>>>>>> Stashed changes
    [SerializeField] private float fric;
    [SerializeField] private float grav;
    [SerializeField] private float mass;
    [SerializeField] private float radius;

    private float distance;

    private float distanceBtwHoleAndBall;


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

<<<<<<< Updated upstream
        for (int i = 0; i < frames.Length; i++)
        {
            for (int j = 0; j < balls.Length; j++)
            {
                px = balls[j].transform.position.x;

                if (px < frames[i].transform.position.x - frames[i].sizeX / 2)
                {
                    px = frames[i].transform.position.x - frames[i].sizeX / 2;
                }

                if (px > frames[i].transform.position.x - frames[i].sizeX / 2 + frames[i].sizeX)
                {
                    px = frames[i].transform.position.x - frames[i].sizeX / 2 + frames[i].sizeX;
                }

                pz = balls[j].transform.position.z;

                if (pz < frames[i].transform.position.z - frames[i].sizeZ / 2)
                {
                    pz = frames[i].transform.position.z - frames[i].sizeZ / 2;
                }

                if (pz > frames[i].transform.position.z - frames[i].sizeZ / 2 + frames[i].sizeZ)
                {
                    pz = frames[i].transform.position.z - frames[i].sizeZ / 2 + frames[i].sizeZ;
                }

                distanceBallsFrames = Mathf.Sqrt((balls[j].transform.position.x - px) * (balls[j].transform.position.x - px) + (balls[j].transform.position.z - pz) * (balls[j].transform.position.z - pz));

                if (distanceBallsFrames < balls[j].radius)
                {
                    Debug.Log("ImpactoBordes");
                }
            }
        }

        for (int i = 0; i < hole.Length; i++)
        {
            for (int j = 0; j < balls.Length; j++)
            {
                distanceBtwHoleAndBall = Vector3.Distance(balls[j].transform.position, hole[i].transform.position);

                if (distanceBtwHoleAndBall <= hole[i].radius)
                {
                    Debug.Log("Entro");
                }
            }
        }
=======
        
>>>>>>> Stashed changes
    }
}
