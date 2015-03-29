namespace MyLibrary
{
    using System;

    /// <summary>
    /// A sample API that is exposed by this library.
    /// </summary>
    public class MyClass
    {
        /// <summary>
        /// Reverse a string.
        /// </summary>
        /// <param name="source">A source string.</param>
        /// <returns>Reversed source string.</returns>
        public string ReverseString(string source)
        {
            char[] charArray = source.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
