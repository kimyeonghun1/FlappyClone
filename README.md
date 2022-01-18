# FlappyClone

강의를 보며 유니티와 C#을 이용해 안드로이드에서 돌릴 수 있는 간단한 게임을 만들었습니다.



클릭을 하면 새가 날며 장애물 사이를 통과하면 점수를 얻는 간단한 구조입니다.

![](https://user-images.githubusercontent.com/92971200/149912484-b302fe91-c786-441b-8fcc-9edb1a9ffe0b.png)



점프기능은 if문을 이용해  velocity를 사용해 이차원 좌표를 조작해 주는 방식으로 구현했습니다.

```C#
rb= Getcomponent<Rigidbody2D>();


if(Input.GetmouseButtonDown(0)){
 rb.velocity = Vector2.up *3;
}
```



장애물에 부딪쳤을때 Collider 속성을 충돌체들끼리 부딪쳤을때 GameOverScene이 로드되고 게임이 끝납니다.

```c#
private void OnCollisionEnter2D(Collision2D other){
SceneManager.LoadScene("GameOverScene")
}
```





게임 오버 화면은 다음과 같습니다.

![](https://user-images.githubusercontent.com/92971200/149912469-eeaf86e1-6e72-4b09-ab42-b18b4ad72896.png)

Score파일을 따로 분리해서 만든 후 static으로 score변수를 선언해 ScoreUp파일에서도 사용 할수 있도록 했습니다. 그 후 ScoreUp파일에 아래와 같은 코드를 이용해 Collider 통과시 점수가 1씩 올라가도록 했습니다.

```c#
private void OnTriggerEnter2D(collider2D other){
	Score.score +=1;
}
```



![](![image-20220118180439925](https://user-images.githubusercontent.com/92971200/149912499-8bc7821e-f9f6-4708-bfd0-6515c1f9e1a5.png)





Best Score는 역시 Score파일에 static으로 선언된 BestScore가  if문을 이용해 현제 점수가 최고 점수보다 높다면 최고점수에 현제점수를 대입하도록 했습니다.

```c#
if(Score.score > Score.Bestcore){
	Score.BestScore = Score.score;
}
```



어려웠던 점은 프레임에 따른 장애물 생성 부분이었습니다.  프레임변동에 따른 유저간 차이를 없애기 위해 deltaTime 이라는 개념을 사용하는데 demtaTime은 1/프레임 (초) 입니다.60프레임일 경우 1/60초 입니다.

1초를 표현하는 방법이 특이했습니다.

```c#
float timer = 0;

void Update(){
	timer += Time.deltaTime;
}
```

timer변수를 만든 후 1프레임마다 한 번씩 실행되는 update()안에 1/프레임을 의미하는 deltaTime이 1프레임마다 1씩 증가되게 함으로써 timer변수가 1이 되는 순간이 1초가 됩니다.



timeDiff변수를 새로 만든후 timer가 timeDiff보다 클경우만 이라는 if문을 걸어 장애물이 몇초마다 한번씩 생성 될 지 정할 수 있도록 구현했습니다. vector3값은 x축 좌표를 고정해 두고 y측 좌표만 Random.Range()를 이용해 정해진 범위 내에서 랜덤으로 장애물이 생성되게 했습니다. 그 후 timer변수가 다시 0으로 초기화 되고 과도한 렉 방지를 위해 만들어진 파이프는 일정 시간 후에 사라지도록 했습니다.

```c#
if(timer > timeDiff){
	GameObject newpipe = Instantiate(pipe);
	newpipe.transform.position = new Vector3(3, Random.Range(-1.05f, -6.0f ),0);
    timer = 0;
    Destroy(newpipe, 10.0f);
}
```











