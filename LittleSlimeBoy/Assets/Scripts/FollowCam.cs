using UnityEngine;

public class FollowCam : MonoBehaviour
{

    public GameObject targetObject;
    public Vector3 cameraOffset;
    public Vector3 targetedPosition;
    public float smoothTime = 1F;

    private Vector3 velocity = Vector3.zero;
    

    void LateUpdate()
    {
        //The camera follows the character.
        transform.position = targetObject.transform.position + cameraOffset;
        
        //The camera follows the character softly. 
        transform.position = Vector3.SmoothDamp(transform.position, targetedPosition, ref velocity, smoothTime);
    }
}
