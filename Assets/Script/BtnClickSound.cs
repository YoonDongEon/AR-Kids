using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class BtnClickSound : MonoBehaviour
{
    public AudioSource btnclicksources;

    public void OnBtnClick()
    {
            btnclicksources.Play();
    }
}
