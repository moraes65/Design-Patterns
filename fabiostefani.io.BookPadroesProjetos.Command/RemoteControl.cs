using fabiostefani.io.BookPadroesProjetos.Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Command
{
    public class RemoteControl
    {
        const int SlotRemoteControl = 7;
        private ICommand[] onCommand;
        private ICommand[] offCommand;
        private ICommand undoCommand;
        public RemoteControl()
        {
            this.onCommand = new ICommand[SlotRemoteControl];
            this.offCommand = new ICommand[SlotRemoteControl];
            var noCommand = new NoCommand();
            for (int i = 0; i < SlotRemoteControl; i++)
            {
                onCommand[i] = noCommand;
                offCommand[i] = noCommand;
            }
            this.undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            this.onCommand[slot] = onCommand;
            this.offCommand[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            this.onCommand[slot].Execute();
            this.undoCommand = onCommand[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            this.offCommand[slot].Execute();
            this.undoCommand = offCommand[slot];
        }

        public void UndoButtonWasPushed()
        {
            this.undoCommand.Undo();
        }

        public string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("------------REMOTE CONTROL------------");
            for (int i = 0; i < SlotRemoteControl; i++)
            {
                builder.AppendLine($"[slot {i}] {onCommand[i].GetType().Name}           {offCommand[i].GetType().Name}");
            }
            builder.AppendLine($"[undo] {undoCommand.GetType().Name}");
            return builder.ToString();
        }
    }
}
