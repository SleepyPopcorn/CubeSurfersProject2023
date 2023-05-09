using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]


public class GemController : MonoBehaviour
{
    public bool rotate;

    public float rotationSpeed;

    public AudioClip collectSound;

    public GameObject collectEffect;

    void Start()
    {
        
    }

    void Update () {

		if (rotate)
			transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime, Space.World);

	}

    void OnTriggerEnter(Collider other)
	{
		if (other.name == "MainCube"  || other.name == "Cube") {
			Collect ();
		}
	}

    public void Collect()
	{
		if(collectSound)
			AudioSource.PlayClipAtPoint(collectSound, transform.position);

		if(collectEffect)
			Instantiate(collectEffect, transform.position, Quaternion.identity);

		Debug.Log("Gem Collected");
		ScoreManager.instance.AddGemScore();

		Destroy (gameObject); 
	}
}
