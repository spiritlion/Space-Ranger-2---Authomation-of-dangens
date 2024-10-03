using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarsControler : MonoBehaviour
{
    public GameObject HealthBar;
    public GameObject ArmorBar;

    public void Damage(float domage)
    {
      if (ArmorBar.transform.rotation.eulerAngles.z < 180)
      {
        ArmorBar.transform.Rotate(0, 0, domage);
      } else if (isLive()) {
        HealthBar.transform.Rotate(0, 0, domage);
      }
    }


    public bool isLive()
    {
      return HealthBar.transform.rotation.eulerAngles.z < 180;
    }

    public void Healthing(float HealthPlus, float ArmorPlus)
    {
      HealthBar.transform.Rotate(0, 0, HealthPlus);
      ArmorBar.transform.Rotate(0, 0, HealthPlus);
    }
}
