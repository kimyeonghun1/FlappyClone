//import 하는 코드. 필요한 모듈들을 가져왔다.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//c#의 클래스 정의. MonoBehaviour를 상속받앗다.
public class BirdJump : MonoBehaviour
{
    //Rigidbody2D를 받을 수 있는 상자는 rb 이다.
    Rigidbody2D rb;

    public float jumpPower; //점프 변수
    
    //접근제한자를 아무것도 붙이지 않으면 외부 파일에서 접근할 수 없다.
    //public 접근 제한자를 붙이면 유니티 스크립트에 추가된다.
    


    // Start 는 처음 한번만 실행된다
    void Start()
    {
        //Rigidbody2D라는 컴포넌트르 불러오겠다.
        rb = GetComponent<Rigidbody2D>();
        //JS의 console.log와 같은 기능
        Debug.Log("Start 입니다.");
    }

    // Update 는 계속 실행된다. 매 프레임마다 코드를 검사한다.
    void Update()
    {
         Debug.Log("Update 입니다.");
         //0은 마우스 왼쪽 버튼을 의미.
         if(Input.GetMouseButtonDown(0)){ 
             //velocity 는 속도를 나타내는 속성이다.
            
             rb.velocity = Vector2.up * 3;
             //Vector2는 이차원 좌표 (0,1)의미한다. *3했으므로 (0,3)
         }
    }
}

    //  1. Rigidbody2D 클래스를 가진 rb 변수를 선언해준다.
    //  2. Start()안에서 rb변수에 GetComponent로 Rigidbody2D를 담아준다
    //  3. Update()에 매 프레임마다 마우스 버튼이 눌렸는지 검사를 해서 
    //     velocity의 값을 Vector2를 이용해 up으로 3만큼 가도록 변경해준다.
