using UnityEngine;

public class Player_Move : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Player player;
    [SerializeField] private Transform groundCheck;

    public Vector2 movement;

    public bool isJumpPressed;
    public bool jumpHeld;
    public float _direction;
    public bool _isDashing;
    
    private bool _isGrounded;
    private float lowJumpMultiplier = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //방향
        if(rb.linearVelocity.x > 0) _direction = 1;
        else if(rb.linearVelocity.x < 0) _direction = -1;
        //대쉬 할 때 움직임 방지
        if(!_isDashing)
            rb.linearVelocityX = player.state.speed * movement.x;
        //땅에 닿았는지 체크
        _isGrounded = Physics2D.OverlapBox(groundCheck.position, new Vector2(0.6f,0.1f), 0,LayerMask.GetMask("Ground"));
        //점프 활성화
        if (isJumpPressed && _isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, player.state.jumpForce);
            isJumpPressed = false;
            jumpHeld = true;
        }
        //점프 중간에 때면 중력 강화!!
        if (rb.linearVelocity.y > 0 && !jumpHeld)
        {
            rb.linearVelocity +=  Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime * Vector2.up;
        }
    }

    
}
