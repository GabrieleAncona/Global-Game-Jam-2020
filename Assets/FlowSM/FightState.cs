﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightState : StateBehaviourBase
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        SoundManager.PlaySound(SoundManager.Sound.gameplay);
    }
}

