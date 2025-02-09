using UnityEngine;

public class player : MonoBehaviour
{
    private BoxCollider2D boxcollider;
    private Vector3 moveDelta;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boxcollider = GetComponent<BoxCollider2D>();
    }

// Update is called once per physics update
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        
        //set moveDelta
        moveDelta = new Vector3(x,y,0);

        // make sprite look in direction of movement
        if (moveDelta.x > 0)
        {
            transform.localScale = Vector3.one;
        }
        else if (moveDelta.x < 0)
        {
            transform.localScale = new Vector3(-1,1,1);
        }

        // move player
        transform.Translate(moveDelta * Time.deltaTime);

    }
}
