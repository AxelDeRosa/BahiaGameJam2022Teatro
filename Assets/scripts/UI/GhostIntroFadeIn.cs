using NewsSystem;
using SoundPlayer;

namespace UI
{
    public class GhostIntroFadeIn : ImageFade
    {
        private void Awake()
        {
            NewsStore.Subscribe<IntroFin>(_ => FadeIn());
        }
    }
}