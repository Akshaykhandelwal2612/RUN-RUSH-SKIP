using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyy : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    private Rigidbody2D Body;

    // Start is called before the first frame update
    void Awake()
    {
        Body = GetComponent<Rigidbody2D>();
        //speed = 5f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Body.velocity = new Vector2(speed, Body.velocity.y);
    }
}
