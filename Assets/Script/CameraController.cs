using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject arModel; // Đối tượng mô hình AR của bạn

    private bool isTracking = false;

    void Update()
    {
        if (isTracking)
        {
            // Kiểm tra xem đích có trong tầm nhìn không
            if (!IsTargetVisible())
            {
                arModel.SetActive(false);
                isTracking = false;
            }
        }
        else
        {
            // Kiểm tra xem đích có trong tầm nhìn không
            if (IsTargetVisible())
            {
                arModel.SetActive(true);
                isTracking = true;
            }
        }
    }

    private bool IsTargetVisible()
    {
        // Kiểm tra logic để xác định xem đích có trong tầm nhìn không
        // Trong trường hợp sử dụng Vuforia, bạn có thể sử dụng Vuforia API để kiểm tra đích hiện tại
        // Ví dụ: return trackableBehaviour.CurrentStatus == TrackableBehaviour.Status.TRACKED;
        
        // Trong ví dụ này, ta giả định đích hiện tại được nhìn thấy khi tồn tại một đối tượng được nhận diện trong tầm nhìn
        // Bạn có thể thay đổi logic này phù hợp với nhu cầu của mình
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider.gameObject.CompareTag("Target"))
            {
                return true;
            }
        }
        return false;
    }
}
