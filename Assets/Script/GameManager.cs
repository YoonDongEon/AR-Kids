using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public void MenuOpen()
    {
        this.gameObject.SetActive(true); // Exit 팝업창을 띄운다.
        Time.timeScale = 0f;
    }

    public void ExitYes()
    {
        Application.Quit();   // 앱을 종료
    }

    public void ExitNo()
    {
        Time.timeScale = 1f; // 먼저 시간을 다시 가도록 복원
        this.gameObject.SetActive(false); // Exit 팝업창을 지운다.
    }
}
