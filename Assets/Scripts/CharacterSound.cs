using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterSound : MonoBehaviour, IPointerEnterHandler
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (audioSource != null) audioSource.Play();
    }
}