using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class LookingTrigger : MonoBehaviour
{
    public Transform objTf;

    [Range(0f,1f)]
    public float precisness =0.5f;
    private void OnDrawGizmos()
    {
        Vector2 center = transform.position;
        Vector2 playerPos = objTf.position;
        Vector2 playerLookDir = objTf.right;// x -axis

        Vector2 playerToTriggerDir = (center - playerPos).normalized;

        float lookness = Vector2.Dot(playerToTriggerDir, playerLookDir);

        bool isLooking = lookness >= precisness;

        Gizmos.color = isLooking ? Color.green : Color.red;
        Gizmos.DrawLine(playerPos, playerPos + playerToTriggerDir);


        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(playerPos, playerPos+ playerLookDir);
    }
}
