using UnityEngine;

public class Character_MoveMobile : MonoBehaviour
{
    public MobileJoystickUI Mobilejoygo;
    public Character_MovePC PCcontrol;
    public GameManager Gamemanager;
    float playerSpeed;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        if (!PCcontrol.IsMobile)
        {
            Destroy(this);
        }
        else DontDestroyOnLoad(this);
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }

        playerSpeed = Gamemanager.speed;
    }
    public void MobileMove()
    {
        if (Mobilejoygo.joystickVec.y != 0)
        {
            rb.velocity = new Vector2(Mobilejoygo.joystickVec.x * playerSpeed, Mobilejoygo.joystickVec.y * playerSpeed);
        }
        else rb.velocity = Vector2.zero;
    }
    
    private void FixedUpdate()
    {
        MobileMove();
    }
}