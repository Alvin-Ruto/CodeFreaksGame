using UnityEngine;
using UnityEngine.UI;

public class SoundToggleController : MonoBehaviour
{
    [SerializeField] private Toggle soundToggle; // Drag this from Inspector

    void Start()
    {
        // Try get the toggle from inspector or fallback to scene
        if (soundToggle == null)
        {
            soundToggle = GameObject.Find("Sound")?.GetComponent<Toggle>();
        }

        if (soundToggle != null)
        {
            // Set toggle state based on current mute status
            soundToggle.isOn = !AudioManager.Instance.IsMuted();
            soundToggle.onValueChanged.AddListener(OnToggleChanged);
        }
        else
        {
            Debug.LogWarning("SoundToggleController: Sound toggle not found.");
        }
    }

    private void OnToggleChanged(bool isOn)
    {
        // Enable sound if toggle is ON, otherwise mute
        AudioManager.Instance.ToggleMute(!isOn);
    }
}
