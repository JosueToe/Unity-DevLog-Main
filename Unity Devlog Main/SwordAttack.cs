using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{

    public enum AttackDirection
    {
        left, right
    }

    public AttackDirection attackdirection;

    Vector2 RightAttackOffset;
    Collider2D swordCollider;

    // Start is called before the first frame update
    void Start()
    {
        swordCollider = GetComponent<Collider2D>();
        RightAttackOffset = transform.position;
    }

    public void Attack()
    {
        switch (attackdirection)
        {
            case AttackDirection.left:
                AttackLeft();
                break;
            case AttackDirection.right:
                AttackRight();
                break;
        }
    }


    private void AttackRight()
    {
        swordCollider.enabled = true;
        transform.position = RightAttackOffset;
    }

    private void AttackLeft()
    {
        swordCollider.enabled = true;
        transform.position = new Vector3(RightAttackOffset.x * -1, RightAttackOffset.y);
    }

    public void StopAttack()
    {
        swordCollider.enabled = false;
    }

}