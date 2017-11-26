using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitCutsceneScript : MonoBehaviour {

	private Animator _animator;


	private void Start()
	{
		_animator = GetComponent<Animator> ();
	}

	private void OnMouseDown() 
	{
		_animator.Play ("Hide");
	}
}
