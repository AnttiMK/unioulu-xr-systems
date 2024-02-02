using UnityEngine;
using UnityEngine.InputSystem;

public class CameraOffset : MonoBehaviour
{
    public InputActionReference action;
    public Vector3 offset = new(-15, 5, -20);

    private bool _isFar;

    public void Start()
    {
        action.action.Enable();
        action.action.performed += _ =>
        {
            if (!_isFar)
            {
                transform.position += offset;
                _isFar = true;
            }
            else
            {
                transform.position -= offset;
                _isFar = false;
            }
        };
    }
    
}