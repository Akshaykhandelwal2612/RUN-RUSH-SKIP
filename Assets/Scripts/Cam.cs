using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private Vector3 tempPosition;
    private Transform player;

    [SerializeField]
    private float minX, maxX;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        
    }


    // Update is called once per frame
    void LateUpdate()
    {

        if (!player)
            return;

        tempPosition = transform.position;
        tempPosition.x = player.position.x;

        if (tempPosition.x < minX)
            tempPosition.x = minX;

        if (tempPosition.x > maxX)
            tempPosition.x = maxX;

        transform.position = tempPosition;
    }
}
