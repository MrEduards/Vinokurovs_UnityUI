using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzAttela : MonoBehaviour {
	public AudioSource kurAtskanot;
	public AudioClip koAtskanot;

	public void UzbiditsAttela(){
		kurAtskanot.PlayOneShot (koAtskanot);
	}

	public void NojietAttela(){
		kurAtskanot.Stop ();
	}
}