using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField, Range(0, 1)]
    private float sensitivity = 1f;

    public GameObject player;

    private float xAxis;
    private float yAxis;

    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //Lock the mouse cursor to the center
    }

    // Update is called once per frame
    private void Update()
    {
        /*Get inputs*/
        xAxis = Input.GetAxisRaw("Mouse X") * 100f * sensitivity * Time.deltaTime;
        yAxis -= Input.GetAxisRaw("Mouse Y") * 100f * sensitivity * Time.deltaTime; //yAxis Starts from 0 value and is subtracted by mouse's Y coordinate value 

        yAxis = Mathf.Clamp(yAxis, -85f, 50f); //We clamp the yAxis value to avoid doing a 360 vertical view 

        transform.localRotation = Quaternion.Euler(yAxis, 0f, 0f); //Rotate the parent object (camera) on an angle based on yAxis Value
        player.transform.Rotate(Vector3.up * xAxis); //Rotate the player left and right when mouse's X coordinate Value
    }
}
