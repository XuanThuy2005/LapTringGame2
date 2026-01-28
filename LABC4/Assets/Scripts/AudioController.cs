using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Nhấn Space để Play
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Play();
        }

        // Nhấn S để Stop
        if (Input.GetKeyDown(KeyCode.S))
        {
            audioSource.Stop();
        }
    }
}
