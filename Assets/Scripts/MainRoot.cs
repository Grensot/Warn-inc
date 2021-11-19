using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainRoot : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rb2d;
    [SerializeField]
    private float _forcestrength;
    [SerializeField]
    private GameObject _cube;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float[] _positions;
    [SerializeField]
    private Camera _cam;
    [SerializeField]
    private float _postoCreate;
    [SerializeField]
    private GameObject _level;
    [SerializeField]
    private GameObject _canvas;
    private Swaper _swaper;
    private Force _force;
    private Pause _pause;

    void Start()
    {
        _swaper = new Swaper(_cam, _speed, _positions);
        _swaper.Start();
        _force = new Force(_forcestrength, _cube, _rb2d);
        _pause = new Pause(_cam, _postoCreate, _level, _canvas);
    }

    void Update()
    {
        _swaper.Update();
        _force.Update();
        _pause.Update();
    }
}
