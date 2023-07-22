using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kata.Core;
using Kata.Core.Commands;

namespace Kata
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float _movementScale = 1;

        private Player _player;

        private void Awake()
        {
            _player = new Player(transform.position / _movementScale);
            _player.OnPositionChangedEvent += OnPositionChanged;
        }

        private void OnPositionChanged(Vector2 newPosition)
        {
            transform.position = newPosition * _movementScale;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                _player.ExecuteCommand(new UpCommand(_player));
            }

            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            {
                _player.ExecuteCommand(new DownCommand(_player));
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                _player.ExecuteCommand(new LeftCommand(_player));
            }

            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                _player.ExecuteCommand(new RightCommand(_player));
            }

            // U to undo, because will have conflict with Ctrl-Z and Ctrl-U
            if (Input.GetKeyDown(KeyCode.U))
            {
                _player.UndoCommand();
            }
        }
    }
}

