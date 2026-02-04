using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterHover : MonoBehaviour, IPointerEnterHandler
{
    public AudioSource characterSound;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (characterSound != null) characterSound.Play();
    }
}