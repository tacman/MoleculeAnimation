using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour {

	public int maxMolecules = 9;
	public Hydrogen hydrogenPrefab;
	private List<Hydrogen> hydrogens = new List<Hydrogen>();


	private void OnEnable()
	{
		maxMolecules = PlayerPrefs.GetInt("maxMolecules", maxMolecules);
		Debug.Log(maxMolecules);
		Debug.Log(GameConfig.Complexity);
	}

	// Use this for initialization
	void Start () {
		Hydrogen go;
		for (var i =0; i<maxMolecules; i++) {
			go = Instantiate(
				hydrogenPrefab,
				new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
				Quaternion.identity);
			
			go.GetComponent<Rigidbody>().velocity = new Vector3(
				Random.Range(-5.0f, 5.0f),
				Random.Range(-5.0f, 5.0f),
				Random.Range(-5.0f, 5.0f));
				
			hydrogens.Add(go);
		}
		
		
		return;
		// @todo:return yield with short delay?
		
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        hydrogens.Add(Instantiate(
            hydrogenPrefab,
            new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f)),
            Quaternion.identity));
        foreach (Hydrogen hydrogen in hydrogens)
        {
            hydrogen.GetComponent<Rigidbody>().velocity = new Vector3(
                Random.Range(-5.0f, 5.0f),
                Random.Range(-5.0f, 5.0f),
                Random.Range(-5.0f, 5.0f));
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
