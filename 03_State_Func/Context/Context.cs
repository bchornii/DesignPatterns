using System.Collections.Generic;
using _03_State_Func.State;

namespace _03_State_Func.Context
{
    public class Context
    {
        private IState State { get; set; }

        private readonly IDictionary<string, IState> _statesMap;

        public Context()
        {
            _statesMap = GetStatesMap();
            State = _statesMap[StateConstants.ContretteState1];
        }

        public void BussinessLogic()
        {
            State = GetNextState();
            State.Operation1();
            State.Operation2();
        }

        private IState GetNextState()
        {
            return State.Name == StateConstants.ContretteState1
                ? _statesMap[StateConstants.ContretteState2]
                : _statesMap[StateConstants.ContretteState1];
        }

        private static IDictionary<string, IState> GetStatesMap()
        {
            return new Dictionary<string, IState>
            {
                [StateConstants.ContretteState1] = new ContretteState1(),
                [StateConstants.ContretteState2] = new ConcretteState2()
            };
        }
    }
}