using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 30, speed = 5f;
    public int chessTeamNumber;

    private void Update()
    {
        transform.Translate(0, 0, Time.deltaTime * speed);
        Destroy(this.gameObject, 2);
    }
}
