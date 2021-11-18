using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawFrame : MonoBehaviour
{
    [SerializeField] public float sizeX;
    [SerializeField] public float sizeY;
    [SerializeField] public float sizeZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmosSelected()
    {
        // Draw a yellow cube at the transform position
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, new Vector3(sizeX, sizeY, sizeZ));
    }
}
