using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("音符")]
    public Transform music;
    [Header("生成間隔時間")], Range(0f, 3f)]
    public float interval = 2f;

    private GameObject[] points;

    private void Awake()
    {
        points = GameObject.FindGameObjectsWith("生成點");
        InvokeRepeating("Spawn", 0, interval);

        
    }

    private void Spawn()
    {
        int r = Random.Range(0, points.Length);
        Instantiate(music, points[r].transform.position, points[r].transform.rotation);
    
    }
}
