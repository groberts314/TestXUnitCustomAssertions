using System;

namespace Xunit
{
    /// <summary>
    /// Partial class extending `Xunit.Assert`
    /// </summary>
    /// <remarks>
    /// You can add any additional custom `public static void` methods on `Assert` class as desired and then use them in unit test projects referencing this project.
    /// </remarks>
    public partial class Assert
    {
        /// <summary>
        /// Assert that the actual Date/Time value is essentially the same as the expected value, differing only by fractions of a second.
        /// </summary>
        /// <remarks>
        /// Useful for asserting that two Date/Time values that are essentially the same in cases
        /// where they may differ very slightly in ticks or milliseconds just due to round-tripping
        /// from database access, JSON serialization, etc.
        /// </remarks>
        /// <param name="expected">Expected Date/Time value</param>
        /// <param name="actual">Actual Date/Time value</param>
        /// <param name="assertionFailureMessage">
        /// Custom message to be displayed if the assertion fails. 
        /// Optional; there is a default message showing the expected
        /// and actual Date/Time values that is displayed if this
        /// argument is omitted.
        /// </param>
        public static void DateTimeMatchesWithinOneSecond(
            DateTime expected,
            DateTime actual,
            string assertionFailureMessage = null)
        {
            True(
                expected - actual < TimeSpan.FromSeconds(1),
                assertionFailureMessage ??
                    $"It was expected that the expected value \'{expected.ToString("G")}\' and the actual value \'{actual.ToString("G")}\' differed from one another by less than one second");
        }
    }
}
