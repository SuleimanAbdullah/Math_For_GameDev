using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FovThings : MonoBehaviour
{
    public Transform obj;

    private void OnDrawGizmos()
    {
        Camera cam = GetComponent<Camera>();
        Vector2 objRelPos = obj.transform.position - cam.transform.position;

        float opposite = objRelPos.y;
        float adjacent = objRelPos.x;

        float angRad = Mathf.Atan(opposite / adjacent);

        cam.fieldOfView = 2 * angRad * Mathf.Rad2Deg;
    }
}
