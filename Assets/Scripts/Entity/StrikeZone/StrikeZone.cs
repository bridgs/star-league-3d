﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class StrikeZone : Entity
    {
        public new readonly EntityType type = EntityType.StrikeZone;

        [SerializeField] private GameObject gridSprite;
        [SerializeField] private GameObject targetSprite;

        private SpriteController gridSpriteController;
        private SpriteController targetSpriteController;

        public override void Created()
        {
            gridSpriteController = gridSprite.GetComponent<SpriteController>();
            targetSpriteController = targetSprite.GetComponent<SpriteController>();
        }

        public void SetTarget(int x, int y)
        {
            targetSpriteController.SetPixelPosition(26.0f * x, 26.0f * y);
        }
    }
}
