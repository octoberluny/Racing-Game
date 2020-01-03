using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    public float speedmodifier;

	// Use this for initialization
	void Start ()
    {
        speedmodifier = Random.Range(0.1f, 3.0f);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        IguanaCharacter ic = collision.gameObject.GetComponent<IguanaCharacter>();
        ic.Buff(speedmodifier, 2);

        Destroy(gameObject);
    }
}
