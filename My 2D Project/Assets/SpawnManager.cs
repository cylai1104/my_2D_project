using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    [Header("隨機生成物件")]
    public Transform SpawnObjectRandom;
    [Header("生成間隔時間")]
    public float interval = 0.5f;
    [Header("全部生成點")]
    private GameObject[] points;

    private int indexRandom;

    [Space(50)]
    public Transform spawnObjectAssign;
    [Header("指定生成時間")]
    public float[] assignTimes;
    [Header("指定生成位置")]
    public int[] assignPoints;

    private int indexAssign;
    

    private void Awake()
    {
        points = GameObject.FindGameObjectsWithTag("生成點");
        //notes = GameObject.FindGameObjectsWithTag("音符");
        InvokeRepeating("SpawnRandom", 0, interval);
        StartCoroutine(AssignSpawnObject());
        
    }

    private void SpawnRandom()
    {
        while (indexRandom == indexAssign) indexRandom = Random.Range(0, points.Length);
        Instantiate(SpawnObjectRandom, points[indexRandom].transform.position, points[indexRandom].transform.rotation);
    
    }
    private IEnumerator AssignSpawnObject()
    {
        for (int i = 0; i < assignPoints.Length; i++)
        {
            yield return new WaitForSeconds(assignTimes[indexAssign]);
            indexAssign++;
            Instantiate(spawnObjectAssign, points[indexAssign].transform.position, points[indexRandom].transform.rotation);



        }
    
    }
        
    
    
}
