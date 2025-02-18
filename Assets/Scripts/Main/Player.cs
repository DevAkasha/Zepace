using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    public float Speed = 5f;
    private Rigidbody2D rigid;
    private Vector2 Direction;

    private InteractObject currentInteractable;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.F) && currentInteractable != null)
        {
            currentInteractable.Interact();
        }
    }

    private void Move()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        Direction = new Vector2(moveX, moveY).normalized;
        rigid.velocity = Direction * Speed;
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        InteractObject interactable = other.GetComponent<InteractObject>();
        if (interactable != null) currentInteractable = interactable;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (currentInteractable != null && other.gameObject == currentInteractable.gameObject)
        {
            currentInteractable = null;
        } 
    }
}
