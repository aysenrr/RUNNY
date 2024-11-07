using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip clickSound;
    [SerializeField] private TextMeshProUGUI _text;

    private void Awake()
    {
        _text.text = Score.totalScore.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectibles"))
        {
            Score.totalScore++;
            AudioSource.PlayClipAtPoint(clickSound, other.transform.position);
            Destroy(other.gameObject);
            _text.text = Score.totalScore.ToString();
        }
    }
}