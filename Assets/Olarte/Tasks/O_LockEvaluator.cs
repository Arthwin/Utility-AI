using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;

namespace BehaviorDesigner.Runtime.Samples.UtilityTheory
{
    [TaskCategory("UtilityTheory")]
    public class O_LockEvaluator : Action
    {
        [Tasks.Tooltip("The Evaluator decorator to lock")]
        public O_Evaluator evaluator;

        public override TaskStatus OnUpdate()
        {
            // Lock and then return success - this task doesn't keep track of the actual utility value.
            evaluator.Lock();
            return TaskStatus.Success;
        }
    }
}