using System;
using C_Sglx_namespace;

namespace Bonsai.SpikeGLX
{
    /// <summary>
    /// Represents an exception raised during communication with SpikeGLX.
    /// </summary>
    /// <param name="hSglx">
    /// Pointer to the handle for the connection over which the exception occurred.
    /// </param>
    [Serializable]
    public class SpikeGLXException(IntPtr hSglx) : Exception(GetSpikeGLXErrorMessage(hSglx))
    {
        /// <summary>
        /// Gets a formatted error string from a SpikeGLX connection
        /// </summary>
        /// <param name="hSglx">
        /// Pointer to the handle for the connection over which the exception occurred.
        /// </param>
        /// <returns>Error message.</returns>
        private static string GetSpikeGLXErrorMessage(IntPtr hSglx)
        {
            return String.Format("SpikeGLX Error: {0}", C_Sglx.cs_sglx_getError(hSglx));
        }   
    }
}
