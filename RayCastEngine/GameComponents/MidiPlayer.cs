using System;
using System.Threading;
using System.Runtime.InteropServices;

namespace RayCastEngine.GameComponents {
  // Player
  class MidiPlayer {
    // Internal Bridge
    private int handle = 0;
    // Handle midi messages sent from system.
    protected delegate void MidiCallback(int handle, int msg, int instance, int param1, int param2);
    [DllImport("winmm.dll")]
    private static extern int midiOutOpen(ref int handle, int deviceID, MidiCallback proc, int instance, int flags);
    [DllImport("winmm.dll")]
    protected static extern int midiOutShortMsg(int handle, uint message);
    // Constructor
    public MidiPlayer() {
      // Create Thread
      int result = midiOutOpen(ref handle, 0, null, 0, 0);
    }
    private void ShootNoise(Object stateInfo) {
      //hmidi is an IntPtr obtained via midiOutOpen or other means.
      byte[] data = new byte[4];
      data[0] = 0xC0;//change instrument, channel 1
      data[1] = 127;//gunshot
      uint msg = BitConverter.ToUInt32(data, 0);
      midiOutShortMsg(handle, msg);
      data[0] = 0x90;//note on, channel 0
      data[1] = 50;//pitch
      data[2] = 100;//velocity
      msg = BitConverter.ToUInt32(data, 0);
      midiOutShortMsg(handle, msg);
    }
    // External API
    public void ShootNoise() {
      // Try Playing On A Seperate Thread
      ThreadPool.QueueUserWorkItem(ShootNoise, "ThreadPool");
    }
  }
}
