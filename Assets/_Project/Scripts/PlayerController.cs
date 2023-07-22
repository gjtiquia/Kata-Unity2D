using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kata.Core;

namespace Kata
{
    public class PlayerController : MonoBehaviour
    {
        private Player _player;

        private void Awake()
        {
            _player = new Player(transform.position);
            _player.OnPositionChangedEvent += OnPositionChanged;
        }

        private void OnPositionChanged(Vector2 newPosition)
        {
            transform.position = newPosition;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("Up Pressed!");
                _player.ExecuteCommand(new UpCommand(_player));
            }
        }
    }
}

