using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EatItem : MonoBehaviour
{
    public int Eat_num = 0;
    public GameObject Manager;
    public GameObject tree_text;
    public float playeTimePlus;
    public float playeTimeMiners;
    public GameObject clear;
    public bool stop;
    public float stopTime;
    public GameObject[] arrow;
    public AudioSource effectsound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (stop)
        {
            stopTime += Time.smoothDeltaTime;
            Manager.GetComponent<AllManager>().stop = true;
        }
    }
    public void TimeStop()
    {
        stop = !stop;
        stopTime = 0.0f;
        Manager.GetComponent<AllManager>().stop = false;
    }
    public void speedDown()
    {
        arrow[0].GetComponent<PlayerMove>().speed = 2;
        arrow[1].GetComponent<PlayerMove>().speed = 2;
        arrow[2].GetComponent<PlayerMove>().speed = 2;
        arrow[3].GetComponent<PlayerMove>().speed = 2;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tree")
        {
            Eat_num++;
            tree_text.GetComponent<TextMeshProUGUI>().text = "획득한 나무 개수 : " + Eat_num.ToString();
            Destroy(collision.gameObject);
            effectsound.Play();
        }
        if (collision.gameObject.tag == "chestnut")
        {
            Manager.GetComponent<AllManager>().playeTime += playeTimePlus;
            Destroy(collision.gameObject);
            effectsound.Play();
        }
        if (collision.gameObject.tag == "pain")
        {
            Manager.GetComponent<AllManager>().playeTime -= playeTimeMiners;
            Destroy(collision.gameObject);
            Handheld.Vibrate();
            effectsound.Play();
        }
        if (collision.gameObject.tag == "Clear")
        {
            collision.GetComponent<Clear>().tree = Eat_num;
            Eat_num = 0;
            tree_text.GetComponent<TextMeshProUGUI>().text = "획득한 나무 개수 : " + Eat_num.ToString();
            clear.GetComponent<Clear>().Upgrade();

        }
        if (collision.gameObject.tag == "Blue")
        {
            arrow[0].GetComponent<PlayerMove>().speed = arrow[0].GetComponent<PlayerMove>().speed * 2;
            arrow[1].GetComponent<PlayerMove>().speed = arrow[1].GetComponent<PlayerMove>().speed * 2;
            arrow[2].GetComponent<PlayerMove>().speed = arrow[2].GetComponent<PlayerMove>().speed * 2;
            arrow[3].GetComponent<PlayerMove>().speed = arrow[3].GetComponent<PlayerMove>().speed * 2;
            Invoke("speedDown", 5.0f);
            Destroy(collision.gameObject);
            Handheld.Vibrate();
            effectsound.Play();
        }
        if (collision.gameObject.tag == "Red")
        {
            Invoke("TimeStop", 5.0f);
            if (stop == true)
            {
                stopTime = 0.0f;
            }
            stop = true;
            Destroy(collision.gameObject);
            Handheld.Vibrate();
            effectsound.Play();
        }
    }
}
