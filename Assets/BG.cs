using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    public float posx;
    public float posy;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        posy = Random.Range(75.0f,150.0f);
        speed = Random.Range(1.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (posx <= -1920.0f)
        {
            posx = 2000.0f;
            posy = Random.Range(50.0f, 150.0f);
            speed = Random.Range(1.0f, 2.0f);
        }
        posx -= speed;
        transform.position = new Vector3(posx, posy, 0);

    }
}
