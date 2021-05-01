using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explain : MonoBehaviour
{

    public GameObject exp;
    public AudioSource btnclicksource;

    void Update()
    {
            if (Input.GetMouseButtonDown(0))
            {
                btnclicksource.Play();
                Invoke("Close", 1.5f);
            }
    }

    void Close()
    {
        exp.SetActive(false);
    }

}