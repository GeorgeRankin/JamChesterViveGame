﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelayedSceneLoad : MonoBehaviour {

	[SerializeField]
	float introScreenDelay = 10.0f;
		
	void Start () {
		StartCoroutine(LoadGameLevel());
	}
	
	private IEnumerator LoadGameLevel() {
		yield return new WaitForSeconds(introScreenDelay);		
		SceneManager.LoadSceneAsync("MainGame");
	}
}

