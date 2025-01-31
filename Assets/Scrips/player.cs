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

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Debug.Log(x);
        Debug.Log(y);

        // Reset move data
       // moveDelta = Vector3.Zero;


    }
}
