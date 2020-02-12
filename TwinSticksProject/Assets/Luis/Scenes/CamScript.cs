using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    public GameObject player;
    public float dist2Player;
    public float camAngle;
    private Vector3 plCamVector = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(camAngle, 0.0f, 0.0f);
        plCamVector = new Vector3(0.0f, Mathf.Sin(Mathf.Deg2Rad*camAngle), - Mathf.Cos(Mathf.Deg2Rad * camAngle)) * dist2Player;
        transform.position = player.transform.position + plCamVector;
    }
}
