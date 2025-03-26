using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class RingRenderer : MonoBehaviour
{
    public int segments = 100;           // Number of segments to define the ring
    public float radius = 5f;            // Radius of the ring
    public float lineWidth = 0.1f;       // Thickness of the line

    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        DrawRing();
    }

    public void DrawRing()
    {
        lineRenderer.positionCount = segments + 1; // +1 to close the loop
        lineRenderer.loop = true;                 // Close the circle
        lineRenderer.widthMultiplier = lineWidth;

        Vector3[] points = new Vector3[segments + 1];

        for (int i = 0; i <= segments; i++)
        {
            float angle = i * 2 * Mathf.PI / segments;
            float x = Mathf.Cos(angle) * radius;
            float y = Mathf.Sin(angle) * radius;

            points[i] = new Vector3(x, y, 0);
        }

        lineRenderer.SetPositions(points);
    }
}
