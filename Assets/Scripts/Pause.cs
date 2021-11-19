using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause
{
    private Camera _cam;
    private float _postoCreate;
    private GameObject _level;
    private GameObject _canvas;
    public Pause(Camera cam, float postoCreate, GameObject level, GameObject canvas)
    {
        _cam = cam;
        _postoCreate = postoCreate;
        _level = level;
        _canvas = canvas;
    }
    public void Update()
    {
        if(_cam.transform.position.x >= _postoCreate)
        {
            _level.SetActive(true);
            _canvas.SetActive(false);
        }
        else
        {
            _level.SetActive(false);
            _canvas.SetActive(true);
        }
    }
}
