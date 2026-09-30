using UnityEngine;

public class RollBehavior : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo,
     int layerIndex)
    {

        //makes the roll animation move the character forward
        animator.applyRootMotion = true;
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo,
     int layerIndex)
    {
        animator.applyRootMotion = false;
    }
}
