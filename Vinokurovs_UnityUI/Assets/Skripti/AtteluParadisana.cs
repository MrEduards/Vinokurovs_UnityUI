using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {

	public GameObject Virietis;
	public GameObject Sieviete;
	public GameObject kurRadit;
	public Sprite[] koRadit;

	public GameObject slaideris;
	public GameObject slaideris2;


	public void VirAttelosana(bool vertiba)
	{
		Virietis.SetActive(vertiba);
		Sieviete.SetActive(!vertiba);
	}

	public void SievAtteloosana(bool vertiba)
	{
		Sieviete.SetActive(vertiba);
		Virietis.SetActive(!vertiba);
	}


	public void izkritosais(int indekss){


		if (indekss == 0)
			kurRadit.GetComponent<Image> ().sprite = koRadit [0];
		else if (indekss == 1)
			kurRadit.GetComponent<Image> ().sprite = koRadit [1];
		else if (indekss == 2)
			kurRadit.GetComponent<Image> ().sprite = koRadit [2];
		else if (indekss == 3)
			kurRadit.GetComponent<Image> ().sprite = koRadit [3];
		else if (indekss == 4)
			kurRadit.GetComponent<Image> ().sprite = koRadit [4];
		else if (indekss == 5)
			kurRadit.GetComponent<Image> ().sprite = koRadit [5];
		else if (indekss == 6)
			kurRadit.GetComponent<Image> ().sprite = koRadit [6];
		else if (indekss == 7)
			kurRadit.GetComponent<Image> ().sprite = koRadit [7];
		else if (indekss == 8)
			kurRadit.GetComponent<Image> ().sprite = koRadit [8];
		else if (indekss == 9)
			kurRadit.GetComponent<Image> ().sprite = koRadit [9];
		else if (indekss == 10)
			kurRadit.GetComponent<Image> ().sprite = koRadit [10];
		else if (indekss == 11)
			kurRadit.GetComponent<Image> ().sprite = koRadit [11];
		else if (indekss == 12)
			kurRadit.GetComponent<Image> ().sprite = koRadit [12];
		else if (indekss == 13)
			kurRadit.GetComponent<Image> ().sprite = koRadit [13];
		

	}



		

	  

		




	
	

	public void mainitLielumu(){
		float pasreizejaVertiba = slaideris.GetComponent<Slider> ().value;
		kurRadit.transform.localScale = 
			new Vector3 (1f*pasreizejaVertiba, 1f, 1f*pasreizejaVertiba);
	}
		public void mainitAugstumu ()
	{
		float pasreizejaVertiba = slaideris2.GetComponent<Slider> ().value;
		kurRadit.transform.localScale = 
				new Vector3 (1f * pasreizejaVertiba, 2f * pasreizejaVertiba, 1f * pasreizejaVertiba);
	}
}
		
	
	
	



