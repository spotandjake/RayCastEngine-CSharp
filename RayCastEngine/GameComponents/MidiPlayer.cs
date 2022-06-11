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
      // Play shoot on channel 16
      this.programChange(15, 127);
      this.noteOn(15, 50, 100);
    }
    // FrameWork
    public void changeController(int channel, byte controllerType, byte value) {
      // Send Properperty Change, need to make a binary package of command, channel, instrument
      midiOutShortMsg(handle, (uint)((0xb0 | channel) | (controllerType << 8) | (value << 16)));
    }
    public void programChange(int channel, byte sound) {
      // Send Instrument Change, need to make a binary package of command, channel, instrument
      midiOutShortMsg(handle, (uint)((0xc0 | channel) | (sound << 8)));
    }
    public void pitchBend(int channel, int value) {
       // Send Pitch Bend, need to make a binary package of command, channel, instrument, low value bits, high value bits
      midiOutShortMsg(handle, (uint)((0xe0 | channel) | ((value >> 16) << 8) | ((value >> 8) << 16)));
    }
    public void noteOn(int channel, byte noteNumber, byte velocity) {
      // Send Note On, need to make a binary package of command, channel, note, velocity
      midiOutShortMsg(handle, (uint)((0x90 | channel) | (noteNumber << 8) | (velocity << 16)));
    }
    public void noteOff(int channel, byte noteNumber) {
      // Send Note On, need to make a binary package of command, channel, note, velocity
      midiOutShortMsg(handle, (uint)((0x80 | channel) | (noteNumber << 8)));
    }
    // Songs
    //Internal Music Manager
    private void handleMusic(Object stateInfo) {
      // TODO: Maybe Different Songs
      Songs.Doom(this);
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
