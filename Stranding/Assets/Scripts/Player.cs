﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stranding
{
    class Player : MonoBehaviour
    {
        public int MaxSpeed { get; set; } = 1;
        public int MapPosition { get; set; } = 0;
        private int _health;
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _health = value;
                }
                else
                {
                    Debug.LogError("Health must be a value between 0 and 100");
                }
            }
        }

        public readonly string Name = "Meme man";
    }
}
