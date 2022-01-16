using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ui 를 조작하기위해 필요하다.
using UnityEngine.UI;

public class CurrentScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //text 속성을 조작해서 Score.cs 파일에 static으로 만든 변수인 Score를 넣어준다
        GetComponent<Text>().text = "Score: "+ Score.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
