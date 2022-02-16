using System;
using System.Runtime.Serialization;

namespace Assignment5__RPG_Characters
{
    /// <summary>
    /// Throw this when the hero tries to equip a weapon that they can't equip
    /// </summary>
    [Serializable]
    public class InvalidWeaponException : Exception
    {
        public InvalidWeaponException()
        {
        }

        public InvalidWeaponException(string message) : base(message)
        {
        }

        public InvalidWeaponException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidWeaponException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    /// <summary>
    /// Throw this when the hero tries to equip a piece of armor that they can't equip
    /// </summary>
    [Serializable]
    public class InvalidArmorException : Exception
    {
        public InvalidArmorException()
        {
        }

        public InvalidArmorException(string message) : base(message)
        {
        }

        public InvalidArmorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidArmorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}