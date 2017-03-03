using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;

namespace BehaviorDesigner.Runtime.Samples.UtilityTheory
{
    [TaskCategory("UtilityTheory")]
    public class O_StartCooldown : Action
    {
        [Tasks.Tooltip("The Evaluator decorator to start the cooldown")]
        public O_Evaluator evaluator;

        public override TaskStatus OnUpdate()
        {
            // Start the cooldown and then return success - this task doesn't keep track of the actual utility value.
            evaluator.StartCooldown();
            return TaskStatus.Success;
        }
    }
}