using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        this.transform.position += new Vector3(0.0f, 0.0f, -0.5f);

        if (this.transform.position.z < -10.0f)
        {
            Destroy(this.gameObject);
        }

    }
}
