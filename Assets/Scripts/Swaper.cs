using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swaper
{
    private float _speed;
    private Camera _cam;
    private float[] _positions;
    public Swaper(Camera cam, float speed, float[] positions)
    {
        _cam = cam;
        _speed = speed;
        _positions = positions;
    }

    private Vector2 _startPos;
    private float _targetPos;
    public void Start()
    {
        _targetPos = _cam.transform.position.x;
    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
            _startPos = _cam.ScreenToWorldPoint(Input.mousePosition);
        else if(Input.GetMouseButton(0))
        {
            float pos = _cam.ScreenToWorldPoint(Input.mousePosition).x - _startPos.x;
            _targetPos = Mathf.Clamp(_cam.transform.position.x - pos, _positions[0], _positions[1]);
        }
        SwapCam(_targetPos);
        if (_cam.transform.position.x > _positions[0] / 2 && !Input.GetMouseButton(0))
        {
            SwapCam(_positions[1]);
        }
        else if(_cam.transform.position.x < _positions[1] / 2 && !Input.GetMouseButton(0))
        {
            SwapCam(_positions[0]);
        }
            
    }
    private void SwapCam(float postpSwap)
    {
        _cam.transform.position = new Vector3(Mathf.Lerp(_cam.transform.position.x, postpSwap, _speed * Time.deltaTime), _cam.transform.position.y, _cam.transform.position.z);
    }
}
