using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class VectorMath : MonoBehaviour
{

    public Transform aTfm;
    public Transform bTfm;
    [Range(0f, 4f)]
    public float offset = 1f;
    private void OnDrawGizmos()
    {
        Vector2 a = aTfm.position;
        Vector2 b = bTfm.position;
       
        //Gizmos.DrawLine(a, b);
        
        Vector2 aTob = b - a;
        Vector2 aTobdir = aTob.normalized;
        Gizmos.DrawLine(a, a+aTobdir);
        Vector2 vectorOffset = aTobdir* offset;
        //Vector2 midPoint = (a + b / 2);
        Gizmos.DrawSphere(a+vectorOffset, 0.05f);
        //Vector2 point = transform.position;
        //float length = point.magnitude;
        //
        //abDistance = Vector2.Distance(a, b);
        //Vector2.Distance(a, b);
        //(a - b).magnitude;
        //Vector2 dirToPo = point.normalized;
        // 

    }
}
       
        
    

