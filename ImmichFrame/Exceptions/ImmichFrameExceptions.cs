﻿using System;
using System.Runtime.Serialization;

namespace ImmichFrame.Exceptions
{
    public class ImmichFrameException : Exception
    {
        public ImmichFrameException() { }
        public ImmichFrameException(string? message) : base(message) { }
        public ImmichFrameException(string? message, Exception? innerException) : base(message, innerException) { }
        protected ImmichFrameException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }

    public class AssetNotFoundException : ImmichFrameException
    {
        public AssetNotFoundException() : base() { }
        public AssetNotFoundException(string message) : base(message) { }
        public AssetNotFoundException(string message, Exception innerException) : base(message, innerException) { }
        public AssetNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }

    public class AlbumNotFoundException : ImmichFrameException
    {
        public AlbumNotFoundException() : base() { }
        public AlbumNotFoundException(string message) : base(message) { }
        public AlbumNotFoundException(string message, Exception innerException) : base(message, innerException) { }
        public AlbumNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }

    public class MemoryNotFoundException : ImmichFrameException
    {
        public MemoryNotFoundException() : base() { }
        public MemoryNotFoundException(string message) : base(message) { }
        public MemoryNotFoundException(string message, Exception innerException) : base(message, innerException) { }
        public MemoryNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
