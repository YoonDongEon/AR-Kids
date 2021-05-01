using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touchparticle : MonoBehaviour
{
    public GameObject obj;
    void sen() {
        obj.SetActive(false);
    }
    void Update()
        {

            if (Input.touchCount>0)
            {
                Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                obj.SetActive(true);
                obj.transform.position = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved) {
               obj.transform.position = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                Invoke("sen", 2);
            }
        }

        }

}
