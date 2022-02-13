using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class SpaceTransform2 : MonoBehaviour
{

    public Transform localObjectTransform;
    public Vector2 worldSpacePoint;
    private void OnDrawGizmos()
    {
        Vector2 objPos = transform.position;
        Vector2 right = transform.right;
        Vector2 up = transform.up;

        Vector2 WorldToLocal(Vector2 worldPt)
        {
           Vector2 relPoint = worldPt - objPos;

            float x = Vector2.Dot(relPoint, right);
            float y = Vector2.Dot(relPoint, up);

            return new Vector2(x, y);
        }

        DrawBasisVector(objPos, right, up);
        DrawBasisVector(Vector2.zero, Vector2.right, Vector2.up);

        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(worldSpacePoint, 0.1f);

        localObjectTransform.localPosition = WorldToLocal(worldSpacePoint);
    }

    private void DrawBasisVector(Vector2 pos, Vector2 righ, Vector2 up)
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(pos, righ);
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(pos, up);
        Gizmos.color = Color.white;
    }
}
