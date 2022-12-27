using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroscopeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Camera>().transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        GyroModifyCamera();
    }

    void GyroModifyCamera(){
        transform.rotation=GyroToUnity(Input.gyro.attitude);

    }

    private static Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }
}
