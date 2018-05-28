using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehavior : MonoBehaviour
{

        public PowerUpBase AmmoPowerUp;
        public PowerUpBase HealthPowerUp;

        private void OnMouseDown()
        {
                Debug.Log(AmmoPowerUp.PowerLevel);
        }



}
