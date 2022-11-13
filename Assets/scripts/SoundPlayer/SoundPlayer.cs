using System.Collections.Generic;
using MyEvents;
using NewsSystem;
using UnityEngine;

namespace SoundPlayer
{
    public class SoundPlayer : MonoBehaviour
    {
        [SerializeField] private AudioSource source;
        [SerializeField] private AudioClip[] audioClips;
        private Dictionary<string, AudioClip> clipsLoaded = new Dictionary<string, AudioClip>();

        private void Start()
        {
            foreach (var clip in audioClips)
            {
                clipsLoaded[clip.name] = clip;
            }
            NewsStore.Subscribe<MainMenuLoaded>(loaded => Play("MainMenu"));
            NewsStore.Subscribe<LevelLoaded>(loaded => Play("MusicLevel"));
        }

        public void Play(string clipName)
        {
            if (!clipsLoaded.ContainsKey(clipName)) return;
            source.clip = clipsLoaded[clipName];
            source.Play();
        }
    }
}
