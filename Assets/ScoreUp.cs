using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    //onTriggerEnter는 진입할때
    //onTriggerExit은 나갈때 사용한다.
   private void OnTriggerEnter2D(Collider2D other) {
       //Score파일 안에서 Score변수를 static으로 선언했으므로
       //이쪽 파일에서 가져와서 사용 가능한 것이다.
       Score.score+=1;
   }
}
