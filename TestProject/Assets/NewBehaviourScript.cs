using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(10, 10, 10); //position 값을 10,10,10으로 바꾼다.
        transform.rotation = Quaternion.Euler(30, 60, 90);
        transform.localScale = new Vector3(10, 10, 10);

        Debug.Log("x = " + transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.up);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(100, 100, 100), 0.1f);
        transform.position = Vector3.Lerp(transform.position, new Vector3(100, 100, 100), 0.1f); // 더 자연스러운 속도감 서서히 닫히거나 열림
    }
}
