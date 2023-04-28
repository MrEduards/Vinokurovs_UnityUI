using System.Collections;
using UnityEngine;

using UnityEngine.UI;


public class VardaParadisana : MonoBehaviour {
	void Update (){

	}


	public string teksts;
	public int vecums;

	public GameObject ievadesLauks;
	public GameObject tekstaAttelosana;

	public void uzglabaTekstu(){
		teksts = ievadesLauks.GetComponent<Text>().text;
		int.TryParse(teksts, out vecums);
		tekstaAttelosana.GetComponent<Text>().text = teksts + " ir " + vecums + " gadus vecs!";
	}
}
