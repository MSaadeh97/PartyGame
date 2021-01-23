using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    

    void Update()
    {
        if (transform.position.y < -2f)
        {
            Destroy(gameObject);
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
