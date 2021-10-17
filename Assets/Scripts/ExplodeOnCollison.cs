using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOnCollison : MonoBehaviour
{

    [SerializeField] GameObject explosionPrefab;

    void OnTriggerEnter(Collider other)
    {
        Instantiate(explosionPrefab).transform.position = transform.position;
        Destroy(gameObject);
    }
}
