﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour {

	public Transform masukanLoadingbar;

	[SerializeField]
	private float nilaiSekarang;
	[SerializeField]
	private float nilaiKecepatan;

	void Update () {
		if (nilaiSekarang < 100) {
			nilaiSekarang += nilaiKecepatan * Time.deltaTime;
			Debug.Log ((int)nilaiSekarang);

		} else {
			Application.LoadLevel ("START");
		}
		masukanLoadingbar.GetComponent<Image> ().fillAmount = nilaiSekarang / 100;
	}

}
