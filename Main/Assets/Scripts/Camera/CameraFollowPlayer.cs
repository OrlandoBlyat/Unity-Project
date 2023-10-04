using UnityEngine;
public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.1f;
    private Vector3 velocity = Vector3.zero;
    //LateUpdate is used to not inferfere with player movement stuff.
    void FixedUpdate()
    {
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 0, -10));
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}

