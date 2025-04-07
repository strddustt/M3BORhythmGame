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
    private void FixedUpdate()
    {
        
        elapsed = Time.time - startTime;
        float t = elapsed / moveDuration;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, t);
    }

    public void Initialize(Vector3 target, int timing)
    {
        targetPosition = target;
        moveDuration = timing / 1000f;
        startTime = Time.time;
    }

   
}
