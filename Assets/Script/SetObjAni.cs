using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjAni : MonoBehaviour
{
    void Update()
    {
        gameObject.GetComponent<Animation>().Play();
    }
}
