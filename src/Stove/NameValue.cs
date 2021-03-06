﻿using System;

using JetBrains.Annotations;

namespace Stove
{
    /// <summary>
    ///     Can be used to store Name/Value (or Key/Value) pairs.
    /// </summary>
    [Serializable]
    public class NameValue : NameValue<string>
    {
        /// <summary>
        ///     Creates a new <see cref="NameValue" />.
        /// </summary>
        public NameValue()
        {
        }

        /// <summary>
        ///     Creates a new <see cref="NameValue" />.
        /// </summary>
        public NameValue([NotNull] string name, [NotNull] string value)
        {
            Name = name;
            Value = value;
        }
    }

    /// <summary>
    ///     Can be used to store Name/Value (or Key/Value) pairs.
    /// </summary>
    [Serializable]
    public class NameValue<T>
    {
        /// <summary>
        ///     Creates a new <see cref="NameValue" />.
        /// </summary>
        public NameValue()
        {
        }

        /// <summary>
        ///     Creates a new <see cref="NameValue" />.
        /// </summary>
        public NameValue([NotNull] string name, [NotNull] T value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        ///     Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Value.
        /// </summary>
        public T Value { get; set; }
    }
}
