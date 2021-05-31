using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycasting : MonoBehaviour
{
    public GameObject cam;

    public Image pointer;
    float timeElapsed;

    public Transform DoorEnterPos;

    public Transform TVPos;
    public GameObject TVScreen;

    public Transform BathroomPos;
    public Transform BathroomPos2;

    public GameObject tap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        reticle();
    }

    void reticle()
    {
        RaycastHit hit;
        Vector3 forward = cam.transform.TransformDirection(Vector3.forward * 1000);
        if(Physics.Raycast(cam.transform.position,forward, out hit))
        {
            if (hit.transform.tag == "Door")
            {
                pointer.fillAmount = timeElapsed / 3;
                timeElapsed = timeElapsed + Time.deltaTime;

                if (timeElapsed >= 3)
                {
                    //문 안으로 이동 로직
                    StartCoroutine(moveToPosition());
                    timeElapsed = 3;
                    Debug.Log("DoorHIT");
                }
            }
            else if (hit.transform.tag == "TV")
            {

                pointer.fillAmount = timeElapsed / 3;
                timeElapsed = timeElapsed + Time.deltaTime;

                if (timeElapsed >= 3)
                {
                    StartCoroutine(moveToTV());
                    TVScreen.SetActive(true);
                    timeElapsed = 3;
                }
            }
            else if (hit.transform.tag == "BathRoom")
            {

                pointer.fillAmount = timeElapsed / 3;
                timeElapsed = timeElapsed + Time.deltaTime;

                if (timeElapsed >= 3)
                {
                    StartCoroutine(moveToBathRoom());
                    timeElapsed = 3;
                }
            }
            else if (hit.transform.tag == "BathRoom02")
            {

                pointer.fillAmount = timeElapsed / 3;
                timeElapsed = timeElapsed + Time.deltaTime;

                if (timeElapsed >= 3)
                {
                    StartCoroutine(moveToBathRoom2());
                    timeElapsed = 3;
                }
            }
            else if (hit.transform.tag == "tap")
            {

                pointer.fillAmount = timeElapsed / 3;
                timeElapsed = timeElapsed + Time.deltaTime;

                if (timeElapsed >= 3)
                {
                    tap.SetActive(true);
                    //StartCoroutine(moveToBathRoom2());
                    timeElapsed = 3;
                }
            }else if(hit.transform.tag == "Button")
            {
                pointer.fillAmount = timeElapsed / 3;
                timeElapsed = timeElapsed + Time.deltaTime;

                if (timeElapsed >= 3)
                {
                    hit.transform.GetComponent<Button>().onClick.Invoke();
                    timeElapsed = 3;
                }
                    
            }

            else
            {
                pointer.fillAmount = timeElapsed / 3;
                timeElapsed = timeElapsed - Time.deltaTime;
                if (timeElapsed <= 0)
                {
                    timeElapsed = 0;
                }
            }
        }
        Debug.DrawRay(cam.transform.position, forward, Color.red);
    }

    IEnumerator moveToPosition()
    {
        while(transform.position != DoorEnterPos.position)
        {
            transform.position = 
                Vector3.MoveTowards(transform.position, DoorEnterPos.position, Time.deltaTime*0.01f);
            yield return null;
        }   
    }

    IEnumerator moveToTV()
    {
        while (transform.position != TVPos.position)
        {
            transform.position =
                Vector3.MoveTowards(transform.position, TVPos.position, Time.deltaTime * 0.01f);
            yield return null;
        }

    }
    IEnumerator moveToBathRoom()
    {
        while (transform.position != BathroomPos.position)
        {
            transform.position =
                Vector3.MoveTowards(transform.position, BathroomPos.position, Time.deltaTime * 0.01f);
            yield return null;
        }

    }
    IEnumerator moveToBathRoom2()
    {
        while (transform.position != BathroomPos2.position)
        {
            transform.position =
                Vector3.MoveTowards(transform.position, BathroomPos2.position, Time.deltaTime * 0.01f);
            yield return null;
        }

    }
}
