namespace BCLExtensions
{
    /// <summary>
    /// Represents a semantically inclusive integer.
    /// </summary>
    public struct ExclusiveInteger
    {
        private readonly int _value;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExclusiveInteger"/> struct.
        /// </summary>
        /// <param name="value">The value.</param>
        public ExclusiveInteger(int value)
        {
            _value = value;
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public int Value
        {
            get { return _value; }
        }
    }
}