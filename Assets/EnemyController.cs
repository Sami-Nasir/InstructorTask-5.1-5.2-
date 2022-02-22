using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D rb;
    private GameObject gb;
    //public Vector3 look;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gb = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce((gb.transform.position - transform.position).normalized * speed);
        CheckPos();
    }
    void CheckPos()
    {
        if (rb.position.x > -22 || rb.position.x < -3)
        {
            Destroy(gameObject);
        }
    }
}
