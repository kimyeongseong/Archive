using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBGmove : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x-0.01f, transform.position.y);
        if (transform.position.x<=28.9)
        {
            transform.position = new Vector2(0.0f, transform.position.y);

        }
    }
}
