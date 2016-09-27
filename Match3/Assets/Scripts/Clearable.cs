using UnityEngine;
using System.Collections;

public class Clearable : MatchManagerScript {

	public AnimationClip explode; 
	private bool isBeingCleared = false; 
	public bool IsBeingCleared {
		get { return isBeingCleared; }
	}

	protected MatchManagerScript token; 

	void Awake(){
		token = GetComponent<MatchManagerScript> ();

	}
	// Use this for initialization
	void Start () {

		 
	
	}

	public void Clear(){
	
		isBeingCleared = true; 
		StartCoroutine (ClearCoroutine()); 
	
	}

	private IEnumerator ClearCoroutine() {
		Animator animator = GetComponent<Animator> (); 
		if (animator) {
			animator.Play (explode.name);
			yield return new WaitForSeconds (explode.length); 
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
