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
      //byte[] data = new byte[4];
      //data[0] = 0xC0;//change instrument, channel 1
      //data[1] = 127;//gunshot
      //uint msg = BitConverter.ToUInt32(data, 0);
      //midiOutShortMsg(handle, msg);
      //data[0] = 0x90;//note on, channel 0
      //data[1] = 50;//pitch
      //data[2] = 100;//velocity
      //msg = BitConverter.ToUInt32(data, 0);
      //midiOutShortMsg(handle, msg);
      // Play shoot on channel 16
      this.noteType(15, 127);
      this.playNote(15, 50, 100);
    }
    // FrameWork
    public void changeController(int channel, byte controllerType, byte value) {
      // Send Properperty Change, need to make a binary package of command, channel, instrument
      midiOutShortMsg(handle, (uint)((0xb0 | channel) | (controllerType << 8) | (value << 16)));
    }
    public void noteType(int channel, byte sound) {
      // Send Instrument Change, need to make a binary package of command, channel, instrument
      midiOutShortMsg(handle, (uint)((0xc0 | channel) | (sound << 8)));
    }
    public void pitchBend(int channel, int value) {
      byte[] data = new byte[4];
      data[0] = (byte)(0xe0 | channel);//note on
      data[1] = (byte)(value >> 16);
      data[2] = (byte)(value >> 8);
      midiOutShortMsg(handle, BitConverter.ToUInt32(data, 0));
    }
    public void playNote(int channel, byte noteNumber, byte velocity) {
      // Send Note On, need to make a binary package of command, channel, note, velocity
      midiOutShortMsg(handle, (uint)((0x90 | channel) | (noteNumber << 8) | (velocity << 16)));
    }
    // Songs
    //Internal Music Manager
    private void handleMusic(Object stateInfo) {
      // TODO: Maybe Different Songs
      //Songs.Doom(this);
    }
    // External API
    public void ShootNoise() {
      // Try Playing On A Seperate Thread
      ThreadPool.QueueUserWorkItem(ShootNoise, "ThreadPool");
    }
    // Music Manager
    public void ManageMusic() {
      ThreadPool.QueueUserWorkItem(handleMusic, "ThreadPool");
    }
  }
}
