using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indiamusic : MonoBehaviour
{
    public void Re()
    {
        GameObject.Find("Audio Source").GetComponent<AudioSource>().volume = 1;
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Touch touch = Input.GetTouch(0);
            if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("India"))
            {
                if (touch.phase == TouchPhase.Began)
                {
                    GameObject.Find("Audio Source").GetComponent<AudioSource>().volume = 0;
                    gameObject.GetComponent<AudioSource>().Play();
                }
                else if (touch.phase == TouchPhase.Ended)
                {
                    if (gameObject.GetComponent<AudioSource>().isPlaying)
                    {
                        Invoke("Re", 1.1f);
                    }
                }
            }
        }
    }
}
