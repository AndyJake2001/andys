using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour {
    public float curDamage = 0f;
    public float maxDamage = 10f;

    private Rigidbody gameBody;

    // Start is called before the first frame update
    void Start() {
        gameBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {

    }

    private void OnCollisionEnter(Collision collision) {
        curDamage += 1f;
    }
}
