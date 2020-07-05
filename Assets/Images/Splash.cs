using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour
{
   void Start() {
		StartCoroutine(Example());
	}

	IEnumerator Example() {
		yield return new WaitForSeconds(2);
		Application.LoadLevel ("loading");
        
    }
}
