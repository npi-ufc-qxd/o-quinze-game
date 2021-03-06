﻿using UnityEngine;
using System.Collections;

public class JogadorFase4 : JogadorBase {
	
	public override void moverX(){
		proximoX = 0;
	}

	public override void moverXMobile(){
		proximoX = 0;
	}
	void OnControllerColliderHit (ControllerColliderHit hit) {
		if (hit.gameObject.tag == "Cerca")
			Perdeu ();
	}

	void FixedUpdate(){
		if (Time.time < tempoAnimacao){
			return;
		}

		if (transform.position.z > 1000.0)
			Ganhou ();

		if (Input.GetMouseButton (0)) {
			Debug.Log ("abaixa");
			tempoAbaixado = 1.0f;
		} 
	}

	public override int getPontos(string tagHit){
		return 1;
	}
} 
