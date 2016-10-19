using UnityEngine;
using System.Collections;

public class ParticleSystemMover : MonoBehaviour {

    public float posX, negX, time;
    float newLoc;
    Vector3 pos;

    void Start()
    {
        pos = this.transform.localPosition;
        StartCoroutine(ChangePos());
    }

    IEnumerator ChangePos()
    {
        Debug.Log(this.transform.localPosition.x);
        yield return new WaitForSeconds(time);
        newLoc = Random.Range(negX, posX);
        pos.x = 0;
        pos.x = pos.x + newLoc;
        transform.localPosition = pos;
        //this.transform.position = new Vector3(this.transform.localPosition.x + newLoc, this.GetComponentInParent<Transform>().transform.position.y, this.GetComponentInParent<Transform>().transform.position.z);
        StartCoroutine(ChangePos());
    }
}
