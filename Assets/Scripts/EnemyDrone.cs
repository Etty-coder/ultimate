using UnityEngine;

public class EnemyDrone : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float detectionDistance = 10f;
    public Transform player;

    void Update()
    {
        if (player == null)
        {
            GameObject p = GameObject.FindGameObjectWithTag("Player");
            if (p != null) player = p.transform;
            return;
        }

        float distance = Vector3.Distance(transform.position, player.position);
        if (distance <= detectionDistance)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
            transform.LookAt(player);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && GameManager.Instance != null)
            GameManager.Instance.PlayerHit();
    }
}