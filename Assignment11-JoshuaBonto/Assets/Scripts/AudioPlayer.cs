using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AudioPlayer : MonoBehaviour {
	private AudioSource[] Audio;
	public AudioClip SoundEffect;
	public Slider[] Sliders;
	// Use this for initialization
	void Start () {
		Audio = GetComponents<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void playEffectRaw(){
		Audio[0].volume = Sliders [0].value;
		Audio[0].PlayOneShot (SoundEffect);
	}
	public void playEffect1(){
		Audio[1].volume = Sliders [1].value;
		Audio[1].PlayOneShot (SoundEffect);
	}
	public void playEffect2(){
		Audio[2].volume = Sliders [2].value;
		Audio[2].PlayOneShot (SoundEffect);
	}
}
