using UnityEngine;

public class Character_MovePC : MonoBehaviour
{
    public GameManager Gamemanager;
    [Header("모바일에서는 사용하지 않습니다.")]
    public bool IsMobile = false; //모바일 사용 여부
    float speed,mobiledist,InputX,InputY;
    Rigidbody2D rigid;
    Vector2 joygoTouch,joygoBase;
    // Start is called before the first frame update
    void Start()
    {
        if (IsMobile)
        {
            Destroy(this);
        }
        speed = Gamemanager.speed;
        rigid = GetComponent<Rigidbody2D>();
        //Vect = new Vector2(speedX, speedY) * mobilemove.playerSpeed;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        InputX = Input.GetAxis("Horizontal");
        InputY = Input.GetAxis("Vertical");
        PC_Drag();
    }
    public void PC_Drag()
    {
        if (InputX != 0f || InputY != 0f)
        {
            rigid.velocity = (new Vector2(InputX, InputY) * (2* speed));
        }
        else rigid.velocity = Vector2.zero;
        if (Input.GetButton("Fire3"))
        {
            rigid.velocity = new Vector2 (InputX, InputY) * (16*speed);
        }
        //else MobileJoygo.transform.position = joygoTouch + MobileJoygo.joystickVec * MobileJoygo.joystickRadius;
    }
    //UI 관련 PC 입력을 이용해 모바일에서 적용할 수 있는 방법을 구현해야 하는데.. 
}
