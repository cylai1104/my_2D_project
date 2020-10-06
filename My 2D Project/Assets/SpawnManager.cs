using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    [Header("生成間隔時間"), Range(0f, 3f)]
    public float interval = 2f;

    private GameObject[] points;
    public GameObject[] sigs;

    private void Awake()
    {
        points = GameObject.FindGameObjectsWithTag("生成點");
        sigs = GameObject.FindGameObjectsWithTag("音符");
        InvokeRepeating("Spawn", 0, interval);

        
    }

    private void Spawn()
    {
        int rd = Random.Range(0, points.Length);
        int rs = Random.Range(0, sigs.Length);
        Instantiate(sigs[rs], points[rd].transform.position, points[rd].transform.rotation);
    
    }
}
