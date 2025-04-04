using UnityEngine;

public class NoteMovement : MonoBehaviour
{
    
    [SerializeField] private Vector3 targetPosition;
    [SerializeField] private float moveDuration;
    [SerializeField] private float startTime;

    private float elapsed;

    private void Start()
    {
        
    }

    public void Initialize(Vector3 target, int timing)
    {
        targetPosition = target;
        moveDuration = timing / 1000f;
        startTime = Time.time;
    }

    void Update()
    {
        elapsed = Time.time - startTime;
        float t = elapsed / moveDuration;
        transform.position = Vector3.Lerp(transform.position, targetPosition, t);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log(elapsed);
            Destroy(gameObject);
        }
    }
}
