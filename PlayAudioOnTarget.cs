using UnityEngine;
using Vuforia;

public class PlayAudioOnTarget : MonoBehaviour
{
    private AudioSource audioSource;
    private ObserverBehaviour observerBehaviour;

    void Start()
    {
        audioSource = GetComponentInChildren<AudioSource>();
        observerBehaviour = GetComponent<ObserverBehaviour>();

        if (observerBehaviour)
        {
            observerBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }

        // Ensure audio doesn't play on start
        audioSource.Stop();
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        if (status.Status == Status.TRACKED || status.Status == Status.EXTENDED_TRACKED)
        {
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }
}
