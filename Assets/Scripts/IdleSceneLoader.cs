using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IdleSceneLoader : MonoBehaviour
{
    [SerializeField] private float idleTimeLimit = 2f;
    
    private Vector3 lastPosition;
    private float idleTimer;

    private void Start()
    {
        lastPosition = transform.position;
        idleTimer = 0f;
    }

    private void Update()
    {
        if (transform.position != lastPosition)
        {
            idleTimer = 0f;
            lastPosition = transform.position;
        }
        else
        {
            idleTimer += Time.deltaTime;
            
            if (idleTimer >= idleTimeLimit)
            {
                SceneManager.LoadScene(5);
            }
        }
    }
}
