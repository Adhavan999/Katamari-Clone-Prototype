using UnityEngine;

public class BallMovement : MonoBehaviour {

    public float PushForce, SideForce, JumpForce;
    Rigidbody ball;
    Vector3 ForceVector, zzero,forward,sideward;
    public GameObject followcam;

    private void Start()
    {
        ball = GetComponent<Rigidbody>();
        zzero = new Vector3( 1, 0, 1);
    }

    void FixedUpdate () {
        // Ball movement side to side
        forward = Vector3.Scale(followcam.transform.forward * PushForce * Input.GetAxis("Vertical"), zzero);
        sideward = Vector3.Scale(followcam.transform.right * SideForce * Input.GetAxis("Horizontal"), zzero);
        ball.AddForce(sideward + forward);

        //Ball movement for jumping
        if(Input.GetButton("Jump"))
        {
            Jump();
        }
    }
    void Jump()
    {
        
    }
    void IncreasePushFactor(float x)
    {

    }
}

