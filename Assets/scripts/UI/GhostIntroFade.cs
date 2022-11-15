using NewsSystem;
using SoundPlayer;

namespace UI
{
    public class GhostIntroFade : ImageFade
    {
        private void Awake()
        {
            NewsStore.Subscribe<IntroFin>(_ => FadeOut());
        }
        
        
    }
}