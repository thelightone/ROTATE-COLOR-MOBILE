using UnityEngine;

public class Change : MonoBehaviour
{
    [SerializeField]
    private Material _material;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponentInParent<Animator>();
    }

    private void OnMouseDown()
    {
        _material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        _animator.SetFloat("Blend", Random.Range(0.0f, 1.0f));
    }
}
