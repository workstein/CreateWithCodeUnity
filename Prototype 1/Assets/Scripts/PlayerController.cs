using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        // We'll move the vehicle forward.
        transform.Translate(Vector3.forward);
    }
}
