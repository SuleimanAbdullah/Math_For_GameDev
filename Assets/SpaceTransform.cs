using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class SpaceTransform : MonoBehaviour
{
    public Vector2 localSpacePoint;
    private void OnDrawGizmos()
    {
        Vector2 objPos = transform.position;
        Vector2 right = transform.right;
        Vector2 up = transform.up;

        Vector2 LocalToWorld(Vector2 localPt)
        {
            Vector2 worldOffsets = localPt.x * right + localPt.y * up;
            return (Vector2)transform.position + worldOffsets;
        }

        Vector2 worldSpacePoint = LocalToWorld(localSpacePoint);

        DrawBasisVector(objPos, right, up);
        DrawBasisVector(Vector2.zero, Vector2.right, Vector2.up);

        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(worldSpacePoint, 0.1f);
    }

    private void DrawBasisVector(Vector2 pos,Vector2 righ,Vector2 up)
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(pos, righ);
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(pos, up);
        Gizmos.color = Color.white;
    }
}
