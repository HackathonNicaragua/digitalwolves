using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldManInteraction : MonoBehaviour 
{
	private BoxCollider2D _boxCollider;
	private Animator _animator;

	public AudioClip Wolf;

	private void Start() 
	{
		_animator = GetComponent<Animator> ();
		_boxCollider = GetComponent<BoxCollider2D> ();
		_boxCollider.enabled = false;
	}

	private void OnMouseDown ()
	{
		Debug.Log ("Clicked on me!");
		_animator.Play ("Viejo Disparando");
		_boxCollider.enabled = false;
	}

	public void MakeInteracteable() 
	{
		_boxCollider.enabled = true;
	}

	public void DestroyCoyote() 
	{
		GameObject.Find ("Coyote").SetActive (false);
		GetComponent<AudioSource> ().PlayOneShot (Wolf);
	}

	public void Shoot() 
	{
		GetComponent<AudioSource> ().Play ();
	}
}
