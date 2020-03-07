using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Defines the backdrop for a <see cref="Modal"/> component.
    /// </summary>
    public struct ModalBackdrop
    {

        /// <summary>
        /// Converts the boolean value to <see cref="ModalBackdrop"/>.
        /// </summary>
        /// <param name="b"></param>
        public static implicit operator ModalBackdrop(bool b)
        {
            return b.ToString().ToLower();
        }

        /// <summary>
        /// Converts the given string to <see cref="ModalBackdrop"/>.
        /// </summary>
        /// <param name="s"></param>
        public static implicit operator ModalBackdrop(string s)
        {
            switch (s?.ToLower())
            {
                case "true":
                case "false":
                case "static":
                    return new ModalBackdrop { Value = s?.ToLower() };

                default:
                    return new ModalBackdrop { Value = null };
            }
        }

        internal ModalBackdrop(bool? visible = null, bool? @static = null)
        {
            if (visible.HasValue)
            {
                this.Value = $"{visible}".ToLower();
            }
            else if (@static.GetValueOrDefault())
            {
                this.Value = "static";
            }
            else
            {
                this.Value = null;
            }
        }

        internal ModalBackdrop(string s)
        {
            this.Value = s;
        }

        /// <summary>
        /// The value of the backdrop.
        /// </summary>
        public string Value { get; private set; }

    }
}
