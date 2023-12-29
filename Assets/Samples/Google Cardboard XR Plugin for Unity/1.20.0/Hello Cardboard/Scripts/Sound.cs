using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

	[SerializeField] private AudioClip [] audios;

	private AudioSource controlAudio;

	private void Awake(){

		controlAudio = GetComponent<AudioSource>();

	}

	public void SeleccionAudio(int indice){

		controlAudio.clip = audios[indice];
		controlAudio.Play();

	}

}
