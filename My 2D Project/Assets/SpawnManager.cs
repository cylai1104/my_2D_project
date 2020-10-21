using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    [Header("生成間隔時間")]
    public float interval = 0.5f;

    private GameObject[] points;
    public GameObject[]notes;

    //
    private int indexRandom;

    public float[] times;
    public Vector3[] ppoints;

    private void Awake()
    {
        points = GameObject.FindGameObjectsWithTag("生成點");
        notes = GameObject.FindGameObjectsWithTag("音符");
        InvokeRepeating("Spawn", 0, interval);

        
    }

    private void Spawn()
    {
        int rd = Random.Range(0, points.Length);
        int ns = Random.Range(0, notes.Length);
        Instantiate(notes[ns], points[rd].transform.position, points[rd].transform.rotation);
    
    }
}
