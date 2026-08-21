using UnityEngine;

public class Trophy : MonoBehaviour
{
    public float rotateSpeed = 50f;

    void Update()
    {
        transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("HAI VINTO!");
            if (GameManager.Instance != null)
                GameManager.Instance.LevelCompleted();
            Destroy(gameObject);
        }
    }
}