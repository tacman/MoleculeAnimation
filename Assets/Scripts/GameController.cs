using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public int maxMolecules = 9;
	public Hydrogen hydrogenPrefab;
	// do we need this for anything?  
	// private List<Hydrogen> hydrogens = new List<Hydrogen>();
	

    // Use this for initialization
	void Start () {
		for (var i =0; i<maxMolecules; i++)
		{
			// playing area is a hard-coded 10x10x10 box, molecules have a 2x2x2 scale 
			var go = Instantiate(
				hydrogenPrefab,
				new Vector3(0f, // Random.Range(-9.0f, 9.0f), 
					9.0f, // Random.Range(-9.0f, 9.0f), 
					0.0f), // Random.Range(-9.0f, 9.0f)),
				Quaternion.identity);

			go.GetComponent<Rigidbody>().velocity = new Vector3(
				Random.Range(-5.0f, 5.0f),
				Random.Range(-5.0f, 5.0f),
				Random.Range(-5.0f, 5.0f));
				
			// hydrogens.Add(go);
		}
		
    }

}
