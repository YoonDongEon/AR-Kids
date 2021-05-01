using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expla : MonoBehaviour
{
    public GameObject exp;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Invoke("Close", 5);
        }
    }

    void Close()
    {
        exp.SetActive(false);
    }

}

