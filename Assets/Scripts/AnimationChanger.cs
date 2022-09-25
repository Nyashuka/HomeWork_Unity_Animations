using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationChanger : MonoBehaviour
{
    [SerializeField] private Button _boomButton;
    [SerializeField] private Button _birdButton;
    [SerializeField] private Button _penguinButton;

    [SerializeField] private Animator _animator;

    private void Start()
    {
        _boomButton.onClick.AddListener(() => ChangeAnimation("Boom"));
        _birdButton.onClick.AddListener(() => ChangeAnimation("Bird"));
        _penguinButton.onClick.AddListener(() => ChangeAnimation("Penguin"));
    }

    private void ChangeAnimation(string animation)
    {
        _animator.Play(animation);
    }
}
