using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    [Header("隨機生成音符")]
    public GameObject[] noteRandoms;
    [Header("生成間隔時間")]
    public float interval = 0.5f;
    [Header("全部生成點")]
    public GameObject[] points;
    [Header("指定fa")]
    //public GameObject fa;
    [Header("指定so")]
    //public GameObject so;
    [Header("指定ra")]
    //public GameObject ra;
    [Header("指定si")]
    //public GameObject si;
    [Header("指定c5")]
    //public GameObject c5;
    [Header("指定re")]
    //public GameObject re;
    [Header("指定c4")]
    //public GameObject c4;
    [Header("指定mi")]
    public GameObject mi;
    //private int indexRandom;
   
   
   // [Space(50)]
   [Header("指定生成音符")]
    public GameObject[] noteAssigns;
   [Header("指定生成時間")]
    public float[] assignTimes;
   // [Header("指定生成位置")]
   // public int[] assignPoints;
    

   // private int indexAssign;
    

    private void Awake()
    {
        points = GameObject.FindGameObjectsWithTag("生成點");
        //noteRandoms = GameObject.FindGameObjectsWithTag("音符");
       // noteAssigns = GameObject.FindGameObjectsWithTag("指定音符");
       
        InvokeRepeating("SpawnRandom", 0, interval);
        //StartCoroutine(AssignSpawnObject());
        
    }

    private void SpawnRandom()
    {
       // while (indexRandom == assignPoints[indexAssign])

        {
            int indexRandom = Random.Range(0, points.Length);
            int r = Random.Range(0, noteRandoms.Length); 
           // print(r);
           // print(indexRandom);
            Instantiate(noteRandoms[r], points[indexRandom].transform.position, points[indexRandom].transform.rotation);
            //Instantiate(fa, points[indexRandom].transform.position, points[indexRandom].transform.rotation);
            //Instantiate(so, points[indexRandom].transform.position, points[indexRandom].transform.rotation);
            //Instantiate(ra, points[indexRandom].transform.position, points[indexRandom].transform.rotation);
            //Instantiate(si, points[indexRandom].transform.position, points[indexRandom].transform.rotation);
            //Instantiate(c5, points[indexRandom].transform.position, points[indexRandom].transform.rotation);
            //Instantiate(c4, points[indexRandom].transform.position, points[indexRandom].transform.rotation);
            //Instantiate(re, points[indexRandom].transform.position, points[indexRandom].transform.rotation);
            //Instantiate(mi, points[indexRandom].transform.position, points[indexRandom].transform.rotation);
        }
        

    }
    //private IEnumerator AssignSpawnObject()
    //{
       // for (int i = 0; i < assignPoints.Length; i++)
        //{
            //yield return new WaitForSeconds(assignTimes[indexAssign]);
           // Transform point = points[assignPoints[indexAssign]].transform;
            //int a = noteAssigns.Length;
           // Instantiate(noteAssigns[a], point.transform.position, point.transform.rotation);
            //if (i < assignPoints.Length -1 ) indexAssign++;
 

        //}
    
    //}
        
    
    
}
