using System.Collections.Generic;
using MyEvents;
using NewsSystem;
using UnityEngine;

namespace SoundPlayer
{
    public class SoundPlayer : MonoBehaviour
    {
        [SerializeField] private AudioSource music;
        [SerializeField] private AudioSource sfx;
        [SerializeField] private AudioSource voice;
        [SerializeField] private AudioSource ui;
        [SerializeField] private AudioClip[] audioClips;
        private Dictionary<string, AudioClip> clipsLoaded = new();

        private void Start()
        {
            foreach (var clip in audioClips)
            {
                clipsLoaded[clip.name] = clip;
            }
            NewsStore.Subscribe<MainMenuLoaded>(loaded => PlayMusic("MainMenu"));
            NewsStore.Subscribe<LevelLoaded>(loaded =>
            {
                PlayMusic("MusicLevel");
                PlayVoice("Intro_FX");
            });
            NewsStore.Subscribe<ButtonClicked>(loaded => PlayUI("Click"));
            NewsStore.Subscribe<PickObject>(loaded => PlaySfx("PickObject"));
            NewsStore.Subscribe<PlayVoice>(OnVoiceLoaded);
            NewsStore.Subscribe<FinalFinal>(final => PlayMusic("WinLevel") );
            NewsStore.Subscribe<CreditsLoaded>(_ => PlayMusic("Credits"));
        }

        private void OnVoiceLoaded(PlayVoice obj)
        {
            PlayVoice(obj.voice);
        }

        public void PlayMusic(string clipName)
        {
            if (!clipsLoaded.ContainsKey(clipName)) return;
            music.clip = clipsLoaded[clipName];
            music.Play();
        }
        
        public void PlaySfx(string clipName)
        {
            if (!clipsLoaded.ContainsKey(clipName)) return;
            sfx.clip = clipsLoaded[clipName];
            sfx.Play();
        }
        
        public void PlayVoice(string clipName)
        {
            if (!clipsLoaded.ContainsKey(clipName)) return;
            voice.clip = clipsLoaded[clipName];
            voice.Play();
        }
        
        public void PlayUI(string clipName)
        {
            if (!clipsLoaded.ContainsKey(clipName)) return;
            ui.clip = clipsLoaded[clipName];
            ui.Play();
        }

        private void Update()
        {
            if (voice.clip != null && voice.clip.name == "Intro_FX" && !voice.isPlaying)
            {
                NewsStore.Publish<DialogUnloaded>();
                NewsStore.Publish<IntroFin>();
                voice.clip = null;
            }
            
            if (voice.clip != null && voice.clip.name == "Dress" && !voice.isPlaying)
            {
                NewsStore.Publish<FinalFinal>();
                voice.clip = null;
            }
        }
    }
}
