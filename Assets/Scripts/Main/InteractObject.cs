using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractObject : MonoBehaviour
{
    public bool interactable;
    [SerializeField] private float interactDuration = 1f;

    private SpriteRenderer spriteRenderer;
    [SerializeField] private float Duration = 1f;

    protected virtual void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        if (!interactable)
        {
            Duration -= Time.fixedDeltaTime;
            if (Duration < 0f)
            {
                InteractReset();
            }
        }       
    }

    public virtual void Interact()
    {
        interactable = false;
        spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
    }

    public virtual void InteractReset()
    {
        Duration = interactDuration;
        spriteRenderer.color = new Color(0.6f, 1f, 0.6f, 1f);
        interactable = true;
    }
}
