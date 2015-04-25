using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerStats : MonoBehaviour {

    public Text HealthVal;
    public Text DamageVal;
    public Text MoveVal;
    public Text JumpVal;
    public Text ExtraPoints;

    public int health;
    public int damage;
    public int moveSpeed;
    public int jumpHeight;
    public int totalPoints;
    public int extraPoints;

    

    void Awake()
    {

    }

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        // change stats
        // add
        if( Input.GetKeyDown( KeyCode.U ) )
        {
            AddHealth();
        }
        else if( Input.GetKeyDown( KeyCode.I ) )
        {
            AddDamage();
        }
        else if( Input.GetKeyDown( KeyCode.O ) )
        {
            AddMovespeed();
        }
        else if( Input.GetKeyDown( KeyCode.P ) )
        {
            AddJumpHeight();
        }

        // subtract
        else if( Input.GetKeyDown( KeyCode.J ) )
        {
            SubtractHealth();
        }
        else if( Input.GetKeyDown( KeyCode.K ) )
        {
            SubtractDamage();
        }
        else if( Input.GetKeyDown( KeyCode.L ) )
        {
            SubtractMovespeed();
        }
        else if( Input.GetKeyDown( KeyCode.Semicolon ) )
        {
            SubtractJumpHeight();
        }

        extraPoints = totalPoints - ( health + damage + moveSpeed + jumpHeight );

        HealthVal.text   = health.ToString();
        DamageVal.text   = damage.ToString();
        MoveVal.text     = moveSpeed.ToString();
        JumpVal.text     = jumpHeight.ToString();
        ExtraPoints.text = extraPoints.ToString();
	}

    public void AddHealth()
    {
        if( extraPoints > 0 )
        {
            health++;
            extraPoints--;
        }
    }

    public void AddDamage()
    {
        if( extraPoints > 0 )
        {
            damage++;
            extraPoints--;
        }
    }

    public void AddMovespeed()
    {
        if( extraPoints > 0 )
        {
            moveSpeed++;
            extraPoints--;
        }
    }

    public void AddJumpHeight()
    {
        if( extraPoints > 0 )
        {
            jumpHeight++;
            extraPoints--;
        }
    }

    public void SubtractHealth()
    {
        if( health > 0 )
        {
            health--;
            extraPoints++;
        }
    }

    public void SubtractDamage()
    {
        if( damage > 0 )
        {
            damage--;
            extraPoints++;
        }
    }

    public void SubtractMovespeed()
    {
        if( moveSpeed > 0 )
        {
            moveSpeed--;
            extraPoints++;
        }
    }

    public void SubtractJumpHeight()
    {
        if( jumpHeight > 0 )
        {
            jumpHeight--;
            extraPoints++;
        }
    }
}
