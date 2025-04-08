using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform settingsViewPoint;
    public Transform mainCameraPoint;
    public float moveSpeed = 3f;

    private bool moveToSettings = false;
    private bool moveToMain = false;

    void Update()
    {
        if (moveToSettings)
        {
            transform.position = Vector3.MoveTowards(transform.position, settingsViewPoint.position, moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, settingsViewPoint.rotation, moveSpeed * 30f * Time.deltaTime);

        }
        else if(moveToMain)
        {
            transform.position = Vector3.MoveTowards(transform.position, mainCameraPoint.position, moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, mainCameraPoint.rotation, moveSpeed * 30f * Time.deltaTime);
        }
    }

    public void GoToSettings()
    {
        moveToSettings = true;
        moveToMain = false;
    }

    public void GoToMain()
    {
        moveToMain = true;
        moveToSettings = false;
    }


}
