using UnityEngine;
using System.Collections;

public class FollowPath : MonoBehaviour
{
    public Vector3[] posPath;
    public float speed;
    private int step;

	void Start () 
    {
        step = 0;
        transform.position = posPath[step];
	}
	
	void FixedUpdate () 
    {
        if (Vector3.Distance(transform.position, posPath[step]) < 0.01f)
        {
            if (++step == posPath.Length)
            {
                this.enabled = false;
                Application.Quit();
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, posPath[step], speed * Time.deltaTime);
        }
	}
}
