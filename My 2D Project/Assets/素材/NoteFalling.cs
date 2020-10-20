using UnityEngine;
using System;
using System.Collections;

public class NoteFalling : MonoBehaviour
{
    public Transform target;
    public float distance;


    private IEnumerator MoveObject(Vector3 startPos, Vector3 endPos, float time)
    {
        var dur = 0.0f;
        while (dur <= time)
        {
            dur += Time.deltaTime;
            transform.position = Vector3.Lerp(startPos, endPos, dur / time);
            yield return null;
        }
    }
    void Start()
    {
        distance = Vector2.Distance(transform.position, target.position);
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, (distance / 5f) * Time.deltaTime);
    }//我设置了1秒达到。


}
