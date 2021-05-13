using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenAppear : MonoBehaviour
{
    public GameObject customPanel;
    public GameObject customText1;
    public GameObject customText2;

    void OnTriggerEnter(Collider other)
    {
            customPanel.SetActive(true);
            customText1.SetActive(true);
            customText2.SetActive(true);
    }
}
