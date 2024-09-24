using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resault : MonoBehaviour
{
    Player miss2;

    // Start is called before the first frame update
    void Start()
    {
        miss2 = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(miss2.missCount > 2)
        {
            transform.position = new Vector3(0.0f, 100.0f, 0.0f);
        }
    }
}
