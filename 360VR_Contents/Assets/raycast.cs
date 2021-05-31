using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        raycasting();
    }

    void raycasting()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward * 1000);

        //충돌 발생시 정보 가져옴
        if(Physics.Raycast(transform.position,forward,out hit))
        {
            //부딪힌 것만
            //인스턴스화되어있는 컴포넌트에 접근. 
            //클릭 함수 호출
            hit.transform.GetComponent<Button>().onClick.Invoke();
            Debug.Log("hit!!!");
        }
        Debug.DrawRay(transform.position, forward, Color.red);
    }
}
