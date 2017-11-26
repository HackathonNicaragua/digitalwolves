using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandia : MonoBehaviour 
{
	public int Hp;
	public AudioClip Clip;

	public LevelManager levelManager;

	private void OnMouseDown()
	{
		GetComponent<AudioSource> ().PlayOneShot (Clip);
		Hp--;
		GetComponent<Animator> ().Play ("Sandia Comida");

		if (Hp < 1) {
			levelManager.LoadLevel ("QuizTioCoyote");
		}
	}
}
