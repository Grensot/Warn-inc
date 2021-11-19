using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force
{
    private float _forcestrength;
    private GameObject _cube;
    private Rigidbody2D _rb2d;
    public Force(float forcestrength, GameObject cube, Rigidbody2D rb2d)
    {
        _forcestrength = forcestrength;
        _cube = cube;
        _rb2d = rb2d;
    }
    public void Update()
    {
        if(Input.GetMouseButton(0))
        _rb2d.AddForce(_cube.transform.up * _forcestrength);
    }
}
