using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UnityUI를 사용할때 import해줘야 할 것.
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //
    public static int score = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //.ToString 사용시 문자열로 형변환 해준다.
        GetComponent<Text>().text = score.ToString();
    }
}
