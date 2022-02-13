using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR 
using UnityEditor;
#endif
public class RadialTrigger : MonoBehaviour
{
    public Transform objTf;

    [Range(0f,4f)]
    public float radius=1f;

    #if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Vector2 objePos = transform.position;
        Vector2 origin = objTf.position;

        float dist = Vector2.Distance(objePos , origin);


        bool isInside = dist < radius;

        Handles.color = isInside ? Color.green : Color.red;
        Handles.DrawWireDisc(objePos, new Vector3(0,0,1), radius);

    }
#endif
}
