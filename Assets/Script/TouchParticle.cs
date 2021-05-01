using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchParticle : MonoBehaviour
{
    public GameObject starPrefab;
    float delayTime;
    public float defaultTime = 0.05f;

    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector3 mPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            starPrefab.SetActive(true);
            StarCreat();
        }
        if (Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            starPrefab.SetActive(false);
        }
    }


    void StarCreat()
    {
        Vector3 mPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //월드좌표를 줘서 마우스의 위치값을 저장한다.
        starPrefab.transform.position = mPosition;
    }

}
