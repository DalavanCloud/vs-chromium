using System.Runtime.InteropServices;

namespace VsChromium.Core.Win32.Debugging {
  [StructLayout(LayoutKind.Sequential)]
  public struct EXIT_PROCESS_DEBUG_INFO {
    public uint dwExitCode;
  }
}