using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] private Transform target;
    private bool _activated = false;

    private void Update()
    {
        if (_activated)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
        }
            
    }
    private void Start()
    {
        activateBat();
    }
    public void activateBat()
    {
        _activated = true;
    }
    public void deactivateBat()
    {
        _activated = false;
    }
}
