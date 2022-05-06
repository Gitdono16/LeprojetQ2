
using UnityEngine;

public class mouvement : MonoBehaviour
{
    public GameObject Player;
    public float timeOffset;
    public Vector3 posOffset;

    private Vector3 movement;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, Player.transform.position + posOffset, ref movement, timeOffset);
    }
}
