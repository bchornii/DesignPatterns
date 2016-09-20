using System.Collections.Generic;
using System.Text;

namespace _02_Command_Order
{
    public class RemoteControll
    {             
        private readonly IDictionary<Slots, ICommand> _onCommands;
        private readonly IDictionary<Slots, ICommand> _offCommands;
        private readonly ICommand _noCommand;
        private ICommand _undoCommand;

        public RemoteControll()
        {
            _onCommands = new Dictionary<Slots, ICommand>();
            _offCommands = new Dictionary<Slots, ICommand>();
            _noCommand = new NoCommand();
            _undoCommand = _noCommand;
        }

        public void SetCommand(Slots slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand ?? _noCommand;
            _offCommands[slot] = offCommand ?? _noCommand;
        }

        private void SetUndoCommand(ICommand command)
        {
            _undoCommand = command;
        }

        public void OnButtonWasPushed(Slots slot)
        {
            if (_onCommands.ContainsKey(slot))
            {
                _onCommands[slot].Execute();
                SetUndoCommand(_onCommands[slot]);
            }
        }

        public void OffButtonWasPushed(Slots slot)
        {
            if (_offCommands.ContainsKey(slot))
            {
                _offCommands[slot].Execute();
                SetUndoCommand(_offCommands[slot]);
            }
        }

        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(new string('-', 30));
            sb.AppendLine("Remote control");
            sb.AppendLine(new string('-', 30));
            foreach (var key in _onCommands.Keys)
            {
                sb.AppendLine($"Slot [{(int)key}] : on = {_onCommands[key].GetType().Name}, off = {_offCommands[key].GetType().Name}");
            }
            return sb.ToString();
        }
    }
}
