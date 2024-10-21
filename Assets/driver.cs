using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour
{
    public float Speed = 10f;
    public float turnSpeed = 100.0f;

    public TargetEnum nextTarget;

    private Vector3 targetPosition;
    private TargetEnum[] targets = { TargetEnum.TopLeft, TargetEnum.TopRight, TargetEnum.BottomLeft, TargetEnum.BottomRight };
    private int currentTargetIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        SetTargetPosition();
    }

    // Update is called once per frame
    void Update()
    {

        MoveToTarget();
    }
    public enum TargetEnum
    {
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight
    }
    void SetTargetPosition()
    {
        switch (nextTarget)
        {
            case TargetEnum.TopLeft:
                targetPosition = new Vector3(4.5f, -21.28f, 28.18f);
                break;
            case TargetEnum.TopRight:
                targetPosition = new Vector3(-52.11f, -21.3f, 30.09f);
                break;
            case TargetEnum.BottomLeft:
                targetPosition = new Vector3(-52.1f, -21.3f, -26.2f);
                break;
            case TargetEnum.BottomRight:
                targetPosition = new Vector3(4, -21.3f, -26.2f);
                break;
        }
    }
    void MoveToTarget()
    {
        Vector3 direction = (targetPosition - transform.position).normalized;
        Quaternion targetRotation = Quaternion.LookRotation(direction);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);

        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            currentTargetIndex = (currentTargetIndex + 1) % targets.Length;
            nextTarget = targets[currentTargetIndex];
            SetTargetPosition();
        }
    }
}

