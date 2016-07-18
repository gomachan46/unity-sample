using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public Sprite[] walk;
    int animIndex;
    bool walkCheck;

	// Use this for initialization
	void Start ()
	{
	    animIndex = 0;
	    walkCheck = false;
	}

	// Update is called once per frame
	void Update ()
	{
	    if (walkCheck)
	    {
	        animIndex++;
	        if (animIndex >= walk.Length)
	        {
	            animIndex = 0;
	        }
	        GetComponent<SpriteRenderer>().sprite = walk[animIndex];
	    }

	    if (Input.GetButton("Fire1"))
	    {
	        walkCheck = true;
	        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
	    } else if (Input.GetButtonUp("Fire1") && walkCheck)
	    {
	        walkCheck = false;
	        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
	    }
	}
}
