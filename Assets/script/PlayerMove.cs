using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour, IPointerDownHandler, /*IPointerUpHandler*/ IPointerExitHandler, IPointerEnterHandler
{
    public bool OnPointer_Check;
    public GameObject player;
    public int Direction_Type;
    public GameObject[] btn;
    public GameObject Manager;
    Animator m_Animator;
    public GameObject maker;
    public Sprite firstImg;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = player.GetComponent<Animator>();
        firstImg = player.GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    public void moveing()
    {
    }
    void Update()
    {
        if (OnPointer_Check)
        {
            if (Direction_Type == 1)
            {
                m_Animator.SetBool("whait", false);
                m_Animator.SetBool("up", true);
                m_Animator.SetBool("left", false);
                m_Animator.SetBool("right", false);
                m_Animator.SetBool("down", false);
                player.transform.Translate(Vector3.up * speed * Time.smoothDeltaTime);
                moveing();
                maker.GetComponent<SpriteRenderer>().sprite = player.GetComponent<SpriteRenderer>().sprite;
            }
            if (Direction_Type == 2)
            {
                m_Animator.SetBool("whait", false);
                m_Animator.SetBool("up", false);
                m_Animator.SetBool("left", true);
                m_Animator.SetBool("right", false);
                m_Animator.SetBool("down", false);
                player.transform.Translate(Vector3.left * speed * Time.smoothDeltaTime);
                moveing();
                maker.GetComponent<SpriteRenderer>().sprite = player.GetComponent<SpriteRenderer>().sprite;
            }
            if (Direction_Type == 3)
            {
                m_Animator.SetBool("whait", false);
                m_Animator.SetBool("up", false);
                m_Animator.SetBool("left", false);
                m_Animator.SetBool("right", true);
                m_Animator.SetBool("down", false);
                player.transform.Translate(Vector3.right * speed * Time.smoothDeltaTime);
                moveing();
                maker.GetComponent<SpriteRenderer>().sprite = player.GetComponent<SpriteRenderer>().sprite;
            }
            if (Direction_Type == 4)
            {
                m_Animator.SetBool("whait", false);
                m_Animator.SetBool("up", false);
                m_Animator.SetBool("left", false);
                m_Animator.SetBool("right", false);
                m_Animator.SetBool("down", true);
                player.transform.Translate(Vector3.down * speed * Time.smoothDeltaTime);
                moveing();
                maker.GetComponent<SpriteRenderer>().sprite = player.GetComponent<SpriteRenderer>().sprite;
            }
        }
        else if (!OnPointer_Check)
        {

        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        OnPointer_Check = true;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        OnPointer_Check = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        OnPointer_Check = false;
        m_Animator.SetBool("whait", true);
        m_Animator.SetBool("up", false);
        m_Animator.SetBool("left", false);
        m_Animator.SetBool("right", false);
        m_Animator.SetBool("down", false);
        maker.GetComponent<SpriteRenderer>().sprite = firstImg;
    }
    //public void OnPointerUp(PointerEventData eventData)
    //{
    //    OnPointer_Check = false;
    //    Manager.GetComponent<Manger>().Moving[0] = false;
    //    Manager.GetComponent<Manger>().Moving[1] = false;
    //    Manager.GetComponent<Manger>().Moving[2] = false;
    //    Manager.GetComponent<Manger>().Moving[3] = false;
    //    m_Animator.SetBool("whait", true);
    //    m_Animator.SetBool("up", false);
    //    m_Animator.SetBool("left", false);
    //    m_Animator.SetBool("right", false);
    //    m_Animator.SetBool("down", false);
    //    maker.GetComponent<SpriteRenderer>().sprite = firstImg;
    //}
}
