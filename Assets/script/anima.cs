using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anima : MonoBehaviour
{
    public GameObject[] Ani_GameObj;
    public int Ani_Num;
    public GameObject End_obj;
    public GameObject Time_Start_Obj;
    public GameObject fade;
    public int scene_num;
    public float autoTime;
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        autoTime += Time.smoothDeltaTime;
        if(autoTime>=3.0f)
        {
            click_Ani();
        }
    }
    public void start3()
    {
        if(Time_Start_Obj!=null)
        Time_Start_Obj.GetComponent<AllManager>().GameStart = true;
    }
    public void click_Ani()
    {
        if (Ani_Num >= Ani_GameObj.Length-1)
        {
            start3();
            End_obj.SetActive(false);
            sound.Play();
            return;
        }
        Ani_GameObj[Ani_Num].SetActive(false);
        Ani_Num++;
        autoTime = 0.0f;
        if (Ani_Num < Ani_GameObj.Length)
        {
            Ani_GameObj[Ani_Num].SetActive(true);
        }
    }
    public void click_Ending_Ani()
    {
        if (Ani_Num >= Ani_GameObj.Length - 1)
        {
            if (End_obj != null)
                End_obj.SetActive(false);
            if (fade != null)
            fade.SetActive(true);
            PlayerPrefs.SetInt("Scene", scene_num);
            PlayerPrefs.Save();
            Ani_GameObj[Ani_Num].SetActive(false);
            Ani_Num = 0;
            Ani_GameObj[Ani_Num].SetActive(true);
            return;
        }
        Ani_GameObj[Ani_Num].SetActive(false);
        Ani_Num++;
        if (Ani_Num < Ani_GameObj.Length)
        {
            Ani_GameObj[Ani_Num].SetActive(true);
        }
    }
}
