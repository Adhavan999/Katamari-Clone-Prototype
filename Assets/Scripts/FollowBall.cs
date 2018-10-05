using UnityEngine;

public class FollowBall : MonoBehaviour {
    Vector3 CameraLookOffset;
    public float yoffset, zoffset;
    public GameObject player;
    public float rotspeed;
    
	void Start ()
    {
        zoffset = yoffset * 2; //2.5 and 5 are ideal starting distances
        CameraLookOffset = new Vector3(player.transform.position.x, player.transform.position.y + yoffset, player.transform.position.z + zoffset);
    }
	
	void Update ()
    {
        CameraLookOffset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotspeed, Vector3.up) * CameraLookOffset;
        Changecamdistance(Input.GetAxis("Mouse ScrollWheel"));
        transform.position = player.transform.position + CameraLookOffset;
        transform.LookAt(player.transform.position);
	}
    public void Changecamdistance(float camdistancefactor)
    {
        CameraLookOffset =Vector3.Scale( CameraLookOffset , new Vector3(1, 1 + camdistancefactor, 1 + camdistancefactor));
    }
}
