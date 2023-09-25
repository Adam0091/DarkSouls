using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleActivated : MonoBehaviour
{
    public float distance = 2f;
    RaycastHit2D hit;
    [SerializeField] private PlayerController player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Physics2D.queriesStartInColliders = false;
            hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance);

            if(hit.collider != null)
            {
                player.Hp = player.MaxHp;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * transform.localScale.x * distance);
    }
}
