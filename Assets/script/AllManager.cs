using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllManager : MonoBehaviour
{
    public float playeTime;
    public float Maxplayetime;
    public GameObject Gauge_img;
    public bool GameStart;
    public GameObject boat;
    public bool end;
    public bool stop;
    public GameObject[] Fail_Ani;
    public GameObject[] item;
    public float itemTime;
    public int randitem;
    public float posx;
    public float posy;
    public GameObject[] sound;
    public int clearpoint;
    void Start()
    {
        Maxplayetime = playeTime;
        Screen.SetResolution(1920, 1080, true);
        //PlayerPrefs.DeleteAll();
        clearpoint = boat.GetComponent<Clear>().clearType;
    }
    // Update is called once per frame
    void Update()
    {

        if (GameStart)
        {
            itemTime += Time.smoothDeltaTime;
            if (itemTime >= 1.0f)
            {
                randitem = Random.Range(0,item.Length);
                Debug.Log(randitem);
                posx = Random.Range(-7.4f, 25.0f);
                posy = Random.Range(-19.0f, 6.30f);
                Instantiate(item[randitem], transform.position = new Vector3(posx, posy, 0), transform.rotation);
                itemTime = 0;
            }
            if (playeTime >= Maxplayetime)
            {
                playeTime = Maxplayetime;
            }
            if (!stop)
                playeTime -= Time.smoothDeltaTime;
            if (playeTime >= 0.1f)
            {
                Gauge_img.GetComponent<Image>().fillAmount = playeTime / Maxplayetime;
            }
            else if (playeTime <= 0.0f)
            {
                if (!end)
                {
                    Debug.Log(clearpoint);
                    if (clearpoint == 0)
                    {
                        Fail_Ani[clearpoint].SetActive(true);
                        PlayerPrefs.SetInt("success1_End", 1);
                        PlayerPrefs.Save();
                    }
                    else if (clearpoint == 1)
                    {
                        Fail_Ani[clearpoint].SetActive(true);
                        PlayerPrefs.SetInt("Fail1_End", 1);
                        PlayerPrefs.Save();
                    }
                    else if (clearpoint == 2)
                    {
                        Fail_Ani[clearpoint].SetActive(true);
                        PlayerPrefs.SetInt("success2_End", 1);
                        PlayerPrefs.Save();
                    }
                    else if (clearpoint == 3)
                    {
                        Fail_Ani[clearpoint].SetActive(true);
                        PlayerPrefs.SetInt("Fail2_End", 1);
                        PlayerPrefs.Save();
                    }
                    else if (clearpoint == 4)
                    {
                        Fail_Ani[clearpoint].SetActive(true);
                        PlayerPrefs.SetInt("success3_End", 1);
                        PlayerPrefs.Save();
                    }
                    else if (clearpoint == 5)
                    {
                        Fail_Ani[clearpoint].SetActive(true);
                        PlayerPrefs.SetInt("Fail3_End", 1);

                        PlayerPrefs.Save();
                    }
                    else if (clearpoint == 6)
                    {
                        Fail_Ani[clearpoint].SetActive(true);
                        PlayerPrefs.SetInt("success4_End", 1);
                        PlayerPrefs.Save();
                    }
                    else if (clearpoint == 7)
                    {
                        Fail_Ani[clearpoint].SetActive(true);
                        PlayerPrefs.SetInt("Fail4_End", 1);
                        PlayerPrefs.Save();
                    }
                    else if (clearpoint == 8)
                    {
                        Fail_Ani[clearpoint].SetActive(true);
                        PlayerPrefs.SetInt("success5_End", 1);
                        PlayerPrefs.Save();
                    }
                    else if (clearpoint == 9)
                    {
                        Fail_Ani[clearpoint].SetActive(true);
                        PlayerPrefs.SetInt("Fail5_End", 1);
                        PlayerPrefs.Save();
                    }
                    else if (clearpoint == 10)
                    {
                        Fail_Ani[clearpoint].SetActive(true);
                        PlayerPrefs.SetInt("success6_End", 1);
                        PlayerPrefs.Save();
                    }

                    Time.timeScale = 0;
                    for (int i = 0; i < sound.Length - 1; i++)
                    {
                        sound[i].SetActive(false);
                    }
                    end = true;
                }
            }
        }
    }
}
