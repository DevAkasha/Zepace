using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractObject : MonoBehaviour
{
    //interactable상태를 스프라이트 랜더러로 보여주기 위한 필드
    bool isInteractable;
    SpriteRenderer spriteRenderer;
    [SerializeField] float interactDuration = 1f;
    [SerializeField] float currentDuration = 1f;

    protected virtual void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if (!isInteractable)
        {
            currentDuration -= Time.fixedDeltaTime;
            if (currentDuration < 0f)
            {
                InteractReset();
            }
        }
    }

    public virtual void Interact()
    {
        isInteractable = false;
        spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
    }

    public virtual void InteractReset()
    {
        currentDuration = interactDuration;
        spriteRenderer.color = new Color(0.6f, 1f, 0.6f, 1f);
        isInteractable = true;
    }
}
