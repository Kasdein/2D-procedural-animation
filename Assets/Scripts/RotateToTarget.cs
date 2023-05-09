using UnityEngine;

public class RotateToTarget : MonoBehaviour
{
    //dictates the speed of rotation towards target
    public float rotationSpeed;
    private Vector2 direction;
    public float moveSpeed;
    public Transform target;

    // Update is called once per frame
    private void Update()
    {
        //allows us to use the camera to figure out the direction between current position and the mouse position
        direction = target.position - transform.position;
       
        //calculates the angle between the two positions
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        
        //creates a rotation from that angle value
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        
        //makes the rotation gradual instead of instant
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);

        //tracks mouse position
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //moves object towards mouse position
        transform.position = Vector2.MoveTowards(transform.position, cursorPos, moveSpeed * Time.deltaTime);

    }
}