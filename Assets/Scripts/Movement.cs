using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField]
    private Vector3 direction;

    [SerializeField]
    private float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed;
    }


}
