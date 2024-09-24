using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resault2 : MonoBehaviour
{
    Player miss3;

    // Start is called before the first frame update
    void Start()
    {
        miss3 = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (miss3.missCount > 2)
        {
            transform.position = new Vector3(-3.0f, -60.0f, 0.0f);
        }
    }
}
