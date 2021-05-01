using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Mouseeffect : MonoBehaviour
{
    public GameObject starPrefab;
    float delayTime;
    public float defaultTime = 0.05f;
    
	void Update () {
        if(Input.GetMouseButton(0)&&delayTime >= defaultTime)
            //마우스 커서를 눌렀을 때 delayTime이 defaultTime보다 크다면
        {
            StarCreat();
            delayTime = 0;//초기화
        }
        delayTime += Time.deltaTime;//deltaTime만큼 계속 상승
    }

    
    void StarCreat() {
        Vector3 mPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //월드좌표를 줘서 마우스의 위치값을 저장한다.
        mPosition.z = 0;//z값은 필요없으므로 0 초기화
        Instantiate(starPrefab,mPosition,Quaternion.identity);//프리팹에 인스턴스를 만든다.
    }

   
}
