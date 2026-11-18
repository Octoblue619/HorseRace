using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManagerScript;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            gameManagerScript.CompleteLevel();
        }
    }

}

