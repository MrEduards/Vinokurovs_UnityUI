using System.Collections;
using UnityEngine;

using UnityEngine.UI;


public class VardaParadisana : MonoBehaviour {
	void Update (){

	}


	public string teksts;
	public double teksts02;


	public GameObject ievadesLauks;

	public GameObject tekstaAttelosana;

	public void uzglabaTekstu(){

		teksts = ievadesLauks.GetComponent<Text>().text;
		tekstaAttelosana.GetComponent<Text> ().text = "Roblox varonis " + teksts.ToUpper () + " ir "+teksts02+" gadus vecs!";
	}
}
