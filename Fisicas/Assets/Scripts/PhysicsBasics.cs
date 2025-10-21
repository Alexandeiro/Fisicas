using UnityEngine;

public class PhysicsBasics : MonoBehaviour
{

    //public
    public Rigidbody playerRigidBody;
    public float jumpForce = 500;
    public float speedMove = 200;
    public Detector detector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    private void Update()
    {
        //jump
        if (Input.GetKeyDown(KeyCode.Space) && detector.floorContact == true)
        {
            playerRigidBody.AddForce(Vector3.up * jumpForce);
        }
    }

    // FixedUpdate for Physics
    void FixedUpdate()
    {
        

        playerRigidBody.AddForce(Input.GetAxis("Horizontal") * speedMove, 0, Input.GetAxis("Vertical") * speedMove);
    }
}
