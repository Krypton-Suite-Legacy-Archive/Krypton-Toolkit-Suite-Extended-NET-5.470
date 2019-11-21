using System;
using System.Runtime.Serialization;

namespace KryptonSparkle.Classes
{
    /// <summary>
    /// A NetSparkle exception
    /// </summary>
    [Serializable]
    public class KryptonSparkleException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">exception message</param>
        public KryptonSparkleException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="info">serialization info</param>
        /// <param name="context">the context</param>
        protected KryptonSparkleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}