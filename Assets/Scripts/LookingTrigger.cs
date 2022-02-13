using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class LookingTrigger : MonoBehaviour
{
    public Transform objTf;

    [Range(0f,90f)]
    public float anglThresholdDeg = 30f;
    private void OnDrawGizmos()
    {
        Vector2 center = transform.position;
        Vector2 playerPos = objTf.position;
        Vector2 playerLookDir = objTf.right;// x -axis

        Vector2 playerToTriggerDir = (center - playerPos).normalized;

        float dot = Vector2.Dot(playerToTriggerDir, playerLookDir);
        dot = Mathf.Clamp(dot, -1, 1); //to make sure we stay within -1 and 1

        float angRad = Mathf.Acos(dot); //find angle between two vector player and PlayerlookDir

        float anglThreshRad = anglThresholdDeg * Mathf.Deg2Rad; //change degree to radian

        bool isLooking = angRad <= anglThreshRad;

        Gizmos.color = isLooking ? Color.green : Color.red;
        Gizmos.DrawLine(playerPos, playerPos + playerToTriggerDir);


        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(playerPos, playerPos+ playerLookDir);
    }
}
