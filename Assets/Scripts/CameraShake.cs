using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] float shakeDuration = .5f;
    [SerializeField] float shakeMagnitude = 0.3f;

    Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    public void Play()
    {
        StartCoroutine(Shake());
    }

    IEnumerator Shake()
    {
        float ellapsedTime = 0f;
        initialPosition = transform.position;

        while (ellapsedTime <= shakeDuration)
        {
            transform.position = initialPosition + (Vector3)Random.insideUnitCircle * shakeMagnitude;
            ellapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        transform.position = initialPosition;
    }

}
