using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZSemi4Patterns
{
    public class ChatServer
    {
        private  Queue<ICommand> _commandQueue = new Queue<ICommand>();

        public void AddCommand(ICommand command)
        {
            _commandQueue.Enqueue(command);
        }

        public void ProcessCommands()
        {
            while (_commandQueue.Count > 0)
            {
                var command = _commandQueue.Dequeue();
                command.Execute();
            }
        }
    }
}
