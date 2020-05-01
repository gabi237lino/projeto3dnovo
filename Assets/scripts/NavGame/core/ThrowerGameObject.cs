﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NavGame.Core 
{
    public class ThrowerGameObject : AttackGameObject 
    {
        public GameObject projectilePrefab;

        protected override void Attack(DamageableGameObject target)
        {
            GameObject Projectile = Instantiate (projectilePrefab, castTransform.position, Quaternion.identity) as GameObject;
            ProjectileController controller = Projectile.GetComponent<ProjectileController> ();
            controller.Init (target, ofenseStats.damage);
            controller.onAttackStrike += onAttackStrike;
        }

        void OnAttackStrike(Vector3 strikePoint)
        {
            if (onAttackStrike != null)
            {
                onAttackStrike(strikePoint);
            }
        }
    }
}