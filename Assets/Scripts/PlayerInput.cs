using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

    public int healthIntensity;
    public int damageIntensity;
    public float jumpIntensity;
    public float moveIntensity;

    public GameObject playerCenter;
    public GameObject GroundPoint;

    public LayerMask Platforms;

    private PlayerStats stats;

    private Rigidbody2D rigidbod;

    private bool ableToJump = true;

    void Awake()
    {
        stats = GetComponent<PlayerStats>();
        rigidbod = GetComponent<Rigidbody2D>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float moveSpeed = stats.moveSpeed * moveIntensity;
        float jumpSpeed = stats.jumpHeight * jumpIntensity;

        // lock rotation
        transform.localEulerAngles = new Vector3( transform.localEulerAngles.x, 0f, 0f );

        // move left / right
        if( Input.GetKey( KeyCode.A ) )
        {
            transform.position = new Vector3( transform.position.x - moveSpeed, transform.position.y, transform.position.z );
        }
        if( Input.GetKey( KeyCode.D) )
        {
            transform.position = new Vector3( transform.position.x + moveSpeed, transform.position.y, transform.position.z );
        }

        ableToJump = Physics2D.Linecast( playerCenter.transform.position, GroundPoint.transform.position, Platforms );
        if( Input.GetKeyDown( KeyCode.W ) || Input.GetKeyDown( KeyCode.Space ) )
        {
            if( ableToJump )
            {
                rigidbod.AddForce( new Vector2( 0, jumpSpeed ), ForceMode2D.Impulse );
            }
        }
	}


}
