using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishingManager : MonoBehaviour
{
    private float fillAmount = 0;
    [SerializeField] private float fillSpeed = 1;
    [SerializeField] private float unfillSpeed = 5;
    [SerializeField] private Image outerFill, mediumFill, innerFill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (fillAmount <= 3)
            {
                fillAmount += fillSpeed * Time.deltaTime;
            }
        } else
        {
            fillAmount -= unfillSpeed * Time.deltaTime;
        }
        fillAmount = Mathf.Clamp(fillAmount, 0f, 3f);
        outerFill.fillAmount = Mathf.Clamp(fillAmount, 0f, 1f);
        mediumFill.fillAmount = Mathf.Clamp(fillAmount - 1f, 0f, 1f);
        innerFill.fillAmount = Mathf.Clamp(fillAmount - 2f, 0f, 1f);

    }
}
