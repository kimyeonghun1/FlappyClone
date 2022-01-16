using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    //GameObject를 pipe라는 변수로 받는다.
    public GameObject pipe;
    public float timeDiff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        //Time.deltaTime은 1/프레임 초이다.
       timer += Time.deltaTime;
       // 1/프레임 초를 계속 더해준 값인 timer가 1이 되는 순간은
       // 1초 라는 뜻이다. 
       if(timer > timeDiff){
        //pipe라는 GameObject가 Instantiate를 통해 실행되게 된다.
        GameObject newpipe = Instantiate(pipe);

        newpipe.transform.position = new Vector3(3, Random.Range(-1.05f, -6.0f ),0);
        //타이머를 다시 0으로 초기화 시켜준다.
        timer = 0;
        //newpipe를 5초 뒤에 파괴해라.
        Destroy(newpipe, 10.0f);


       }
        
    }
}
