using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItem : MonoBehaviour
{
    float posx;
    float posy;
    public GameObject river;
    public GameObject Spown;
    public bool hide;
    public bool alp;
    float alpha;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("OnDestroyTime", 15.0f);
    }
    public void OnDestroyTime()
    {
        hide = true;
    }
    public void Update()
    {
        if (hide == true)
        {
            Destroy(this.gameObject);
        }
    }
    public void Rand()
    {
        posx = Random.Range(-7.4f, 25.0f);
        posy = Random.Range(-19.0f, 6.30f);
        this.gameObject.transform.position = new Vector3(posx, posy, transform.position.z);
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obj")
        {
            GetComponent<SpriteRenderer>().enabled = false;
            Rand();
            GetComponent<SpriteRenderer>().enabled = true;
        }

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obj")
        {
            GetComponent<SpriteRenderer>().enabled = false;
            Rand();
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obj")
        {
            GetComponent<SpriteRenderer>().enabled = false;
            Rand();
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
