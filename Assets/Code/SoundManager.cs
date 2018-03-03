using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {
    public Slider musicSlider;
    public AudioSource musicSource;
    public Slider effectsSlider;
    public AudioSource effectsSource;

    public void BackgroundMusicValue() {
        //for background music
        musicSource.volume = musicSlider.value;
    }

    public void SoundEffectsValue() {
        //for sound effects (so far: explosions)
        effectsSource.volume = effectsSlider.value;
    }

    public void ExplodeMe() {
        effectsSource.Play();

    }
}
