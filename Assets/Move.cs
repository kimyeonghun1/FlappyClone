using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    //속도를 조절하기 위한 변수 speed.
    //public을 했기 때문에 유니티 inspector창에서 조절가능하다.
  
    void Start()
    {
        
    }

   
    void Update()
    {
        //Rigidbody2D는 Getcomponent를 통해 가져와서
        //속성을 사용해야하지만
        //transform은 기본적으로 포함하고있는 컴포넌트라
        //그냥 사용하면 된다.
        transform.position += Vector3.left * speed * Time.deltaTime; 
        //Vector3.left는 (-1,0,0)을 의미
        //Time.deltaTime은 FPS에 따른 이동의 차이를 보정하기 위해서 사용해준다.
        //deltaTime이란 1/Fps이다.
        Debug.Log(transform.position);//좌표를 출력.
    }
}
