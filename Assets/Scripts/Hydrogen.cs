using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydrogen : MonoBehaviour {

    AudioSource audioSource;
    public AudioClip audioClipBallBounce;
    public ParticleSystem WallParticleSystem;
    public ParticleSystem BondingParticleSystem;

    private GameObject _partner = null;
    private SpringJoint springJoint;
    private Rigidbody rb;
    
    private static readonly int _color = Shader.PropertyToID("_Color");

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (_partner == null && other.gameObject.CompareTag("Hydrogen"))
        {
            // there are 2 sphere colliders of different radii.  The outer one is bouncy and a trigger, the inner one is for physics.
            Hydrogen otherHydrogen = (Hydrogen)other.gameObject.GetComponent<Hydrogen>();

            if (otherHydrogen._partner == null) // two free radicals meet and form covalent bond
            {
<<<<<<< HEAD
                if (BondingParticleSystem != null)
                {
                    BondingParticleSystem.transform.position = other.transform.position;
=======
                if (BondingParticleSystem)
                {
>>>>>>> master
                    BondingParticleSystem.Play();
                }
                _partner = other.gameObject;
                otherHydrogen._partner = this.gameObject;
                
                //Get the Renderer component from the new cube
                gameObject.GetComponent<Renderer>().material.SetColor(_color, Color.green);
                _partner.GetComponent<Renderer>().material.SetColor(_color, Color.yellow);

                // chemical bond formation suddenly pulls slightly closer together
                var transform1 = this.transform;
                
                // @todo: there's probably a way to use vector operations to do this.
                float deltaX = _partner.transform.position.x - transform1.position.x;
                float deltaY = _partner.transform.position.y - transform1.position.y;
                float deltaZ = _partner.transform.position.z - transform1.position.z;
                
                transform1.position = new Vector3(
                    transform1.position.x + 0.25f * deltaX,
                    transform1.position.y + 0.25f * deltaY,
                    transform1.position.z + 0.25f * deltaZ);
                _partner.transform.position = new Vector3(
                    _partner.transform.position.x - 0.25f * deltaX,
                    _partner.transform.position.y - 0.25f * deltaY,
	                _partner.transform.position.z - 0.25f * deltaZ);
                    
	            // @todo: change the color of both.

                // create SpringJoint to implement covalent bond between these two atoms
                springJoint = this.gameObject.AddComponent<SpringJoint>();
                springJoint.connectedBody = other.gameObject.GetComponent<Rigidbody>();
                springJoint.anchor = new Vector3(0, 0, 0);
                springJoint.connectedAnchor = new Vector3(0, 0, 0);
                
                springJoint.spring = 10;
                springJoint.minDistance = 0.0f;
                springJoint.maxDistance = 0.0f;
                springJoint.tolerance = 0.025f;
                springJoint.breakForce = Mathf.Infinity;
                springJoint.breakTorque = Mathf.Infinity;
                springJoint.enableCollision = false;
                springJoint.enablePreprocessing = true;
            }
        }
        
        if (other.gameObject.CompareTag("Wall"))
        {
            if (WallParticleSystem != null)
            {
                WallParticleSystem.transform.position = other.transform.position;
                WallParticleSystem.Play();
            }
            else
            {
                Debug.Log("Bumped into a wall, but no particle system.");
            }


	        audioSource.PlayOneShot(audioClipBallBounce, 0.25f);
            
        }
    }

}
