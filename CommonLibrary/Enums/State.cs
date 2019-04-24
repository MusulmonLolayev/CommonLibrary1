using System.ComponentModel;
using CommonLibrary.Attributes;

namespace CommonLibrary.Enums
{
    public enum State
    {
        /// <summary>
        ///     objectning faolligini bildiradi
        /// </summary>
        [Description("Active")]
        Active = 1,

        /// <summary>
        ///     objectning faolmasligini bildiradi
        /// </summary>
        [Description("Closed")]
        Closed = 2,
    }
}
