using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulip.Framework
{
    public class Message
    {
        private string systemMessage;

        private string userMessage;

        /// <summary>
        /// Initializes the class with the specified system and user message.
        /// </summary>
        /// <param name="systemMessage">The system message generated at runtime.</param>
        /// <param name="userMessage">The user specified message.</param>
        public Message(string systemMessage, string userMessage)
        {
            this.systemMessage = systemMessage;
            this.userMessage = userMessage;
        }

        /// <summary>
        /// Gets the user specified message from the message instance.
        /// </summary>
        /// <returns>The user specified message from the message instance.</returns>
        public string GetUserMessage()
        {
            return this.userMessage;
        }

        /// <summary>
        /// Gets the string representation of the current instance.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var message = $"{this.systemMessage} {this.userMessage}";
            return !string.IsNullOrEmpty(message.Trim()) ? message : null;
        }
    }
}
