﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stranding
{
    ///<summary>
    /// used to store user data
    /// </summary>
    
    public class Data_storage : MonoBehaviour
    {
        
        private int _health;
        public int Health
        {
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _health = value;
                }
            }

            get
            {
                return _health;
            }
        }

        private int _loop;
        public int Loop
        {
            set
            {
                if (value >= 0)
                {
                    _loop = value;
                }
            }

            get
            {
                return _loop;
            }
        }

        private int _step;
        public int Step
        {
            set
            {
                if (value >= 0)
                {
                    _step = value;
                }
            }

            get
            {
                return _step;
            }
        }

        public void Start()
        {
            Health = 100;
            Loop = 0;
            Step = 0;
        }
    }
}

