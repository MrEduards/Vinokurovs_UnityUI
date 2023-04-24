using System.Collections;
using UnityEngine;

using UnityEngine.UI;


public class VardaParadisana : MonoBehaviour {



	public string teksts;

	public GameObject ievadesLauks;

	public GameObject tekstaAttelosana;

	public void uzglabaTekstu(){

		teksts = ievadesLauks.GetComponent<Text>().text;
		tekstaAttelosana.GetComponent<Text>().text = "Roblox varonis "+teksts.ToUpper ();
	}
}
