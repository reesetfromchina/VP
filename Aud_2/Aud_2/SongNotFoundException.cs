﻿using System.Runtime.Serialization;

namespace Aud_2
{
    [Serializable]
    internal class SongNotFoundException : Exception
    {
        public SongNotFoundException()
        {
        }

        public SongNotFoundException(string? message) : base(message)
        {
        }

        public SongNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SongNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}