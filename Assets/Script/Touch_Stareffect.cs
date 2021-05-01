using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_Stareffect : MonoBehaviour {

    SpriteRenderer sprite;
    Vector2 direction;
    public float moveSpeed=0.1f;//별의 이동속도 조절
    public float minSize=0.1f;
    public float maxSize=0.3f;
    public float sizeSpeed = 1f;
    public float colorSpeed = 5;

    public Color[] colors;
    void Start () {
        sprite = GetComponent<SpriteRenderer>();//여러 색상을 고를 수 있게 하기 위해 SpriteRenderer를 불러온다.
        direction = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));//랜덤하게 움직인다.
        float size = Random.Range(minSize,maxSize);//별의 크기가 minSize와 maxSize사이로 계속 조절된다.
        transform.localScale = new Vector2(size, size);
        sprite.color = colors[Random.Range(0, colors.Length)];//입력되는 sprite의 값에 따라 자유롭게 색을 선택가능하다.
	}
	
	void Update () {
        transform.Translate(direction*moveSpeed);//오브젝트를 direction 방향으로 이동시킨다.
        transform.localScale = Vector2.Lerp(transform.localScale, Vector2.zero, Time.deltaTime * sizeSpeed);

        Color color = sprite.color;
        color.a = Mathf.Lerp(sprite.color.a, 0, Time.deltaTime * colorSpeed);
        sprite.color = color;

        if (sprite.color.a <= 0.01f)
            Destroy(gameObject);//
	}
}
