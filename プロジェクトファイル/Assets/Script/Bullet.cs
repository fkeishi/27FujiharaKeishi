using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // ’e‚ÌXÀ•W
    float bulletX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        bulletX = this.transform.position.x;

        this.transform.Translate(0.5f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
