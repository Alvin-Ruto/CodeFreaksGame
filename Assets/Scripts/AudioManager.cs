using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    private AudioSource musicSource;
    private AudioSource sfxSource;

    [Header("Sound Effects")]
    public AudioClip buttonClickSound;
    public AudioClip pieceMoveSound;

    [Header("Music")]
    public AudioClip introSound;     
    public AudioClip gameplaySound;  

    private bool isMuted = false;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            
            musicSource = gameObject.AddComponent<AudioSource>();
            musicSource.loop = true;
            musicSource.playOnAwake = false;

            
            sfxSource = gameObject.AddComponent<AudioSource>();
            sfxSource.loop = false;
            sfxSource.playOnAwake = false;

            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateBackgroundMusic(scene.name);
    }

    public void UpdateBackgroundMusic(string sceneName)
    {
        if (musicSource == null) return;

        AudioClip newClip = null;

        if (sceneName == "MainMenu" || sceneName == "LevelSelect")
        {
            newClip = introSound;
        }
        else
        {
            newClip = gameplaySound;
        }

        if (musicSource.clip != newClip)
        {
            musicSource.clip = newClip;
            if (!isMuted) musicSource.Play();
        }
    }

    // Toggle Mute (for toggle button)
    public void ToggleMute(bool mute)
    {
        isMuted = mute;

        if (mute)
        {
            musicSource.Stop();
        }
        else
        {
            musicSource.Play();
        }
    }

    // Called by SoundToggleController
    public bool IsMuted()
    {
        return isMuted;
    }

    // Button Click Sound
    public void PlayButtonClick()
    {
        if (!isMuted && buttonClickSound != null)
        {
            sfxSource.PlayOneShot(buttonClickSound);
        }
    }

    
    public void PlayPieceMoveSound()
    {
        if (!isMuted && pieceMoveSound != null)
        {
            sfxSource.PlayOneShot(pieceMoveSound);
        }
    }
}
