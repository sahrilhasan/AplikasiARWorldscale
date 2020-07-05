using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public void GoToMainMenu(){
		Application.LoadLevel("main_menu");
	}
	public void GoToInfo(){
		Application.LoadLevel("info");
	}


	public void GoToWorldScaleAR(){
		Application.LoadLevel("WorldScaleAR");
	}
	public void GoToTutorial(){
		Application.LoadLevel("tutorial");
	}

}
