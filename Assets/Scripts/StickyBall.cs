using UnityEngine;

public class StickyBall : MonoBehaviour {

    public GameObject followcam;
    public float camdistancefactor = 0, SizeScaleFactor = 0.08f;
  

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Sticky")
        {
            transform.localScale += new Vector3(SizeScaleFactor, SizeScaleFactor, SizeScaleFactor);
            camdistancefactor += 0.1f;
            followcam.GetComponent<FollowBall>().Changecamdistance(camdistancefactor);
            col.enabled = false;
            col.transform.SetParent(this.transform);
   
        }
    }
}
