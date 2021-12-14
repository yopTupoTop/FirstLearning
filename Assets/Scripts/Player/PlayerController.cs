using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _player;
    private bool _isMovingRight;
    [SerializeField] private float _speed;

    private void Start()
    {
        _player.GetComponent<Rigidbody>();
    }

    private void ChangeDirection()
    {
        _isMovingRight = !_isMovingRight;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeDirection();
        }

        if (_isMovingRight)
        {
            _player.velocity = new Vector3(_speed, 0, 0);
        }
        else
        {
            _player.velocity = new Vector3(0, 0, _speed);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
            Debug.Log("It's obstacle");
    }
}
