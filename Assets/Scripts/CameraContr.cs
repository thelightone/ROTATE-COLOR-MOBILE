using UnityEngine;

public class CameraContr : MonoBehaviour
{
    private Vector3 _firstpoint;
    private Vector3 _secondpoint;

    private float _xAngle;
    private float _yAngle;
    private float _xAngTemp;
    private float _yAngTemp;

    private bool isUpdatePosition = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnStartTouch();
            isUpdatePosition = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isUpdatePosition = false;
        }

        if (isUpdatePosition)
        {
            UpdatePosition();
        }
    }

    private void OnStartTouch()
    {
        _firstpoint = Input.mousePosition;

        _xAngTemp = _xAngle;
        _yAngTemp = _yAngle;
    }

    public void UpdatePosition()
    {
        _secondpoint = Input.mousePosition;

        _xAngle = _xAngTemp + (_secondpoint.x - _firstpoint.x) * 180.0f / Screen.width;
        _yAngle = _yAngTemp - (_secondpoint.y - _firstpoint.y) * 90.0f / Screen.height;

        transform.rotation = Quaternion.Euler(_yAngle, _xAngle, 0.0f);
    }
}

