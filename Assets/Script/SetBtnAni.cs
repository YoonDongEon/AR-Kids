using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBtnAni : MonoBehaviour
{
    private void Update()
    {
        Invoke("AniPlay", 4);
    }
    public void AniPlay()
    {
        gameObject.GetComponent<Animation>().Play();
    }
    
}
