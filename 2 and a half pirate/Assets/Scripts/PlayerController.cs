using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed;
    public float jumpForce;
    public float currentY;

    private Rigidbody rig;

    private void Start()
    {
        currentY = transform.position.y;
    }

    private void Awake()
    {
        // get the rigidbody component
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (Input.GetButtonDown("Jump"))
        {
            TryJump();
        }

        //increasing y
        if(transform.position.y > currentY)
        {
            //print("going up");
            currentY = transform.position.y;
            //rig.AddForce(1, -20, 1);
        }

        //decreasing y
        if (transform.position.y < currentY)
        {
            //print("going down");
            currentY = transform.position.y;
             //rig.AddForce(1, -20, 1);
            
        }

        //standing still
        if(transform.position.y == currentY)
        {
            //print("still");
            currentY = transform.position.y;
        }

        

        print(transform.position.y);
    }

    void Move()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(xInput, 0, zInput) * moveSpeed;
        dir.y = rig.velocity.y;

        rig.velocity = dir;

        Vector3 facingDir = new Vector3(xInput, 0, zInput);

        if(facingDir.magnitude > 0)
        {
            transform.forward = facingDir;
        }

        
    }

    void TryJump()
    {
        Ray ray = new Ray(transform.position, Vector3.down);

        if(Physics.Raycast(ray, 1.5f))
        {
            //rig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            rig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        
    }

    
}
