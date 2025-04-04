using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    [SerializeField] private GameObject notePrefab;
    [SerializeField] private Transform centerPoint;
    [SerializeField] private float spawnRadius = 5f;
    [SerializeField] private int currentNote = 0;
    private int[] noteTimings = new int[] { 3149, 5804, 8274, 9641, 10957, 13146, 13472, 13820, 14133, 14469, 14797, 15109, 15449, 15794, 16114, 16452, 16789, 17108, 17483, 17812, 18122, 18451, 18788, 19101, 19444, 19764, 20088, 20402, 20741, 21032, 21355, 21693, 22299, 22953, 23648, 24340, 24678, 24994, 25306, 25663, 25850, 26201, 26635, 26980, 27578, 28252, 28887, 29581, 29934, 30255, 30567, 30895, 31069, 31507, 31743, 32205, 32522, 32838, 33175, 33486, 33793, 34089, 34453, 34818, 35146, 35474, 35805, 36133, 36341, 36651, 36967, 37431, 37800, 38101, 38466, 38803, 39124, 39424, 39790, 39998, 40396, 41085, 41283, 41729, 42305, 42728, 43368, 44019, 44150, 44685, 45325, 45670, 45989, 46317, 46615, 46803, 47136, 47531, 47915, 48548, 49230, 49862, 50506, 50855, 51180, 51532, 51847, 52051, 52436, 52713, 53098, 53426, 53774, 54100, 54415, 54711, 55042, 55385, 55722, 56056, 56398, 56731, 57085, 57546, 57878, 58313, 58661, 58966, 59343, 59668, 60034, 60225, 60708, 60916, 61355, 62010, 62226, 62672, 63655, 64019, 64338, 65643, 66304 };

    private float startTime;

    private void Start()
    {
        
        startTime = Time.time * 1000;
    }

    private void FixedUpdate()
    {
        CheckAndSpawnNotes();
    }

    private void CheckAndSpawnNotes()
    {
        if (currentNote < noteTimings.Length)
        {
            
            float currentTime = (Time.time * 1000 - startTime); 

            
            if (currentTime >= noteTimings[currentNote])
            {
                SpawnNote(noteTimings[currentNote]);
                currentNote++; 
            }
        }
    }

    private void SpawnNote(int timing)
    {
        
        Vector2 spawnPosition = GetRandomSpawnPosition();
        GameObject note = Instantiate(notePrefab, spawnPosition, Quaternion.identity);
    }

    private Vector2 GetRandomSpawnPosition()
    {
        float angle = Random.Range(0f, 2f * Mathf.PI); 
        float radius = spawnRadius; 
        return new Vector2(
            centerPoint.position.x + Mathf.Cos(angle) * radius,
            centerPoint.position.y + Mathf.Sin(angle) * radius
        );
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(centerPoint.position, spawnRadius);
    }
}
