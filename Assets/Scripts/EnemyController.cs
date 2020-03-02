using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    public GameObject target;

    [SerializeField]
    private float speed = 5f;

    private Rigidbody localRb;

    // Start is called before the first frame update
    void Start() {
        localRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        Vector3 lookDirection = (target.transform.position - transform.position).normalized;
        localRb.AddForce(lookDirection * speed);
    }
}
