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
    protected static extern int midiOutShortMsg(int handle, int message);
    // Constructor
    public MidiPlayer() {
      // Create Thread
      int result = midiOutOpen(ref handle, 0, null, 0, 0);
    }
    //Interal API
    private int encodeMessage(byte command, byte note, byte velocity) {
      return (velocity << 16) + (note << 8) + command;
    }
    private void ShootNoise(Object stateInfo) {
      byte note = 0x3d;
      for (int i = 0; i < 255; i++) {
        for (int j = 0; j < 255; j++) {
          for (int k = 0; k < 255; k++) {
            //Console.WriteLine();
            midiOutShortMsg(handle, encodeMessage((byte)i, (byte)j, (byte)k));
            midiOutShortMsg(handle, encodeMessage(0x90, note, 0x7f));
            /* Here you should insert a delay so that you can hear the notes sounding */
            Thread.Sleep(100);
            /* Now let's turn off the note */
            midiOutShortMsg(handle, encodeMessage(0x80, note, 0x7f));
          }
        }
      }
      //midiOutShortMsg(handle, encodeMessage(0x00, 0x23, 0x89));
      //midiOutShortMsg(handle, encodeMessage(0x90, note, 0x7f));
      ///* Here you should insert a delay so that you can hear the notes sounding */
      //Thread.Sleep(1000);
      ///* Now let's turn off the note */
      //midiOutShortMsg(handle, encodeMessage(0x80, note, 0x7f));
    }
    // External API
    public void ShootNoise() {
      // Try Playing On A Seperate Thread
      ThreadPool.QueueUserWorkItem(ShootNoise, "ThreadPool");
    }
  }
}
