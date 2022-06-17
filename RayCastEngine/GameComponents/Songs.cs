using System.Threading;

namespace RayCastEngine.GameComponents {
  static class Songs {
    #region Doom Song
    public static void Doom(MidiPlayer player) {
      player.programChange(0, 30); // Change The Instrument On Channel 0, To Instrument At Index 30
      player.changeController(0, 7, 100); // Change The Controller Properties on Channel 7, set the property to 100
      player.changeController(0, 10, 24); // Change The Controller Properties on Channel 10, set the property to 24
      player.changeController(0, 7, 100); // Change The Controller Properties on Channel 7, set the property to 100
      player.changeController(0, 10, 24); // Change The Controller Properties on Channel 10, set the property to 24
      player.programChange(1, 29); // Change The Instrument On Channel 1, To Instrument At Index 29
      player.changeController(1, 7, 100); // Change The Controller Properties on Channel 7, set the property to 100
      player.changeController(1, 10, 104); // Change The Controller Properties on Channel 10, set the property to 104
      player.changeController(1, 7, 100); // Change The Controller Properties on Channel 7, set the property to 100
      player.changeController(1, 10, 104); // Change The Controller Properties on Channel 10, set the property to 104
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      player.programChange(2, 34); // Change The Instrument On Channel 2, To Instrument At Index 34
      player.changeController(2, 7, 100); // Change The Controller Properties on Channel 7, set the property to 100
      player.changeController(2, 10, 64); // Change The Controller Properties on Channel 10, set the property to 64
      player.noteOn(2, 40, 120); // Play The Note 40, at velocity 120 on channel 2
      player.changeController(9, 7, 100); // Change The Controller Properties on Channel 7, set the property to 100
      player.changeController(9, 10, 64); // Change The Controller Properties on Channel 10, set the property to 64
      player.programChange(9, 0); // Change The Instrument On Channel 9, To Instrument At Index 0
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 40, 115); // Play The Note 40, at velocity 115 on channel 9
      player.noteOn(9, 41, 120); // Play The Note 41, at velocity 120 on channel 9
      player.changeController(9, 7, 100); // Change The Controller Properties on Channel 7, set the property to 100
      player.changeController(9, 10, 64); // Change The Controller Properties on Channel 10, set the property to 64
      player.changeController(9, 7, 100); // Change The Controller Properties on Channel 7, set the property to 100
      player.changeController(9, 10, 64); // Change The Controller Properties on Channel 10, set the property to 64
      player.changeController(9, 7, 100); // Change The Controller Properties on Channel 7, set the property to 100
      player.changeController(9, 10, 64); // Change The Controller Properties on Channel 10, set the property to 64
      player.changeController(9, 7, 100); // Change The Controller Properties on Channel 7, set the property to 100
      player.changeController(9, 10, 64); // Change The Controller Properties on Channel 10, set the property to 64
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(116); // Wait For The Next Note
      player.noteOn(1, 52, 114); // Play The Note 52, at velocity 114 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(112); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(1, 50, 111); // Play The Note 50, at velocity 111 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(1, 40, 104); // Play The Note 40, at velocity 104 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(1, 48, 116); // Play The Note 48, at velocity 116 on channel 1
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(1, 46, 110); // Play The Note 46, at velocity 110 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(116); // Wait For The Next Note
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(137); // Wait For The Next Note
      player.noteOn(1, 47, 110); // Play The Note 47, at velocity 110 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 48, 117); // Play The Note 48, at velocity 117 on channel 1
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(2, 40, 127); // Play The Note 40, at velocity 127 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 41, 123); // Play The Note 41, at velocity 123 on channel 9
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(1, 52, 114); // Play The Note 52, at velocity 114 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(87); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(87); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(1, 50, 106); // Play The Note 50, at velocity 106 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(112); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(87); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      player.noteOn(1, 48, 117); // Play The Note 48, at velocity 117 on channel 1
      Thread.Sleep(112); // Wait For The Next Note
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(1, 46, 114); // Play The Note 46, at velocity 114 on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.pitchBend(1, -256); // Change The Pitch Offset On Channel 1 To -256
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 256); // Change The Pitch Offset On Channel 1 To 256
      Thread.Sleep(70); // Wait For The Next Note
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 640); // Change The Pitch Offset On Channel 1 To 640
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(79); // Wait For The Next Note
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(16); // Wait For The Next Note
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      player.noteOn(2, 40, 127); // Play The Note 40, at velocity 127 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 41, 123); // Play The Note 41, at velocity 123 on channel 9
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(1, 40, 107); // Play The Note 40, at velocity 107 on channel 1
      Thread.Sleep(129); // Wait For The Next Note
      player.noteOn(1, 52, 113); // Play The Note 52, at velocity 113 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      player.noteOn(1, 40, 105); // Play The Note 40, at velocity 105 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(87); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(112); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(1, 48, 118); // Play The Note 48, at velocity 118 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(116); // Wait For The Next Note
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(87); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(1, 46, 115); // Play The Note 46, at velocity 115 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(87); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(1, 47, 110); // Play The Note 47, at velocity 110 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 48, 111); // Play The Note 48, at velocity 111 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      player.noteOn(2, 40, 127); // Play The Note 40, at velocity 127 on channel 2
      player.noteOn(9, 36, 119); // Play The Note 36, at velocity 119 on channel 9
      player.noteOn(9, 41, 123); // Play The Note 41, at velocity 123 on channel 9
      player.noteOn(9, 40, 119); // Play The Note 40, at velocity 119 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(129); // Wait For The Next Note
      player.noteOn(1, 52, 117); // Play The Note 52, at velocity 117 on channel 1
      Thread.Sleep(100); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(129); // Wait For The Next Note
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(95); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOn(1, 40, 115); // Play The Note 40, at velocity 115 on channel 1
      Thread.Sleep(129); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      player.noteOn(1, 48, 117); // Play The Note 48, at velocity 117 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(1, 46, 114); // Play The Note 46, at velocity 114 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.pitchBend(1, -256); // Change The Pitch Offset On Channel 1 To -256
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 256); // Change The Pitch Offset On Channel 1 To 256
      Thread.Sleep(66); // Wait For The Next Note
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 640); // Change The Pitch Offset On Channel 1 To 640
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(75); // Wait For The Next Note
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      player.noteOn(2, 40, 122); // Play The Note 40, at velocity 122 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      player.noteOn(9, 41, 123); // Play The Note 41, at velocity 123 on channel 9
      player.noteOn(9, 57, 61); // Play The Note 57, at velocity 61 on channel 9
      player.noteOn(9, 49, 71); // Play The Note 49, at velocity 71 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 57, 23); // Play The Note 57, at velocity 23 on channel 9
      player.noteOn(9, 49, 23); // Play The Note 49, at velocity 23 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 52, 114); // Play The Note 52, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 52, 114); // Play The Note 52, at velocity 114 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(0, 50, 111); // Play The Note 50, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 50, 111); // Play The Note 50, at velocity 111 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(95); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 104); // Play The Note 40, at velocity 104 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 104); // Play The Note 40, at velocity 104 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 48, 116); // Play The Note 48, at velocity 116 on channel 0
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 48, 116); // Play The Note 48, at velocity 116 on channel 1
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(120); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 46, 110); // Play The Note 46, at velocity 110 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 46, 110); // Play The Note 46, at velocity 110 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(108); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(129); // Wait For The Next Note
      player.noteOn(0, 47, 110); // Play The Note 47, at velocity 110 on channel 0
      player.noteOn(1, 47, 110); // Play The Note 47, at velocity 110 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 48, 117); // Play The Note 48, at velocity 117 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 48, 117); // Play The Note 48, at velocity 117 on channel 1
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(2, 40, 125); // Play The Note 40, at velocity 125 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 41, 123); // Play The Note 41, at velocity 123 on channel 9
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      player.noteOn(9, 57, 64); // Play The Note 57, at velocity 64 on channel 9
      player.noteOn(9, 49, 70); // Play The Note 49, at velocity 70 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOn(9, 57, 23); // Play The Note 57, at velocity 23 on channel 9
      player.noteOn(9, 49, 23); // Play The Note 49, at velocity 23 on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 52, 114); // Play The Note 52, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 52, 114); // Play The Note 52, at velocity 114 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 50, 106); // Play The Note 50, at velocity 106 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 50, 106); // Play The Note 50, at velocity 106 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 48, 117); // Play The Note 48, at velocity 117 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 48, 117); // Play The Note 48, at velocity 117 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(100); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(0, 46, 114); // Play The Note 46, at velocity 114 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 46, 114); // Play The Note 46, at velocity 114 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.pitchBend(0, -256); // Change The Pitch Offset On Channel 0 To -256
      player.pitchBend(1, -256); // Change The Pitch Offset On Channel 1 To -256
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(70); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 2048); // Change The Pitch Offset On Channel 0 To 2048
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(75); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 2048); // Change The Pitch Offset On Channel 0 To 2048
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(91); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1792); // Change The Pitch Offset On Channel 0 To 1792
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(75); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 640); // Change The Pitch Offset On Channel 0 To 640
      player.pitchBend(1, 640); // Change The Pitch Offset On Channel 1 To 640
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      player.noteOn(2, 40, 125); // Play The Note 40, at velocity 125 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      player.noteOn(9, 41, 123); // Play The Note 41, at velocity 123 on channel 9
      player.noteOn(9, 49, 74); // Play The Note 49, at velocity 74 on channel 9
      player.noteOn(9, 57, 56); // Play The Note 57, at velocity 56 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(0, 40, 107); // Play The Note 40, at velocity 107 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 107); // Play The Note 40, at velocity 107 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOn(9, 49, 23); // Play The Note 49, at velocity 23 on channel 9
      player.noteOn(9, 57, 23); // Play The Note 57, at velocity 23 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 52, 113); // Play The Note 52, at velocity 113 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 52, 113); // Play The Note 52, at velocity 113 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      player.noteOn(0, 40, 105); // Play The Note 40, at velocity 105 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      player.noteOn(1, 40, 105); // Play The Note 40, at velocity 105 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(0, 50, 110); // Play The Note 50, at velocity 110 on channel 0
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(112); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 48, 118); // Play The Note 48, at velocity 118 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 48, 118); // Play The Note 48, at velocity 118 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(112); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 46, 115); // Play The Note 46, at velocity 115 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 46, 115); // Play The Note 46, at velocity 115 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(120); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 47, 110); // Play The Note 47, at velocity 110 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 47, 110); // Play The Note 47, at velocity 110 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 48, 111); // Play The Note 48, at velocity 111 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 48, 111); // Play The Note 48, at velocity 111 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      player.noteOn(2, 40, 116); // Play The Note 40, at velocity 116 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 41, 123); // Play The Note 41, at velocity 123 on channel 9
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      player.noteOn(9, 49, 74); // Play The Note 49, at velocity 74 on channel 9
      player.noteOn(9, 57, 68); // Play The Note 57, at velocity 68 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(9, 49, 23); // Play The Note 49, at velocity 23 on channel 9
      player.noteOn(9, 57, 23); // Play The Note 57, at velocity 23 on channel 9
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 52, 117); // Play The Note 52, at velocity 117 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 52, 117); // Play The Note 52, at velocity 117 on channel 1
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 50, 110); // Play The Note 50, at velocity 110 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 115); // Play The Note 40, at velocity 115 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 115); // Play The Note 40, at velocity 115 on channel 1
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOn(0, 63, 112); // Play The Note 63, at velocity 112 on channel 0
      player.noteOn(9, 41, 91); // Play The Note 41, at velocity 91 on channel 9
      player.noteOn(9, 40, 90); // Play The Note 40, at velocity 90 on channel 9
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 66, 112); // Play The Note 66, at velocity 112 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 63); // Turn off Note 63, on channel 0
      player.noteOn(0, 60, 105); // Play The Note 60, at velocity 105 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 66); // Turn off Note 66, on channel 1
      player.noteOn(1, 64, 105); // Play The Note 64, at velocity 105 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(0, 60); // Turn off Note 60, on channel 0
      player.noteOn(0, 59, 112); // Play The Note 59, at velocity 112 on channel 0
      player.noteOn(9, 36, 85); // Play The Note 36, at velocity 85 on channel 9
      player.noteOn(9, 41, 93); // Play The Note 41, at velocity 93 on channel 9
      player.noteOn(9, 40, 81); // Play The Note 40, at velocity 81 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 63, 112); // Play The Note 63, at velocity 112 on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 59); // Turn off Note 59, on channel 0
      player.noteOn(0, 63, 103); // Play The Note 63, at velocity 103 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 63); // Turn off Note 63, on channel 1
      player.noteOn(1, 66, 103); // Play The Note 66, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 63); // Turn off Note 63, on channel 0
      player.noteOn(0, 66, 111); // Play The Note 66, at velocity 111 on channel 0
      player.noteOff(1, 66); // Turn off Note 66, on channel 1
      player.noteOn(1, 69, 111); // Play The Note 69, at velocity 111 on channel 1
      player.noteOn(9, 36, 88); // Play The Note 36, at velocity 88 on channel 9
      player.noteOn(9, 40, 88); // Play The Note 40, at velocity 88 on channel 9
      player.noteOn(9, 41, 90); // Play The Note 41, at velocity 90 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 66); // Turn off Note 66, on channel 0
      player.noteOn(0, 64, 102); // Play The Note 64, at velocity 102 on channel 0
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 69); // Turn off Note 69, on channel 1
      player.noteOn(1, 67, 102); // Play The Note 67, at velocity 102 on channel 1
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 63, 113); // Play The Note 63, at velocity 113 on channel 0
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      player.noteOn(1, 66, 113); // Play The Note 66, at velocity 113 on channel 1
      player.noteOn(9, 36, 88); // Play The Note 36, at velocity 88 on channel 9
      player.noteOn(9, 41, 91); // Play The Note 41, at velocity 91 on channel 9
      player.noteOn(9, 40, 73); // Play The Note 40, at velocity 73 on channel 9
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 63); // Turn off Note 63, on channel 0
      player.noteOn(0, 59, 103); // Play The Note 59, at velocity 103 on channel 0
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 66); // Turn off Note 66, on channel 1
      player.noteOn(1, 63, 103); // Play The Note 63, at velocity 103 on channel 1
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 59); // Turn off Note 59, on channel 0
      player.noteOn(0, 63, 111); // Play The Note 63, at velocity 111 on channel 0
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      player.noteOn(9, 41, 88); // Play The Note 41, at velocity 88 on channel 9
      player.noteOn(9, 40, 88); // Play The Note 40, at velocity 88 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 63); // Turn off Note 63, on channel 1
      player.noteOn(1, 66, 111); // Play The Note 66, at velocity 111 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 63); // Turn off Note 63, on channel 0
      player.noteOn(0, 64, 101); // Play The Note 64, at velocity 101 on channel 0
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 66); // Turn off Note 66, on channel 1
      player.noteOn(1, 67, 101); // Play The Note 67, at velocity 101 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 66, 112); // Play The Note 66, at velocity 112 on channel 0
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      player.noteOn(9, 40, 82); // Play The Note 40, at velocity 82 on channel 9
      player.noteOn(9, 41, 87); // Play The Note 41, at velocity 87 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      player.noteOn(1, 69, 112); // Play The Note 69, at velocity 112 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(0, 66); // Turn off Note 66, on channel 0
      player.noteOn(0, 67, 103); // Play The Note 67, at velocity 103 on channel 0
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 69); // Turn off Note 69, on channel 1
      player.noteOn(1, 71, 103); // Play The Note 71, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 67); // Turn off Note 67, on channel 0
      player.noteOn(0, 66, 110); // Play The Note 66, at velocity 110 on channel 0
      player.noteOn(9, 36, 91); // Play The Note 36, at velocity 91 on channel 9
      player.noteOn(9, 40, 91); // Play The Note 40, at velocity 91 on channel 9
      player.noteOn(9, 41, 93); // Play The Note 41, at velocity 93 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 71); // Turn off Note 71, on channel 1
      player.noteOn(1, 69, 110); // Play The Note 69, at velocity 110 on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 66); // Turn off Note 66, on channel 0
      player.noteOn(0, 64, 100); // Play The Note 64, at velocity 100 on channel 0
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 69); // Turn off Note 69, on channel 1
      player.noteOn(1, 67, 100); // Play The Note 67, at velocity 100 on channel 1
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 63, 113); // Play The Note 63, at velocity 113 on channel 0
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      player.noteOn(9, 41, 93); // Play The Note 41, at velocity 93 on channel 9
      player.noteOn(9, 40, 90); // Play The Note 40, at velocity 90 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      player.noteOn(1, 66, 113); // Play The Note 66, at velocity 113 on channel 1
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 63); // Turn off Note 63, on channel 0
      player.noteOn(0, 59, 103); // Play The Note 59, at velocity 103 on channel 0
      player.noteOff(1, 66); // Turn off Note 66, on channel 1
      player.noteOn(1, 63, 103); // Play The Note 63, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 59); // Turn off Note 59, on channel 0
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 36, 118); // Play The Note 36, at velocity 118 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 63); // Turn off Note 63, on channel 1
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 52, 114); // Play The Note 52, at velocity 114 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 118); // Play The Note 40, at velocity 118 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 52, 114); // Play The Note 52, at velocity 114 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 85); // Play The Note 46, at velocity 85 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(9, 46, 81); // Play The Note 46, at velocity 81 on channel 9
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 50, 111); // Play The Note 50, at velocity 111 on channel 0
      player.noteOn(1, 50, 111); // Play The Note 50, at velocity 111 on channel 1
      player.noteOn(9, 36, 118); // Play The Note 36, at velocity 118 on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 40, 104); // Play The Note 40, at velocity 104 on channel 0
      player.noteOn(1, 40, 104); // Play The Note 40, at velocity 104 on channel 1
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(9, 46, 81); // Play The Note 46, at velocity 81 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 48, 116); // Play The Note 48, at velocity 116 on channel 0
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 48, 116); // Play The Note 48, at velocity 116 on channel 1
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(95); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 117); // Play The Note 40, at velocity 117 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 46, 110); // Play The Note 46, at velocity 110 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 46, 110); // Play The Note 46, at velocity 110 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(108); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(9, 36, 121); // Play The Note 36, at velocity 121 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOn(0, 47, 110); // Play The Note 47, at velocity 110 on channel 0
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 47, 110); // Play The Note 47, at velocity 110 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 78); // Play The Note 46, at velocity 78 on channel 9
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      player.noteOn(0, 48, 117); // Play The Note 48, at velocity 117 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 48, 117); // Play The Note 48, at velocity 117 on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(0, 52, 114); // Play The Note 52, at velocity 114 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 52, 114); // Play The Note 52, at velocity 114 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(0, 50, 106); // Play The Note 50, at velocity 106 on channel 0
      player.noteOn(9, 36, 117); // Play The Note 36, at velocity 117 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 50, 106); // Play The Note 50, at velocity 106 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 48, 117); // Play The Note 48, at velocity 117 on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 48, 117); // Play The Note 48, at velocity 117 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 117); // Play The Note 40, at velocity 117 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      player.noteOn(9, 46, 69); // Play The Note 46, at velocity 69 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 46, 114); // Play The Note 46, at velocity 114 on channel 0
      player.noteOn(1, 46, 114); // Play The Note 46, at velocity 114 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.pitchBend(0, -256); // Change The Pitch Offset On Channel 0 To -256
      player.pitchBend(1, -256); // Change The Pitch Offset On Channel 1 To -256
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, -384); // Change The Pitch Offset On Channel 0 To -384
      player.pitchBend(1, -384); // Change The Pitch Offset On Channel 1 To -384
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(9, 46, 73); // Play The Note 46, at velocity 73 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 36, 121); // Play The Note 36, at velocity 121 on channel 9
      Thread.Sleep(54); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(16); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 2048); // Change The Pitch Offset On Channel 0 To 2048
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(75); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      player.noteOn(2, 40, 71); // Play The Note 40, at velocity 71 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1792); // Change The Pitch Offset On Channel 0 To 1792
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 640); // Change The Pitch Offset On Channel 0 To 640
      player.pitchBend(1, 640); // Change The Pitch Offset On Channel 1 To 640
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      player.noteOn(2, 40, 77); // Play The Note 40, at velocity 77 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 107); // Play The Note 40, at velocity 107 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 107); // Play The Note 40, at velocity 107 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 52, 113); // Play The Note 52, at velocity 113 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 46, 69); // Play The Note 46, at velocity 69 on channel 9
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 52, 113); // Play The Note 52, at velocity 113 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      player.noteOn(0, 40, 105); // Play The Note 40, at velocity 105 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      player.noteOn(1, 40, 105); // Play The Note 40, at velocity 105 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 46, 79); // Play The Note 46, at velocity 79 on channel 9
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 50, 110); // Play The Note 50, at velocity 110 on channel 0
      player.noteOn(9, 36, 115); // Play The Note 36, at velocity 115 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(0, 48, 118); // Play The Note 48, at velocity 118 on channel 0
      player.noteOn(2, 40, 98); // Play The Note 40, at velocity 98 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 48, 118); // Play The Note 48, at velocity 118 on channel 1
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(0, 46, 115); // Play The Note 46, at velocity 115 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 46, 115); // Play The Note 46, at velocity 115 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(116); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 47, 110); // Play The Note 47, at velocity 110 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 47, 110); // Play The Note 47, at velocity 110 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      player.noteOn(0, 48, 111); // Play The Note 48, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 48, 111); // Play The Note 48, at velocity 111 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(9, 46, 73); // Play The Note 46, at velocity 73 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 52, 117); // Play The Note 52, at velocity 117 on channel 0
      player.noteOn(1, 52, 117); // Play The Note 52, at velocity 117 on channel 1
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 50, 110); // Play The Note 50, at velocity 110 on channel 0
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOn(2, 40, 98); // Play The Note 40, at velocity 98 on channel 2
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      player.noteOn(9, 46, 73); // Play The Note 46, at velocity 73 on channel 9
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 115); // Play The Note 40, at velocity 115 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 115); // Play The Note 40, at velocity 115 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(0, 67, 112); // Play The Note 67, at velocity 112 on channel 0
      player.noteOn(2, 40, 104); // Play The Note 40, at velocity 104 on channel 2
      player.noteOn(9, 36, 82); // Play The Note 36, at velocity 82 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 71, 112); // Play The Note 71, at velocity 112 on channel 1
      player.noteOn(9, 50, 91); // Play The Note 50, at velocity 91 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(9, 40, 82); // Play The Note 40, at velocity 82 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 67); // Turn off Note 67, on channel 0
      player.noteOn(0, 64, 105); // Play The Note 64, at velocity 105 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 71); // Turn off Note 71, on channel 1
      player.noteOn(1, 67, 105); // Play The Note 67, at velocity 105 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 59, 112); // Play The Note 59, at velocity 112 on channel 0
      player.noteOn(9, 36, 92); // Play The Note 36, at velocity 92 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      player.noteOn(1, 64, 112); // Play The Note 64, at velocity 112 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 59); // Turn off Note 59, on channel 0
      player.noteOn(0, 64, 103); // Play The Note 64, at velocity 103 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 67, 103); // Play The Note 67, at velocity 103 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 67, 111); // Play The Note 67, at velocity 111 on channel 0
      player.noteOn(2, 40, 98); // Play The Note 40, at velocity 98 on channel 2
      player.noteOn(9, 36, 92); // Play The Note 36, at velocity 92 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      player.noteOn(1, 71, 111); // Play The Note 71, at velocity 111 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 40, 85); // Play The Note 40, at velocity 85 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(9, 47, 85); // Play The Note 47, at velocity 85 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 47); // Turn off Note 47, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 67); // Turn off Note 67, on channel 0
      player.noteOn(0, 64, 102); // Play The Note 64, at velocity 102 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 71); // Turn off Note 71, on channel 1
      player.noteOn(1, 67, 102); // Play The Note 67, at velocity 102 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 67, 113); // Play The Note 67, at velocity 113 on channel 0
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      player.noteOn(1, 71, 113); // Play The Note 71, at velocity 113 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 67); // Turn off Note 67, on channel 0
      player.noteOn(0, 71, 103); // Play The Note 71, at velocity 103 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 71); // Turn off Note 71, on channel 1
      player.noteOn(1, 76, 103); // Play The Note 76, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 71); // Turn off Note 71, on channel 0
      player.noteOn(0, 67, 111); // Play The Note 67, at velocity 111 on channel 0
      player.noteOff(1, 76); // Turn off Note 76, on channel 1
      player.noteOn(1, 71, 111); // Play The Note 71, at velocity 111 on channel 1
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 36, 87); // Play The Note 36, at velocity 87 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 45, 93); // Play The Note 45, at velocity 93 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 40, 91); // Play The Note 40, at velocity 91 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 67); // Turn off Note 67, on channel 0
      player.noteOn(0, 64, 101); // Play The Note 64, at velocity 101 on channel 0
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 71); // Turn off Note 71, on channel 1
      player.noteOn(1, 67, 101); // Play The Note 67, at velocity 101 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 67, 112); // Play The Note 67, at velocity 112 on channel 0
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      player.noteOn(1, 71, 112); // Play The Note 71, at velocity 112 on channel 1
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 67); // Turn off Note 67, on channel 0
      player.noteOn(0, 64, 103); // Play The Note 64, at velocity 103 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 71); // Turn off Note 71, on channel 1
      player.noteOn(1, 67, 103); // Play The Note 67, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 67, 110); // Play The Note 67, at velocity 110 on channel 0
      player.noteOn(2, 40, 104); // Play The Note 40, at velocity 104 on channel 2
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      player.noteOn(1, 71, 110); // Play The Note 71, at velocity 110 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(9, 40, 90); // Play The Note 40, at velocity 90 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(9, 41, 73); // Play The Note 41, at velocity 73 on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 67); // Turn off Note 67, on channel 0
      player.noteOn(0, 71, 100); // Play The Note 71, at velocity 100 on channel 0
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 71); // Turn off Note 71, on channel 1
      player.noteOn(1, 76, 100); // Play The Note 76, at velocity 100 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 71); // Turn off Note 71, on channel 0
      player.noteOn(0, 76, 113); // Play The Note 76, at velocity 113 on channel 0
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 76); // Turn off Note 76, on channel 1
      player.noteOn(1, 79, 113); // Play The Note 79, at velocity 113 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 40, 91); // Play The Note 40, at velocity 91 on channel 9
      player.noteOn(9, 41, 88); // Play The Note 41, at velocity 88 on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 76); // Turn off Note 76, on channel 0
      player.noteOn(0, 79, 103); // Play The Note 79, at velocity 103 on channel 0
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 79); // Turn off Note 79, on channel 1
      player.noteOn(1, 83, 103); // Play The Note 83, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 79); // Turn off Note 79, on channel 0
      player.noteOn(0, 45, 108); // Play The Note 45, at velocity 108 on channel 0
      player.noteOn(2, 33, 86); // Play The Note 33, at velocity 86 on channel 2
      player.noteOn(9, 36, 118); // Play The Note 36, at velocity 118 on channel 9
      player.noteOn(9, 51, 112); // Play The Note 51, at velocity 112 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 83); // Turn off Note 83, on channel 1
      player.noteOn(1, 45, 108); // Play The Note 45, at velocity 108 on channel 1
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 45, 114); // Play The Note 45, at velocity 114 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 114); // Play The Note 45, at velocity 114 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 57, 114); // Play The Note 57, at velocity 114 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 40, 118); // Play The Note 40, at velocity 118 on channel 9
      player.noteOn(9, 51, 116); // Play The Note 51, at velocity 116 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 57, 114); // Play The Note 57, at velocity 114 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 57); // Turn off Note 57, on channel 0
      player.noteOn(0, 45, 110); // Play The Note 45, at velocity 110 on channel 0
      player.noteOff(1, 57); // Turn off Note 57, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 110); // Play The Note 45, at velocity 110 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 45, 110); // Play The Note 45, at velocity 110 on channel 0
      player.noteOn(2, 33, 86); // Play The Note 33, at velocity 86 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 51, 116); // Play The Note 51, at velocity 116 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 110); // Play The Note 45, at velocity 110 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOn(0, 55, 111); // Play The Note 55, at velocity 111 on channel 0
      player.noteOn(9, 36, 118); // Play The Note 36, at velocity 118 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 55, 111); // Play The Note 55, at velocity 111 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 55); // Turn off Note 55, on channel 0
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 45, 104); // Play The Note 45, at velocity 104 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      player.noteOn(9, 51, 110); // Play The Note 51, at velocity 110 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 104); // Play The Note 45, at velocity 104 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(0, 53, 116); // Play The Note 53, at velocity 116 on channel 0
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.noteOn(1, 53, 116); // Play The Note 53, at velocity 116 on channel 1
      player.noteOn(2, 33, 89); // Play The Note 33, at velocity 89 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 51, 117); // Play The Note 51, at velocity 117 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 53); // Turn off Note 53, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 45, 108); // Play The Note 45, at velocity 108 on channel 0
      player.noteOff(1, 53); // Turn off Note 53, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 108); // Play The Note 45, at velocity 108 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 45, 110); // Play The Note 45, at velocity 110 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 40, 117); // Play The Note 40, at velocity 117 on channel 9
      player.noteOn(9, 51, 119); // Play The Note 51, at velocity 119 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 110); // Play The Note 45, at velocity 110 on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 51, 110); // Play The Note 51, at velocity 110 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.noteOn(1, 51, 110); // Play The Note 51, at velocity 110 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(112); // Wait For The Next Note
      player.noteOff(0, 51); // Turn off Note 51, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 45, 110); // Play The Note 45, at velocity 110 on channel 0
      player.noteOff(1, 51); // Turn off Note 51, on channel 1
      player.noteOn(2, 33, 83); // Play The Note 33, at velocity 83 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 51, 111); // Play The Note 51, at velocity 111 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 110); // Play The Note 45, at velocity 110 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      player.noteOn(9, 36, 121); // Play The Note 36, at velocity 121 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(0, 52, 110); // Play The Note 52, at velocity 110 on channel 0
      player.noteOn(2, 33, 83); // Play The Note 33, at velocity 83 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 51, 111); // Play The Note 51, at velocity 111 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 52, 110); // Play The Note 52, at velocity 110 on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      player.noteOn(0, 53, 117); // Play The Note 53, at velocity 117 on channel 0
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 53, 117); // Play The Note 53, at velocity 117 on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 53); // Turn off Note 53, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 53); // Turn off Note 53, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 51, 108); // Play The Note 51, at velocity 108 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(129); // Wait For The Next Note
      player.noteOn(0, 57, 114); // Play The Note 57, at velocity 114 on channel 0
      player.noteOn(1, 57, 114); // Play The Note 57, at velocity 114 on channel 1
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      player.noteOn(9, 51, 111); // Play The Note 51, at velocity 111 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 57); // Turn off Note 57, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 57); // Turn off Note 57, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 45, 106); // Play The Note 45, at velocity 106 on channel 0
      player.noteOn(1, 45, 106); // Play The Note 45, at velocity 106 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOn(0, 45, 108); // Play The Note 45, at velocity 108 on channel 0
      player.noteOn(2, 33, 89); // Play The Note 33, at velocity 89 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 51, 101); // Play The Note 51, at velocity 101 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 108); // Play The Note 45, at velocity 108 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOn(0, 55, 106); // Play The Note 55, at velocity 106 on channel 0
      player.noteOn(9, 36, 117); // Play The Note 36, at velocity 117 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 55, 106); // Play The Note 55, at velocity 106 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(0, 55); // Turn off Note 55, on channel 0
      player.noteOn(0, 45, 114); // Play The Note 45, at velocity 114 on channel 0
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      player.noteOn(2, 33, 83); // Play The Note 33, at velocity 83 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 51, 112); // Play The Note 51, at velocity 112 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 114); // Play The Note 45, at velocity 114 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 45, 106); // Play The Note 45, at velocity 106 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 106); // Play The Note 45, at velocity 106 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 53, 117); // Play The Note 53, at velocity 117 on channel 0
      player.noteOn(2, 33, 89); // Play The Note 33, at velocity 89 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 51, 105); // Play The Note 51, at velocity 105 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.noteOn(1, 53, 117); // Play The Note 53, at velocity 117 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 53); // Turn off Note 53, on channel 0
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 53); // Turn off Note 53, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOn(0, 45, 114); // Play The Note 45, at velocity 114 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 40, 117); // Play The Note 40, at velocity 117 on channel 9
      player.noteOn(9, 51, 108); // Play The Note 51, at velocity 108 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 114); // Play The Note 45, at velocity 114 on channel 1
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 51, 114); // Play The Note 51, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 51, 114); // Play The Note 51, at velocity 114 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.pitchBend(0, -256); // Change The Pitch Offset On Channel 0 To -256
      player.pitchBend(1, -256); // Change The Pitch Offset On Channel 1 To -256
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, -384); // Change The Pitch Offset On Channel 0 To -384
      player.pitchBend(1, -384); // Change The Pitch Offset On Channel 1 To -384
      Thread.Sleep(16); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(2, 33, 86); // Play The Note 33, at velocity 86 on channel 2
      player.noteOn(9, 36, 121); // Play The Note 36, at velocity 121 on channel 9
      player.noteOn(9, 51, 117); // Play The Note 51, at velocity 117 on channel 9
      Thread.Sleep(54); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 640); // Change The Pitch Offset On Channel 0 To 640
      player.pitchBend(1, 640); // Change The Pitch Offset On Channel 1 To 640
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 2048); // Change The Pitch Offset On Channel 0 To 2048
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(79); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      player.noteOn(2, 33, 71); // Play The Note 33, at velocity 71 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 51, 108); // Play The Note 51, at velocity 108 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(16); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1792); // Change The Pitch Offset On Channel 0 To 1792
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.noteOn(0, 45, 108); // Play The Note 45, at velocity 108 on channel 0
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      player.noteOn(2, 33, 77); // Play The Note 33, at velocity 77 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 51, 107); // Play The Note 51, at velocity 107 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOn(1, 45, 108); // Play The Note 45, at velocity 108 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 51); // Turn off Note 51, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 51); // Turn off Note 51, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 45, 107); // Play The Note 45, at velocity 107 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 107); // Play The Note 45, at velocity 107 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 57, 113); // Play The Note 57, at velocity 113 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      player.noteOn(9, 51, 115); // Play The Note 51, at velocity 115 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 57, 113); // Play The Note 57, at velocity 113 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 57); // Turn off Note 57, on channel 0
      player.noteOn(0, 45, 105); // Play The Note 45, at velocity 105 on channel 0
      player.noteOff(1, 57); // Turn off Note 57, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 105); // Play The Note 45, at velocity 105 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 51, 107); // Play The Note 51, at velocity 107 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(0, 55, 110); // Play The Note 55, at velocity 110 on channel 0
      player.noteOn(9, 36, 115); // Play The Note 36, at velocity 115 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 55, 110); // Play The Note 55, at velocity 110 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      player.noteOn(2, 33, 89); // Play The Note 33, at velocity 89 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      player.noteOn(9, 51, 114); // Play The Note 51, at velocity 114 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 55); // Turn off Note 55, on channel 0
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 45, 114); // Play The Note 45, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 114); // Play The Note 45, at velocity 114 on channel 1
      Thread.Sleep(129); // Wait For The Next Note
      player.noteOn(0, 53, 118); // Play The Note 53, at velocity 118 on channel 0
      player.noteOn(1, 53, 118); // Play The Note 53, at velocity 118 on channel 1
      player.noteOn(2, 33, 98); // Play The Note 33, at velocity 98 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 51, 110); // Play The Note 51, at velocity 110 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 53); // Turn off Note 53, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 45, 106); // Play The Note 45, at velocity 106 on channel 0
      player.noteOff(1, 53); // Turn off Note 53, on channel 1
      player.noteOn(1, 45, 106); // Play The Note 45, at velocity 106 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 45, 108); // Play The Note 45, at velocity 108 on channel 0
      player.noteOn(2, 33, 89); // Play The Note 33, at velocity 89 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 51, 119); // Play The Note 51, at velocity 119 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 108); // Play The Note 45, at velocity 108 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 51, 115); // Play The Note 51, at velocity 115 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.noteOn(1, 51, 115); // Play The Note 51, at velocity 115 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(116); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      player.noteOn(2, 33, 86); // Play The Note 33, at velocity 86 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 51, 110); // Play The Note 51, at velocity 110 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 51); // Turn off Note 51, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 51); // Turn off Note 51, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 52, 110); // Play The Note 52, at velocity 110 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 51, 110); // Play The Note 51, at velocity 110 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 52, 110); // Play The Note 52, at velocity 110 on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      player.noteOn(0, 53, 111); // Play The Note 53, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      player.noteOn(1, 53, 111); // Play The Note 53, at velocity 111 on channel 1
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 53); // Turn off Note 53, on channel 0
      player.noteOn(0, 45, 110); // Play The Note 45, at velocity 110 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 51, 119); // Play The Note 51, at velocity 119 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 53); // Turn off Note 53, on channel 1
      player.noteOn(1, 45, 110); // Play The Note 45, at velocity 110 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 45, 108); // Play The Note 45, at velocity 108 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 108); // Play The Note 45, at velocity 108 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 57, 117); // Play The Note 57, at velocity 117 on channel 0
      player.noteOn(2, 33, 83); // Play The Note 33, at velocity 83 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      player.noteOn(9, 51, 115); // Play The Note 51, at velocity 115 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 57, 117); // Play The Note 57, at velocity 117 on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 57); // Turn off Note 57, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 57); // Turn off Note 57, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 45, 108); // Play The Note 45, at velocity 108 on channel 0
      player.noteOn(1, 45, 108); // Play The Note 45, at velocity 108 on channel 1
      player.noteOn(2, 33, 89); // Play The Note 33, at velocity 89 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 51, 119); // Play The Note 51, at velocity 119 on channel 9
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(0, 55, 110); // Play The Note 55, at velocity 110 on channel 0
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 55, 110); // Play The Note 55, at velocity 110 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(0, 55); // Turn off Note 55, on channel 0
      player.noteOn(0, 45, 114); // Play The Note 45, at velocity 114 on channel 0
      player.noteOn(2, 33, 98); // Play The Note 33, at velocity 98 on channel 2
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 51, 117); // Play The Note 51, at velocity 117 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      player.noteOn(1, 45, 114); // Play The Note 45, at velocity 114 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 45, 115); // Play The Note 45, at velocity 115 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 115); // Play The Note 45, at velocity 115 on channel 1
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(0, 69, 112); // Play The Note 69, at velocity 112 on channel 0
      player.noteOn(2, 33, 104); // Play The Note 33, at velocity 104 on channel 2
      player.noteOn(9, 51, 113); // Play The Note 51, at velocity 113 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 64, 112); // Play The Note 64, at velocity 112 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 40, 82); // Play The Note 40, at velocity 82 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 69); // Turn off Note 69, on channel 0
      player.noteOn(0, 65, 105); // Play The Note 65, at velocity 105 on channel 0
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 62, 105); // Play The Note 62, at velocity 105 on channel 1
      player.noteOn(9, 40, 88); // Play The Note 40, at velocity 88 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 65); // Turn off Note 65, on channel 0
      player.noteOn(0, 64, 112); // Play The Note 64, at velocity 112 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 62); // Turn off Note 62, on channel 1
      player.noteOn(1, 60, 112); // Play The Note 60, at velocity 112 on channel 1
      player.noteOn(9, 36, 79); // Play The Note 36, at velocity 79 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 69, 103); // Play The Note 69, at velocity 103 on channel 0
      player.noteOff(1, 60); // Turn off Note 60, on channel 1
      player.noteOn(1, 64, 103); // Play The Note 64, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 69); // Turn off Note 69, on channel 0
      player.noteOn(0, 64, 111); // Play The Note 64, at velocity 111 on channel 0
      player.noteOn(2, 33, 98); // Play The Note 33, at velocity 98 on channel 2
      player.noteOn(9, 40, 93); // Play The Note 40, at velocity 93 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 60, 111); // Play The Note 60, at velocity 111 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 60, 102); // Play The Note 60, at velocity 102 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 60); // Turn off Note 60, on channel 1
      player.noteOn(1, 57, 102); // Play The Note 57, at velocity 102 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 60); // Turn off Note 60, on channel 0
      player.noteOn(0, 64, 113); // Play The Note 64, at velocity 113 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 57); // Turn off Note 57, on channel 1
      player.noteOn(1, 60, 113); // Play The Note 60, at velocity 113 on channel 1
      player.noteOn(9, 36, 88); // Play The Note 36, at velocity 88 on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 69, 103); // Play The Note 69, at velocity 103 on channel 0
      player.noteOn(9, 36, 86); // Play The Note 36, at velocity 86 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 60); // Turn off Note 60, on channel 1
      player.noteOn(1, 64, 103); // Play The Note 64, at velocity 103 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 69); // Turn off Note 69, on channel 0
      player.noteOn(0, 72, 111); // Play The Note 72, at velocity 111 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 69, 111); // Play The Note 69, at velocity 111 on channel 1
      player.noteOn(9, 40, 93); // Play The Note 40, at velocity 93 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 72); // Turn off Note 72, on channel 0
      player.noteOn(0, 69, 101); // Play The Note 69, at velocity 101 on channel 0
      player.noteOn(9, 40, 87); // Play The Note 40, at velocity 87 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 69); // Turn off Note 69, on channel 1
      player.noteOn(1, 64, 101); // Play The Note 64, at velocity 101 on channel 1
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 69); // Turn off Note 69, on channel 0
      player.noteOn(0, 64, 112); // Play The Note 64, at velocity 112 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 60, 112); // Play The Note 60, at velocity 112 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(9, 36, 86); // Play The Note 36, at velocity 86 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 69, 103); // Play The Note 69, at velocity 103 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 60); // Turn off Note 60, on channel 1
      player.noteOn(1, 64, 103); // Play The Note 64, at velocity 103 on channel 1
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 69); // Turn off Note 69, on channel 0
      player.noteOn(0, 64, 110); // Play The Note 64, at velocity 110 on channel 0
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 60, 110); // Play The Note 60, at velocity 110 on channel 1
      player.noteOn(2, 33, 104); // Play The Note 33, at velocity 104 on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 40, 93); // Play The Note 40, at velocity 93 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 69, 100); // Play The Note 69, at velocity 100 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 60); // Turn off Note 60, on channel 1
      player.noteOn(1, 64, 100); // Play The Note 64, at velocity 100 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 40, 88); // Play The Note 40, at velocity 88 on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 69); // Turn off Note 69, on channel 0
      player.noteOn(0, 64, 113); // Play The Note 64, at velocity 113 on channel 0
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 60, 113); // Play The Note 60, at velocity 113 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 60, 103); // Play The Note 60, at velocity 103 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 60); // Turn off Note 60, on channel 1
      player.noteOn(1, 57, 103); // Play The Note 57, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 60); // Turn off Note 60, on channel 0
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 36, 118); // Play The Note 36, at velocity 118 on channel 9
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 57); // Turn off Note 57, on channel 1
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 52, 114); // Play The Note 52, at velocity 114 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 118); // Play The Note 40, at velocity 118 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 52, 114); // Play The Note 52, at velocity 114 on channel 1
      player.noteOn(9, 46, 85); // Play The Note 46, at velocity 85 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 81); // Play The Note 46, at velocity 81 on channel 9
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 50, 111); // Play The Note 50, at velocity 111 on channel 0
      player.noteOn(9, 36, 118); // Play The Note 36, at velocity 118 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 50, 111); // Play The Note 50, at velocity 111 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 104); // Play The Note 40, at velocity 104 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 104); // Play The Note 40, at velocity 104 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(9, 46, 81); // Play The Note 46, at velocity 81 on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 48, 116); // Play The Note 48, at velocity 116 on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 48, 116); // Play The Note 48, at velocity 116 on channel 1
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 117); // Play The Note 40, at velocity 117 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 46, 110); // Play The Note 46, at velocity 110 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 46, 110); // Play The Note 46, at velocity 110 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(112); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(9, 36, 121); // Play The Note 36, at velocity 121 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOn(0, 47, 110); // Play The Note 47, at velocity 110 on channel 0
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 47, 110); // Play The Note 47, at velocity 110 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 78); // Play The Note 46, at velocity 78 on channel 9
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 48, 117); // Play The Note 48, at velocity 117 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 48, 117); // Play The Note 48, at velocity 117 on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 52, 114); // Play The Note 52, at velocity 114 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 52, 114); // Play The Note 52, at velocity 114 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(87); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 50, 106); // Play The Note 50, at velocity 106 on channel 0
      player.noteOn(1, 50, 106); // Play The Note 50, at velocity 106 on channel 1
      player.noteOn(9, 36, 117); // Play The Note 36, at velocity 117 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 48, 117); // Play The Note 48, at velocity 117 on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 48, 117); // Play The Note 48, at velocity 117 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 117); // Play The Note 40, at velocity 117 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      player.noteOn(9, 46, 69); // Play The Note 46, at velocity 69 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 46, 114); // Play The Note 46, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 46, 114); // Play The Note 46, at velocity 114 on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.pitchBend(0, -256); // Change The Pitch Offset On Channel 0 To -256
      player.pitchBend(1, -256); // Change The Pitch Offset On Channel 1 To -256
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 46, 73); // Play The Note 46, at velocity 73 on channel 9
      player.noteOn(9, 36, 121); // Play The Note 36, at velocity 121 on channel 9
      Thread.Sleep(54); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 640); // Change The Pitch Offset On Channel 0 To 640
      player.pitchBend(1, 640); // Change The Pitch Offset On Channel 1 To 640
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 2048); // Change The Pitch Offset On Channel 0 To 2048
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      player.noteOn(2, 40, 71); // Play The Note 40, at velocity 71 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1792); // Change The Pitch Offset On Channel 0 To 1792
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(16); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      player.noteOn(2, 40, 77); // Play The Note 40, at velocity 77 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 107); // Play The Note 40, at velocity 107 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 107); // Play The Note 40, at velocity 107 on channel 1
      Thread.Sleep(120); // Wait For The Next Note
      player.noteOn(9, 46, 69); // Play The Note 46, at velocity 69 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 52, 113); // Play The Note 52, at velocity 113 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 52, 113); // Play The Note 52, at velocity 113 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 105); // Play The Note 40, at velocity 105 on channel 0
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 105); // Play The Note 40, at velocity 105 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 46, 79); // Play The Note 46, at velocity 79 on channel 9
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 50, 110); // Play The Note 50, at velocity 110 on channel 0
      player.noteOn(9, 36, 115); // Play The Note 36, at velocity 115 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 48, 118); // Play The Note 48, at velocity 118 on channel 0
      player.noteOn(2, 40, 98); // Play The Note 40, at velocity 98 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 48, 118); // Play The Note 48, at velocity 118 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 46, 115); // Play The Note 46, at velocity 115 on channel 0
      player.noteOn(1, 46, 115); // Play The Note 46, at velocity 115 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 47, 110); // Play The Note 47, at velocity 110 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 47, 110); // Play The Note 47, at velocity 110 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      player.noteOn(0, 48, 111); // Play The Note 48, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 48, 111); // Play The Note 48, at velocity 111 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(116); // Wait For The Next Note
      player.noteOn(9, 46, 73); // Play The Note 46, at velocity 73 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 52, 117); // Play The Note 52, at velocity 117 on channel 0
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 52, 117); // Play The Note 52, at velocity 117 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 50, 110); // Play The Note 50, at velocity 110 on channel 0
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      player.noteOn(2, 40, 98); // Play The Note 40, at velocity 98 on channel 2
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 73); // Play The Note 46, at velocity 73 on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 115); // Play The Note 40, at velocity 115 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 115); // Play The Note 40, at velocity 115 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 48, 117); // Play The Note 48, at velocity 117 on channel 0
      player.noteOn(2, 40, 104); // Play The Note 40, at velocity 104 on channel 2
      player.noteOn(9, 38, 85); // Play The Note 38, at velocity 85 on channel 9
      player.noteOn(9, 40, 92); // Play The Note 40, at velocity 92 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      player.noteOn(1, 48, 117); // Play The Note 48, at velocity 117 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 38); // Turn off Note 38, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(100); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOn(9, 36, 86); // Play The Note 36, at velocity 86 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOn(9, 38, 82); // Play The Note 38, at velocity 82 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 40, 92); // Play The Note 40, at velocity 92 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOn(2, 40, 98); // Play The Note 40, at velocity 98 on channel 2
      player.noteOff(9, 38); // Turn off Note 38, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(100); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 36, 91); // Play The Note 36, at velocity 91 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 46, 114); // Play The Note 46, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 46, 114); // Play The Note 46, at velocity 114 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.pitchBend(0, -256); // Change The Pitch Offset On Channel 0 To -256
      player.pitchBend(1, -256); // Change The Pitch Offset On Channel 1 To -256
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1792); // Change The Pitch Offset On Channel 0 To 1792
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 256); // Change The Pitch Offset On Channel 0 To 256
      player.pitchBend(1, 256); // Change The Pitch Offset On Channel 1 To 256
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 38, 79); // Play The Note 38, at velocity 79 on channel 9
      player.noteOn(9, 40, 88); // Play The Note 40, at velocity 88 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 38); // Turn off Note 38, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      player.noteOn(9, 38, 79); // Play The Note 38, at velocity 79 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 640); // Change The Pitch Offset On Channel 0 To 640
      player.pitchBend(1, 640); // Change The Pitch Offset On Channel 1 To 640
      player.noteOn(9, 40, 90); // Play The Note 40, at velocity 90 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      player.noteOff(9, 38); // Turn off Note 38, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 2048); // Change The Pitch Offset On Channel 0 To 2048
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(54); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      player.noteOn(9, 38, 87); // Play The Note 38, at velocity 87 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      player.noteOn(2, 40, 104); // Play The Note 40, at velocity 104 on channel 2
      player.noteOn(9, 40, 93); // Play The Note 40, at velocity 93 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      player.noteOff(9, 38); // Turn off Note 38, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1792); // Change The Pitch Offset On Channel 0 To 1792
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      player.noteOn(0, 49, 108); // Play The Note 49, at velocity 108 on channel 0
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      player.noteOn(1, 49, 108); // Play The Note 49, at velocity 108 on channel 1
      player.noteOn(2, 37, 110); // Play The Note 37, at velocity 110 on channel 2
      player.noteOn(9, 36, 118); // Play The Note 36, at velocity 118 on channel 9
      player.noteOn(9, 57, 79); // Play The Note 57, at velocity 79 on channel 9
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOn(0, 49, 114); // Play The Note 49, at velocity 114 on channel 0
      player.noteOn(1, 49, 114); // Play The Note 49, at velocity 114 on channel 1
      player.noteOff(2, 37); // Turn off Note 37, on channel 2
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(9, 53, 123); // Play The Note 53, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 61, 114); // Play The Note 61, at velocity 114 on channel 0
      player.noteOn(2, 37, 98); // Play The Note 37, at velocity 98 on channel 2
      player.noteOn(9, 40, 118); // Play The Note 40, at velocity 118 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 61, 114); // Play The Note 61, at velocity 114 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 61); // Turn off Note 61, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 49, 110); // Play The Note 49, at velocity 110 on channel 0
      player.noteOff(1, 61); // Turn off Note 61, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 49, 110); // Play The Note 49, at velocity 110 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 37); // Turn off Note 37, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 49, 110); // Play The Note 49, at velocity 110 on channel 0
      player.noteOn(2, 37, 89); // Play The Note 37, at velocity 89 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 49, 110); // Play The Note 49, at velocity 110 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(0, 59, 111); // Play The Note 59, at velocity 111 on channel 0
      player.noteOn(9, 36, 118); // Play The Note 36, at velocity 118 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 59, 111); // Play The Note 59, at velocity 111 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 37); // Turn off Note 37, on channel 2
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 59); // Turn off Note 59, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 59); // Turn off Note 59, on channel 1
      player.noteOn(9, 53, 122); // Play The Note 53, at velocity 122 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 49, 104); // Play The Note 49, at velocity 104 on channel 0
      player.noteOn(2, 37, 104); // Play The Note 37, at velocity 104 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 49, 104); // Play The Note 49, at velocity 104 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(0, 49, 111); // Play The Note 49, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 49, 111); // Play The Note 49, at velocity 111 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 37); // Turn off Note 37, on channel 2
      Thread.Sleep(112); // Wait For The Next Note
      player.noteOn(0, 57, 116); // Play The Note 57, at velocity 116 on channel 0
      player.noteOn(2, 37, 114); // Play The Note 37, at velocity 114 on channel 2
      player.noteOn(9, 53, 124); // Play The Note 53, at velocity 124 on channel 9
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      player.noteOn(1, 57, 116); // Play The Note 57, at velocity 116 on channel 1
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 57); // Turn off Note 57, on channel 0
      player.noteOn(0, 49, 108); // Play The Note 49, at velocity 108 on channel 0
      player.noteOff(1, 57); // Turn off Note 57, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 49, 108); // Play The Note 49, at velocity 108 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 37); // Turn off Note 37, on channel 2
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 49, 110); // Play The Note 49, at velocity 110 on channel 0
      player.noteOn(2, 37, 104); // Play The Note 37, at velocity 104 on channel 2
      player.noteOn(9, 40, 117); // Play The Note 40, at velocity 117 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 49, 110); // Play The Note 49, at velocity 110 on channel 1
      player.noteOn(9, 53, 114); // Play The Note 53, at velocity 114 on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOn(0, 55, 110); // Play The Note 55, at velocity 110 on channel 0
      player.noteOn(1, 55, 110); // Play The Note 55, at velocity 110 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 37); // Turn off Note 37, on channel 2
      Thread.Sleep(95); // Wait For The Next Note
      player.noteOff(0, 55); // Turn off Note 55, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 49, 110); // Play The Note 49, at velocity 110 on channel 0
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      player.noteOn(1, 49, 110); // Play The Note 49, at velocity 110 on channel 1
      player.noteOn(2, 37, 104); // Play The Note 37, at velocity 104 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 53, 120); // Play The Note 53, at velocity 120 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(0, 49, 111); // Play The Note 49, at velocity 111 on channel 0
      player.noteOn(9, 36, 121); // Play The Note 36, at velocity 121 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 49, 111); // Play The Note 49, at velocity 111 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 37); // Turn off Note 37, on channel 2
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(9, 53, 124); // Play The Note 53, at velocity 124 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 56, 110); // Play The Note 56, at velocity 110 on channel 0
      player.noteOn(2, 37, 98); // Play The Note 37, at velocity 98 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 56, 110); // Play The Note 56, at velocity 110 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 56); // Turn off Note 56, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 57, 117); // Play The Note 57, at velocity 117 on channel 0
      player.noteOff(1, 56); // Turn off Note 56, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 57, 117); // Play The Note 57, at velocity 117 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 37); // Turn off Note 37, on channel 2
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 57); // Turn off Note 57, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 57); // Turn off Note 57, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 47, 111); // Play The Note 47, at velocity 111 on channel 0
      player.noteOn(2, 35, 77); // Play The Note 35, at velocity 77 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 49, 79); // Play The Note 49, at velocity 79 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 47, 111); // Play The Note 47, at velocity 111 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 47, 111); // Play The Note 47, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 47, 111); // Play The Note 47, at velocity 111 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 35); // Turn off Note 35, on channel 2
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(9, 53, 124); // Play The Note 53, at velocity 124 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 59, 114); // Play The Note 59, at velocity 114 on channel 0
      player.noteOn(2, 35, 92); // Play The Note 35, at velocity 92 on channel 2
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 59, 114); // Play The Note 59, at velocity 114 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 59); // Turn off Note 59, on channel 0
      player.noteOff(1, 59); // Turn off Note 59, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 47, 106); // Play The Note 47, at velocity 106 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 47, 106); // Play The Note 47, at velocity 106 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 35); // Turn off Note 35, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOn(9, 53, 119); // Play The Note 53, at velocity 119 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 47, 108); // Play The Note 47, at velocity 108 on channel 0
      player.noteOn(2, 35, 104); // Play The Note 35, at velocity 104 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 47, 108); // Play The Note 47, at velocity 108 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(0, 57, 106); // Play The Note 57, at velocity 106 on channel 0
      player.noteOn(9, 36, 117); // Play The Note 36, at velocity 117 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 57, 106); // Play The Note 57, at velocity 106 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOff(2, 35); // Turn off Note 35, on channel 2
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(9, 53, 124); // Play The Note 53, at velocity 124 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 57); // Turn off Note 57, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 47, 114); // Play The Note 47, at velocity 114 on channel 0
      player.noteOff(1, 57); // Turn off Note 57, on channel 1
      player.noteOn(1, 47, 114); // Play The Note 47, at velocity 114 on channel 1
      player.noteOn(2, 35, 86); // Play The Note 35, at velocity 86 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(0, 47, 106); // Play The Note 47, at velocity 106 on channel 0
      player.noteOn(1, 47, 106); // Play The Note 47, at velocity 106 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 35); // Turn off Note 35, on channel 2
      Thread.Sleep(112); // Wait For The Next Note
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 55, 117); // Play The Note 55, at velocity 117 on channel 0
      player.noteOn(2, 33, 98); // Play The Note 33, at velocity 98 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      player.noteOn(1, 55, 117); // Play The Note 55, at velocity 117 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 55); // Turn off Note 55, on channel 0
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 46, 111); // Play The Note 46, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 46, 111); // Play The Note 46, at velocity 111 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOn(0, 45, 114); // Play The Note 45, at velocity 114 on channel 0
      player.noteOn(2, 33, 98); // Play The Note 33, at velocity 98 on channel 2
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      player.noteOn(9, 40, 117); // Play The Note 40, at velocity 117 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 114); // Play The Note 45, at velocity 114 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(0, 53, 114); // Play The Note 53, at velocity 114 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 53, 114); // Play The Note 53, at velocity 114 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(29); // Wait For The Next Note
      player.pitchBend(0, -256); // Change The Pitch Offset On Channel 0 To -256
      player.pitchBend(1, -256); // Change The Pitch Offset On Channel 1 To -256
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1792); // Change The Pitch Offset On Channel 0 To 1792
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 256); // Change The Pitch Offset On Channel 0 To 256
      player.pitchBend(1, 256); // Change The Pitch Offset On Channel 1 To 256
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(2, 33, 86); // Play The Note 33, at velocity 86 on channel 2
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      player.noteOn(9, 36, 121); // Play The Note 36, at velocity 121 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 640); // Change The Pitch Offset On Channel 0 To 640
      player.pitchBend(1, 640); // Change The Pitch Offset On Channel 1 To 640
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 2048); // Change The Pitch Offset On Channel 0 To 2048
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(16); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(45); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(16); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      player.noteOn(2, 33, 89); // Play The Note 33, at velocity 89 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1792); // Change The Pitch Offset On Channel 0 To 1792
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(75); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      player.noteOn(2, 40, 80); // Play The Note 40, at velocity 80 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 57, 79); // Play The Note 57, at velocity 79 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 53); // Turn off Note 53, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 53); // Turn off Note 53, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOn(0, 40, 107); // Play The Note 40, at velocity 107 on channel 0
      player.noteOn(1, 40, 107); // Play The Note 40, at velocity 107 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 52, 113); // Play The Note 52, at velocity 113 on channel 0
      player.noteOn(1, 52, 113); // Play The Note 52, at velocity 113 on channel 1
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 105); // Play The Note 40, at velocity 105 on channel 0
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 105); // Play The Note 40, at velocity 105 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(0, 50, 110); // Play The Note 50, at velocity 110 on channel 0
      player.noteOn(9, 36, 115); // Play The Note 36, at velocity 115 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOn(9, 53, 124); // Play The Note 53, at velocity 124 on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(9, 53, 124); // Play The Note 53, at velocity 124 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 48, 118); // Play The Note 48, at velocity 118 on channel 0
      player.noteOn(2, 40, 77); // Play The Note 40, at velocity 77 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 48, 118); // Play The Note 48, at velocity 118 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(2, 40, 74); // Play The Note 40, at velocity 74 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(0, 46, 115); // Play The Note 46, at velocity 115 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 46, 115); // Play The Note 46, at velocity 115 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(100); // Wait For The Next Note
      player.noteOn(0, 47, 110); // Play The Note 47, at velocity 110 on channel 0
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 53, 119); // Play The Note 53, at velocity 119 on channel 9
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 47, 110); // Play The Note 47, at velocity 110 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      player.noteOn(0, 48, 111); // Play The Note 48, at velocity 111 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 48, 111); // Play The Note 48, at velocity 111 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 53, 124); // Play The Note 53, at velocity 124 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(108); // Wait For The Next Note
      player.noteOn(0, 52, 117); // Play The Note 52, at velocity 117 on channel 0
      player.noteOn(2, 40, 98); // Play The Note 40, at velocity 98 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 52, 117); // Play The Note 52, at velocity 117 on channel 1
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      player.noteOn(9, 53, 124); // Play The Note 53, at velocity 124 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOn(0, 50, 110); // Play The Note 50, at velocity 110 on channel 0
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOn(2, 40, 104); // Play The Note 40, at velocity 104 on channel 2
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOn(0, 40, 115); // Play The Note 40, at velocity 115 on channel 0
      player.noteOn(1, 40, 115); // Play The Note 40, at velocity 115 on channel 1
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 67, 112); // Play The Note 67, at velocity 112 on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      player.noteOn(1, 64, 112); // Play The Note 64, at velocity 112 on channel 1
      player.noteOn(2, 28, 104); // Play The Note 28, at velocity 104 on channel 2
      player.noteOn(9, 38, 116); // Play The Note 38, at velocity 116 on channel 9
      player.noteOn(9, 36, 99); // Play The Note 36, at velocity 99 on channel 9
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 38); // Turn off Note 38, on channel 9
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 67); // Turn off Note 67, on channel 0
      player.noteOn(0, 71, 105); // Play The Note 71, at velocity 105 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 67, 105); // Play The Note 67, at velocity 105 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 71); // Turn off Note 71, on channel 0
      player.noteOn(0, 64, 112); // Play The Note 64, at velocity 112 on channel 0
      player.noteOff(2, 28); // Turn off Note 28, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      player.noteOn(1, 59, 112); // Play The Note 59, at velocity 112 on channel 1
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 59, 103); // Play The Note 59, at velocity 103 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 59); // Turn off Note 59, on channel 1
      player.noteOn(1, 55, 103); // Play The Note 55, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 59); // Turn off Note 59, on channel 0
      player.noteOn(0, 67, 111); // Play The Note 67, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      player.noteOn(1, 64, 111); // Play The Note 64, at velocity 111 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(0, 67); // Turn off Note 67, on channel 0
      player.noteOn(0, 64, 102); // Play The Note 64, at velocity 102 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 59, 102); // Play The Note 59, at velocity 102 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 71, 113); // Play The Note 71, at velocity 113 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 59); // Turn off Note 59, on channel 1
      player.noteOn(1, 67, 113); // Play The Note 67, at velocity 113 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(0, 71); // Turn off Note 71, on channel 0
      player.noteOn(0, 67, 103); // Play The Note 67, at velocity 103 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      player.noteOn(1, 64, 103); // Play The Note 64, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 67); // Turn off Note 67, on channel 0
      player.noteOn(0, 71, 111); // Play The Note 71, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 67, 111); // Play The Note 67, at velocity 111 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 71); // Turn off Note 71, on channel 0
      player.noteOn(0, 67, 101); // Play The Note 67, at velocity 101 on channel 0
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      player.noteOn(1, 64, 101); // Play The Note 64, at velocity 101 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 67); // Turn off Note 67, on channel 0
      player.noteOn(0, 64, 112); // Play The Note 64, at velocity 112 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 59, 112); // Play The Note 59, at velocity 112 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 59, 103); // Play The Note 59, at velocity 103 on channel 0
      player.noteOff(1, 59); // Turn off Note 59, on channel 1
      player.noteOn(1, 55, 103); // Play The Note 55, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 59); // Turn off Note 59, on channel 0
      player.noteOn(0, 67, 110); // Play The Note 67, at velocity 110 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      player.noteOn(1, 64, 110); // Play The Note 64, at velocity 110 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 67); // Turn off Note 67, on channel 0
      player.noteOn(0, 71, 100); // Play The Note 71, at velocity 100 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 67, 100); // Play The Note 67, at velocity 100 on channel 1
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(0, 71); // Turn off Note 71, on channel 0
      player.noteOn(0, 76, 113); // Play The Note 76, at velocity 113 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      player.noteOn(1, 71, 113); // Play The Note 71, at velocity 113 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 76); // Turn off Note 76, on channel 0
      player.noteOn(0, 79, 103); // Play The Note 79, at velocity 103 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 71); // Turn off Note 71, on channel 1
      player.noteOn(1, 76, 103); // Play The Note 76, at velocity 103 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(0, 79); // Turn off Note 79, on channel 0
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(2, 40, 122); // Play The Note 40, at velocity 122 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      player.noteOn(9, 41, 123); // Play The Note 41, at velocity 123 on channel 9
      player.noteOn(9, 57, 61); // Play The Note 57, at velocity 61 on channel 9
      player.noteOn(9, 49, 71); // Play The Note 49, at velocity 71 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 76); // Turn off Note 76, on channel 1
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(9, 57, 23); // Play The Note 57, at velocity 23 on channel 9
      player.noteOn(9, 49, 23); // Play The Note 49, at velocity 23 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOn(0, 52, 114); // Play The Note 52, at velocity 114 on channel 0
      player.noteOn(1, 52, 114); // Play The Note 52, at velocity 114 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 50, 111); // Play The Note 50, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 50, 111); // Play The Note 50, at velocity 111 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(100); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 104); // Play The Note 40, at velocity 104 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 104); // Play The Note 40, at velocity 104 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 48, 116); // Play The Note 48, at velocity 116 on channel 0
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 48, 116); // Play The Note 48, at velocity 116 on channel 1
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(116); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 46, 110); // Play The Note 46, at velocity 110 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 46, 110); // Play The Note 46, at velocity 110 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(112); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(0, 47, 110); // Play The Note 47, at velocity 110 on channel 0
      player.noteOn(1, 47, 110); // Play The Note 47, at velocity 110 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 48, 117); // Play The Note 48, at velocity 117 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 48, 117); // Play The Note 48, at velocity 117 on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(2, 40, 125); // Play The Note 40, at velocity 125 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 41, 123); // Play The Note 41, at velocity 123 on channel 9
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      player.noteOn(9, 57, 64); // Play The Note 57, at velocity 64 on channel 9
      player.noteOn(9, 49, 70); // Play The Note 49, at velocity 70 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOn(9, 57, 23); // Play The Note 57, at velocity 23 on channel 9
      player.noteOn(9, 49, 23); // Play The Note 49, at velocity 23 on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 52, 114); // Play The Note 52, at velocity 114 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 52, 114); // Play The Note 52, at velocity 114 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 50, 106); // Play The Note 50, at velocity 106 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 50, 106); // Play The Note 50, at velocity 106 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(129); // Wait For The Next Note
      player.noteOn(0, 48, 117); // Play The Note 48, at velocity 117 on channel 0
      player.noteOn(1, 48, 117); // Play The Note 48, at velocity 117 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(95); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 46, 114); // Play The Note 46, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 46, 114); // Play The Note 46, at velocity 114 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.pitchBend(0, -256); // Change The Pitch Offset On Channel 0 To -256
      player.pitchBend(1, -256); // Change The Pitch Offset On Channel 1 To -256
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1792); // Change The Pitch Offset On Channel 0 To 1792
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 256); // Change The Pitch Offset On Channel 0 To 256
      player.pitchBend(1, 256); // Change The Pitch Offset On Channel 1 To 256
      Thread.Sleep(66); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 640); // Change The Pitch Offset On Channel 0 To 640
      player.pitchBend(1, 640); // Change The Pitch Offset On Channel 1 To 640
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 2048); // Change The Pitch Offset On Channel 0 To 2048
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(75); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 2048); // Change The Pitch Offset On Channel 0 To 2048
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1792); // Change The Pitch Offset On Channel 0 To 1792
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(20); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      player.noteOn(2, 40, 125); // Play The Note 40, at velocity 125 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      player.noteOn(9, 41, 123); // Play The Note 41, at velocity 123 on channel 9
      player.noteOn(9, 49, 74); // Play The Note 49, at velocity 74 on channel 9
      player.noteOn(9, 57, 56); // Play The Note 57, at velocity 56 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 40, 107); // Play The Note 40, at velocity 107 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 107); // Play The Note 40, at velocity 107 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOn(9, 49, 23); // Play The Note 49, at velocity 23 on channel 9
      player.noteOn(9, 57, 23); // Play The Note 57, at velocity 23 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 52, 113); // Play The Note 52, at velocity 113 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 52, 113); // Play The Note 52, at velocity 113 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 105); // Play The Note 40, at velocity 105 on channel 0
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      player.noteOn(1, 40, 105); // Play The Note 40, at velocity 105 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(0, 50, 110); // Play The Note 50, at velocity 110 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 48, 118); // Play The Note 48, at velocity 118 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 48, 118); // Play The Note 48, at velocity 118 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(116); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 46, 115); // Play The Note 46, at velocity 115 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 46, 115); // Play The Note 46, at velocity 115 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(116); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(129); // Wait For The Next Note
      player.noteOn(0, 47, 110); // Play The Note 47, at velocity 110 on channel 0
      player.noteOn(1, 47, 110); // Play The Note 47, at velocity 110 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 48, 111); // Play The Note 48, at velocity 111 on channel 0
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 48, 111); // Play The Note 48, at velocity 111 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOff(1, 48); // Turn off Note 48, on channel 1
      player.noteOn(2, 40, 116); // Play The Note 40, at velocity 116 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 41, 123); // Play The Note 41, at velocity 123 on channel 9
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      player.noteOn(9, 49, 74); // Play The Note 49, at velocity 74 on channel 9
      player.noteOn(9, 57, 68); // Play The Note 57, at velocity 68 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(9, 49, 23); // Play The Note 49, at velocity 23 on channel 9
      player.noteOn(9, 57, 23); // Play The Note 57, at velocity 23 on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 52, 117); // Play The Note 52, at velocity 117 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 52, 117); // Play The Note 52, at velocity 117 on channel 1
      Thread.Sleep(87); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 50, 110); // Play The Note 50, at velocity 110 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 115); // Play The Note 40, at velocity 115 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 115); // Play The Note 40, at velocity 115 on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(0, 66, 112); // Play The Note 66, at velocity 112 on channel 0
      player.noteOn(9, 41, 91); // Play The Note 41, at velocity 91 on channel 9
      player.noteOn(9, 40, 90); // Play The Note 40, at velocity 90 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 63, 112); // Play The Note 63, at velocity 112 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 66); // Turn off Note 66, on channel 0
      player.noteOn(0, 64, 105); // Play The Note 64, at velocity 105 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 63); // Turn off Note 63, on channel 1
      player.noteOn(1, 60, 105); // Play The Note 60, at velocity 105 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 63, 112); // Play The Note 63, at velocity 112 on channel 0
      player.noteOff(1, 60); // Turn off Note 60, on channel 1
      player.noteOn(1, 59, 112); // Play The Note 59, at velocity 112 on channel 1
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 63); // Turn off Note 63, on channel 0
      player.noteOn(0, 59, 103); // Play The Note 59, at velocity 103 on channel 0
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 59); // Turn off Note 59, on channel 1
      player.noteOn(1, 54, 103); // Play The Note 54, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 59); // Turn off Note 59, on channel 0
      player.noteOn(0, 69, 111); // Play The Note 69, at velocity 111 on channel 0
      player.noteOff(1, 54); // Turn off Note 54, on channel 1
      player.noteOn(1, 66, 111); // Play The Note 66, at velocity 111 on channel 1
      player.noteOn(9, 40, 88); // Play The Note 40, at velocity 88 on channel 9
      player.noteOn(9, 41, 90); // Play The Note 41, at velocity 90 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 69); // Turn off Note 69, on channel 0
      player.noteOn(0, 66, 102); // Play The Note 66, at velocity 102 on channel 0
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 66); // Turn off Note 66, on channel 1
      player.noteOn(1, 63, 102); // Play The Note 63, at velocity 102 on channel 1
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 66); // Turn off Note 66, on channel 0
      player.noteOn(0, 63, 113); // Play The Note 63, at velocity 113 on channel 0
      player.noteOn(9, 36, 88); // Play The Note 36, at velocity 88 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 63); // Turn off Note 63, on channel 1
      player.noteOn(1, 59, 113); // Play The Note 59, at velocity 113 on channel 1
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(0, 63); // Turn off Note 63, on channel 0
      player.noteOn(0, 59, 103); // Play The Note 59, at velocity 103 on channel 0
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 59); // Turn off Note 59, on channel 1
      player.noteOn(1, 57, 103); // Play The Note 57, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 59); // Turn off Note 59, on channel 0
      player.noteOn(0, 71, 111); // Play The Note 71, at velocity 111 on channel 0
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      player.noteOn(9, 41, 88); // Play The Note 41, at velocity 88 on channel 9
      player.noteOn(9, 40, 88); // Play The Note 40, at velocity 88 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 57); // Turn off Note 57, on channel 1
      player.noteOn(1, 69, 111); // Play The Note 69, at velocity 111 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 71); // Turn off Note 71, on channel 0
      player.noteOn(0, 69, 101); // Play The Note 69, at velocity 101 on channel 0
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 69); // Turn off Note 69, on channel 1
      player.noteOn(1, 66, 101); // Play The Note 66, at velocity 101 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 69); // Turn off Note 69, on channel 0
      player.noteOn(0, 66, 112); // Play The Note 66, at velocity 112 on channel 0
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      player.noteOn(9, 40, 82); // Play The Note 40, at velocity 82 on channel 9
      player.noteOn(9, 41, 87); // Play The Note 41, at velocity 87 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 66); // Turn off Note 66, on channel 1
      player.noteOn(1, 63, 112); // Play The Note 63, at velocity 112 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(0, 66); // Turn off Note 66, on channel 0
      player.noteOn(0, 63, 103); // Play The Note 63, at velocity 103 on channel 0
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 63); // Turn off Note 63, on channel 1
      player.noteOn(1, 59, 103); // Play The Note 59, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 63); // Turn off Note 63, on channel 0
      player.noteOn(0, 75, 110); // Play The Note 75, at velocity 110 on channel 0
      player.noteOn(9, 36, 91); // Play The Note 36, at velocity 91 on channel 9
      player.noteOn(9, 40, 91); // Play The Note 40, at velocity 91 on channel 9
      player.noteOn(9, 41, 93); // Play The Note 41, at velocity 93 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 59); // Turn off Note 59, on channel 1
      player.noteOn(1, 71, 110); // Play The Note 71, at velocity 110 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 75); // Turn off Note 75, on channel 0
      player.noteOn(0, 73, 100); // Play The Note 73, at velocity 100 on channel 0
      player.noteOff(1, 71); // Turn off Note 71, on channel 1
      player.noteOn(1, 69, 100); // Play The Note 69, at velocity 100 on channel 1
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 73); // Turn off Note 73, on channel 0
      player.noteOn(0, 71, 113); // Play The Note 71, at velocity 113 on channel 0
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      player.noteOn(9, 41, 93); // Play The Note 41, at velocity 93 on channel 9
      player.noteOn(9, 40, 90); // Play The Note 40, at velocity 90 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 69); // Turn off Note 69, on channel 1
      player.noteOn(1, 66, 113); // Play The Note 66, at velocity 113 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 71); // Turn off Note 71, on channel 0
      player.noteOn(0, 69, 103); // Play The Note 69, at velocity 103 on channel 0
      player.noteOff(1, 66); // Turn off Note 66, on channel 1
      player.noteOn(1, 63, 103); // Play The Note 63, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 69); // Turn off Note 69, on channel 0
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 36, 118); // Play The Note 36, at velocity 118 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 63); // Turn off Note 63, on channel 1
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 52, 114); // Play The Note 52, at velocity 114 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 118); // Play The Note 40, at velocity 118 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 55, 114); // Play The Note 55, at velocity 114 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 85); // Play The Note 46, at velocity 85 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(87); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(9, 46, 81); // Play The Note 46, at velocity 81 on channel 9
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 50, 111); // Play The Note 50, at velocity 111 on channel 0
      player.noteOn(1, 54, 111); // Play The Note 54, at velocity 111 on channel 1
      player.noteOn(9, 36, 118); // Play The Note 36, at velocity 118 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 54); // Turn off Note 54, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 104); // Play The Note 40, at velocity 104 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 104); // Play The Note 40, at velocity 104 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(9, 46, 81); // Play The Note 46, at velocity 81 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 48, 116); // Play The Note 48, at velocity 116 on channel 0
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 51, 116); // Play The Note 51, at velocity 116 on channel 1
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOff(1, 51); // Turn off Note 51, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 117); // Play The Note 40, at velocity 117 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 46, 110); // Play The Note 46, at velocity 110 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(120); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(9, 36, 121); // Play The Note 36, at velocity 121 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(0, 47, 110); // Play The Note 47, at velocity 110 on channel 0
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(9, 46, 78); // Play The Note 46, at velocity 78 on channel 9
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 48, 117); // Play The Note 48, at velocity 117 on channel 0
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 52, 117); // Play The Note 52, at velocity 117 on channel 1
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 52, 114); // Play The Note 52, at velocity 114 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 55, 114); // Play The Note 55, at velocity 114 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 50, 106); // Play The Note 50, at velocity 106 on channel 0
      player.noteOn(9, 36, 117); // Play The Note 36, at velocity 117 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 54, 106); // Play The Note 54, at velocity 106 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 54); // Turn off Note 54, on channel 1
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 48, 117); // Play The Note 48, at velocity 117 on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 52, 117); // Play The Note 52, at velocity 117 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 117); // Play The Note 40, at velocity 117 on channel 9
      player.noteOn(9, 46, 69); // Play The Note 46, at velocity 69 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 46, 114); // Play The Note 46, at velocity 114 on channel 0
      player.noteOn(1, 49, 114); // Play The Note 49, at velocity 114 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.pitchBend(0, -256); // Change The Pitch Offset On Channel 0 To -256
      player.pitchBend(1, -256); // Change The Pitch Offset On Channel 1 To -256
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, -384); // Change The Pitch Offset On Channel 0 To -384
      player.pitchBend(1, -384); // Change The Pitch Offset On Channel 1 To -384
      Thread.Sleep(16); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 46, 73); // Play The Note 46, at velocity 73 on channel 9
      player.noteOn(9, 36, 121); // Play The Note 36, at velocity 121 on channel 9
      Thread.Sleep(54); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(16); // Wait For The Next Note
      player.pitchBend(0, 2048); // Change The Pitch Offset On Channel 0 To 2048
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(79); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 2048); // Change The Pitch Offset On Channel 0 To 2048
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      player.noteOn(2, 40, 71); // Play The Note 40, at velocity 71 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1792); // Change The Pitch Offset On Channel 0 To 1792
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 640); // Change The Pitch Offset On Channel 0 To 640
      player.pitchBend(1, 640); // Change The Pitch Offset On Channel 1 To 640
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      player.noteOn(2, 40, 77); // Play The Note 40, at velocity 77 on channel 2
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 107); // Play The Note 40, at velocity 107 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 107); // Play The Note 40, at velocity 107 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 52, 113); // Play The Note 52, at velocity 113 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 46, 69); // Play The Note 46, at velocity 69 on channel 9
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 55, 113); // Play The Note 55, at velocity 113 on channel 1
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      player.noteOn(0, 40, 105); // Play The Note 40, at velocity 105 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      player.noteOn(1, 40, 105); // Play The Note 40, at velocity 105 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 46, 79); // Play The Note 46, at velocity 79 on channel 9
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 50, 110); // Play The Note 50, at velocity 110 on channel 0
      player.noteOn(1, 54, 110); // Play The Note 54, at velocity 110 on channel 1
      player.noteOn(9, 36, 115); // Play The Note 36, at velocity 115 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 54); // Turn off Note 54, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 48, 118); // Play The Note 48, at velocity 118 on channel 0
      player.noteOn(2, 40, 98); // Play The Note 40, at velocity 98 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 51, 118); // Play The Note 51, at velocity 118 on channel 1
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      player.noteOff(1, 51); // Turn off Note 51, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 46, 115); // Play The Note 46, at velocity 115 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 50, 115); // Play The Note 50, at velocity 115 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(116); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 47, 110); // Play The Note 47, at velocity 110 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      player.noteOn(0, 48, 111); // Play The Note 48, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 52, 111); // Play The Note 52, at velocity 111 on channel 1
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(9, 46, 73); // Play The Note 46, at velocity 73 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 52, 117); // Play The Note 52, at velocity 117 on channel 0
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 55, 117); // Play The Note 55, at velocity 117 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(0, 50, 110); // Play The Note 50, at velocity 110 on channel 0
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 54, 110); // Play The Note 54, at velocity 110 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOn(2, 40, 98); // Play The Note 40, at velocity 98 on channel 2
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 54); // Turn off Note 54, on channel 1
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      player.noteOn(9, 46, 73); // Play The Note 46, at velocity 73 on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 115); // Play The Note 40, at velocity 115 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 115); // Play The Note 40, at velocity 115 on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(0, 79, 103); // Play The Note 79, at velocity 103 on channel 0
      player.noteOn(2, 40, 104); // Play The Note 40, at velocity 104 on channel 2
      player.noteOn(9, 36, 82); // Play The Note 36, at velocity 82 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 76, 103); // Play The Note 76, at velocity 103 on channel 1
      player.noteOn(9, 50, 91); // Play The Note 50, at velocity 91 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 40, 82); // Play The Note 40, at velocity 82 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 50); // Turn off Note 50, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 79); // Turn off Note 79, on channel 0
      player.noteOn(0, 76, 113); // Play The Note 76, at velocity 113 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 76); // Turn off Note 76, on channel 1
      player.noteOn(1, 71, 113); // Play The Note 71, at velocity 113 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 76); // Turn off Note 76, on channel 0
      player.noteOn(0, 71, 100); // Play The Note 71, at velocity 100 on channel 0
      player.noteOn(9, 36, 92); // Play The Note 36, at velocity 92 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 71); // Turn off Note 71, on channel 1
      player.noteOn(1, 67, 100); // Play The Note 67, at velocity 100 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 71); // Turn off Note 71, on channel 0
      player.noteOn(0, 67, 110); // Play The Note 67, at velocity 110 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      player.noteOn(1, 64, 110); // Play The Note 64, at velocity 110 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(0, 67); // Turn off Note 67, on channel 0
      player.noteOn(0, 76, 103); // Play The Note 76, at velocity 103 on channel 0
      player.noteOn(2, 40, 98); // Play The Note 40, at velocity 98 on channel 2
      player.noteOn(9, 36, 92); // Play The Note 36, at velocity 92 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 71, 103); // Play The Note 71, at velocity 103 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(9, 40, 85); // Play The Note 40, at velocity 85 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 47, 85); // Play The Note 47, at velocity 85 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 47); // Turn off Note 47, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 76); // Turn off Note 76, on channel 0
      player.noteOn(0, 79, 112); // Play The Note 79, at velocity 112 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 71); // Turn off Note 71, on channel 1
      player.noteOn(1, 76, 112); // Play The Note 76, at velocity 112 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 79); // Turn off Note 79, on channel 0
      player.noteOn(0, 76, 101); // Play The Note 76, at velocity 101 on channel 0
      player.noteOff(1, 76); // Turn off Note 76, on channel 1
      player.noteOn(1, 71, 101); // Play The Note 71, at velocity 101 on channel 1
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 76); // Turn off Note 76, on channel 0
      player.noteOn(0, 71, 111); // Play The Note 71, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 71); // Turn off Note 71, on channel 1
      player.noteOn(1, 67, 111); // Play The Note 67, at velocity 111 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 71); // Turn off Note 71, on channel 0
      player.noteOn(0, 67, 103); // Play The Note 67, at velocity 103 on channel 0
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      player.noteOn(1, 64, 103); // Play The Note 64, at velocity 103 on channel 1
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 36, 87); // Play The Note 36, at velocity 87 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 45, 93); // Play The Note 45, at velocity 93 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 40, 91); // Play The Note 40, at velocity 91 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 67); // Turn off Note 67, on channel 0
      player.noteOn(0, 71, 113); // Play The Note 71, at velocity 113 on channel 0
      player.noteOff(9, 45); // Turn off Note 45, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 67, 113); // Play The Note 67, at velocity 113 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 71); // Turn off Note 71, on channel 0
      player.noteOn(0, 76, 102); // Play The Note 76, at velocity 102 on channel 0
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      player.noteOn(1, 71, 102); // Play The Note 71, at velocity 102 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 76); // Turn off Note 76, on channel 0
      player.noteOn(0, 71, 111); // Play The Note 71, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 71); // Turn off Note 71, on channel 1
      player.noteOn(1, 67, 111); // Play The Note 67, at velocity 111 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 71); // Turn off Note 71, on channel 0
      player.noteOn(0, 79, 103); // Play The Note 79, at velocity 103 on channel 0
      player.noteOn(2, 40, 104); // Play The Note 40, at velocity 104 on channel 2
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      player.noteOn(1, 76, 103); // Play The Note 76, at velocity 103 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(9, 40, 90); // Play The Note 40, at velocity 90 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 41, 73); // Play The Note 41, at velocity 73 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 79); // Turn off Note 79, on channel 0
      player.noteOn(0, 76, 112); // Play The Note 76, at velocity 112 on channel 0
      player.noteOff(9, 41); // Turn off Note 41, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 76); // Turn off Note 76, on channel 1
      player.noteOn(1, 71, 112); // Play The Note 71, at velocity 112 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 76); // Turn off Note 76, on channel 0
      player.noteOn(0, 71, 105); // Play The Note 71, at velocity 105 on channel 0
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 71); // Turn off Note 71, on channel 1
      player.noteOn(1, 67, 105); // Play The Note 67, at velocity 105 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 71); // Turn off Note 71, on channel 0
      player.noteOn(0, 67, 112); // Play The Note 67, at velocity 112 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      player.noteOn(1, 64, 112); // Play The Note 64, at velocity 112 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 67); // Turn off Note 67, on channel 0
      player.noteOn(0, 45, 108); // Play The Note 45, at velocity 108 on channel 0
      player.noteOn(2, 33, 86); // Play The Note 33, at velocity 86 on channel 2
      player.noteOn(9, 36, 118); // Play The Note 36, at velocity 118 on channel 9
      player.noteOn(9, 51, 112); // Play The Note 51, at velocity 112 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 45, 108); // Play The Note 45, at velocity 108 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 45, 114); // Play The Note 45, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 114); // Play The Note 45, at velocity 114 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 57, 114); // Play The Note 57, at velocity 114 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 40, 118); // Play The Note 40, at velocity 118 on channel 9
      player.noteOn(9, 51, 116); // Play The Note 51, at velocity 116 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 60, 114); // Play The Note 60, at velocity 114 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 57); // Turn off Note 57, on channel 0
      player.noteOn(0, 45, 110); // Play The Note 45, at velocity 110 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 60); // Turn off Note 60, on channel 1
      player.noteOn(1, 45, 110); // Play The Note 45, at velocity 110 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 45, 110); // Play The Note 45, at velocity 110 on channel 0
      player.noteOn(2, 33, 86); // Play The Note 33, at velocity 86 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 51, 116); // Play The Note 51, at velocity 116 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 110); // Play The Note 45, at velocity 110 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 55, 111); // Play The Note 55, at velocity 111 on channel 0
      player.noteOn(9, 36, 118); // Play The Note 36, at velocity 118 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 59, 111); // Play The Note 59, at velocity 111 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 55); // Turn off Note 55, on channel 0
      player.noteOff(1, 59); // Turn off Note 59, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 45, 104); // Play The Note 45, at velocity 104 on channel 0
      player.noteOn(1, 45, 104); // Play The Note 45, at velocity 104 on channel 1
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      player.noteOn(9, 51, 110); // Play The Note 51, at velocity 110 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(0, 53, 116); // Play The Note 53, at velocity 116 on channel 0
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.noteOn(2, 33, 89); // Play The Note 33, at velocity 89 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 51, 117); // Play The Note 51, at velocity 117 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 56, 116); // Play The Note 56, at velocity 116 on channel 1
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 53); // Turn off Note 53, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 45, 108); // Play The Note 45, at velocity 108 on channel 0
      player.noteOff(1, 56); // Turn off Note 56, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 108); // Play The Note 45, at velocity 108 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 45, 110); // Play The Note 45, at velocity 110 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 40, 117); // Play The Note 40, at velocity 117 on channel 9
      player.noteOn(9, 51, 119); // Play The Note 51, at velocity 119 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 110); // Play The Note 45, at velocity 110 on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 51, 110); // Play The Note 51, at velocity 110 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.noteOn(1, 55, 110); // Play The Note 55, at velocity 110 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(112); // Wait For The Next Note
      player.noteOff(0, 51); // Turn off Note 51, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 45, 110); // Play The Note 45, at velocity 110 on channel 0
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      player.noteOn(2, 33, 83); // Play The Note 33, at velocity 83 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 51, 111); // Play The Note 51, at velocity 111 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 110); // Play The Note 45, at velocity 110 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      player.noteOn(9, 36, 121); // Play The Note 36, at velocity 121 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(0, 52, 110); // Play The Note 52, at velocity 110 on channel 0
      player.noteOn(2, 33, 83); // Play The Note 33, at velocity 83 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 51, 111); // Play The Note 51, at velocity 111 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 55, 110); // Play The Note 55, at velocity 110 on channel 1
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      player.noteOn(0, 53, 117); // Play The Note 53, at velocity 117 on channel 0
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 57, 117); // Play The Note 57, at velocity 117 on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 53); // Turn off Note 53, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 57); // Turn off Note 57, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 51, 108); // Play The Note 51, at velocity 108 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(0, 57, 114); // Play The Note 57, at velocity 114 on channel 0
      player.noteOn(1, 60, 114); // Play The Note 60, at velocity 114 on channel 1
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      player.noteOn(9, 51, 111); // Play The Note 51, at velocity 111 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 57); // Turn off Note 57, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 60); // Turn off Note 60, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 45, 106); // Play The Note 45, at velocity 106 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 106); // Play The Note 45, at velocity 106 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 45, 108); // Play The Note 45, at velocity 108 on channel 0
      player.noteOn(2, 33, 89); // Play The Note 33, at velocity 89 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 51, 101); // Play The Note 51, at velocity 101 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 108); // Play The Note 45, at velocity 108 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOn(0, 55, 106); // Play The Note 55, at velocity 106 on channel 0
      player.noteOn(9, 36, 117); // Play The Note 36, at velocity 117 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 59, 106); // Play The Note 59, at velocity 106 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(0, 55); // Turn off Note 55, on channel 0
      player.noteOn(0, 45, 114); // Play The Note 45, at velocity 114 on channel 0
      player.noteOff(1, 59); // Turn off Note 59, on channel 1
      player.noteOn(2, 33, 83); // Play The Note 33, at velocity 83 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 51, 112); // Play The Note 51, at velocity 112 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 114); // Play The Note 45, at velocity 114 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 45, 106); // Play The Note 45, at velocity 106 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 106); // Play The Note 45, at velocity 106 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 53, 117); // Play The Note 53, at velocity 117 on channel 0
      player.noteOn(2, 33, 89); // Play The Note 33, at velocity 89 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 51, 105); // Play The Note 51, at velocity 105 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.noteOn(1, 57, 117); // Play The Note 57, at velocity 117 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 53); // Turn off Note 53, on channel 0
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 57); // Turn off Note 57, on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOn(0, 45, 114); // Play The Note 45, at velocity 114 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 40, 117); // Play The Note 40, at velocity 117 on channel 9
      player.noteOn(9, 51, 108); // Play The Note 51, at velocity 108 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 114); // Play The Note 45, at velocity 114 on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 51, 114); // Play The Note 51, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 55, 114); // Play The Note 55, at velocity 114 on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.pitchBend(0, -256); // Change The Pitch Offset On Channel 0 To -256
      player.pitchBend(1, -256); // Change The Pitch Offset On Channel 1 To -256
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, -384); // Change The Pitch Offset On Channel 0 To -384
      player.pitchBend(1, -384); // Change The Pitch Offset On Channel 1 To -384
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(2, 33, 86); // Play The Note 33, at velocity 86 on channel 2
      player.noteOn(9, 36, 121); // Play The Note 36, at velocity 121 on channel 9
      player.noteOn(9, 51, 117); // Play The Note 51, at velocity 117 on channel 9
      Thread.Sleep(58); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 2048); // Change The Pitch Offset On Channel 0 To 2048
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(75); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      player.noteOn(2, 33, 71); // Play The Note 33, at velocity 71 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 51, 108); // Play The Note 51, at velocity 108 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1792); // Change The Pitch Offset On Channel 0 To 1792
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(16); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 640); // Change The Pitch Offset On Channel 0 To 640
      player.pitchBend(1, 640); // Change The Pitch Offset On Channel 1 To 640
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.noteOn(0, 45, 108); // Play The Note 45, at velocity 108 on channel 0
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      player.noteOn(2, 33, 77); // Play The Note 33, at velocity 77 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 51, 107); // Play The Note 51, at velocity 107 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOn(1, 45, 108); // Play The Note 45, at velocity 108 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 51); // Turn off Note 51, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 45, 107); // Play The Note 45, at velocity 107 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 107); // Play The Note 45, at velocity 107 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 57, 113); // Play The Note 57, at velocity 113 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      player.noteOn(9, 51, 115); // Play The Note 51, at velocity 115 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 60, 113); // Play The Note 60, at velocity 113 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 57); // Turn off Note 57, on channel 0
      player.noteOn(0, 45, 105); // Play The Note 45, at velocity 105 on channel 0
      player.noteOff(1, 60); // Turn off Note 60, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 105); // Play The Note 45, at velocity 105 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 51, 107); // Play The Note 51, at velocity 107 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 55, 110); // Play The Note 55, at velocity 110 on channel 0
      player.noteOn(9, 36, 115); // Play The Note 36, at velocity 115 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 59, 110); // Play The Note 59, at velocity 110 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      player.noteOn(2, 33, 89); // Play The Note 33, at velocity 89 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      player.noteOn(9, 51, 114); // Play The Note 51, at velocity 114 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 55); // Turn off Note 55, on channel 0
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      player.noteOff(1, 59); // Turn off Note 59, on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 45, 114); // Play The Note 45, at velocity 114 on channel 0
      player.noteOn(1, 45, 114); // Play The Note 45, at velocity 114 on channel 1
      Thread.Sleep(133); // Wait For The Next Note
      player.noteOn(0, 53, 118); // Play The Note 53, at velocity 118 on channel 0
      player.noteOn(1, 56, 118); // Play The Note 56, at velocity 118 on channel 1
      player.noteOn(2, 33, 98); // Play The Note 33, at velocity 98 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 51, 110); // Play The Note 51, at velocity 110 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 53); // Turn off Note 53, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 45, 106); // Play The Note 45, at velocity 106 on channel 0
      player.noteOff(1, 56); // Turn off Note 56, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 106); // Play The Note 45, at velocity 106 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 45, 108); // Play The Note 45, at velocity 108 on channel 0
      player.noteOn(2, 33, 89); // Play The Note 33, at velocity 89 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 51, 119); // Play The Note 51, at velocity 119 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 108); // Play The Note 45, at velocity 108 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 51, 115); // Play The Note 51, at velocity 115 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.noteOn(1, 55, 115); // Play The Note 55, at velocity 115 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(120); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      player.noteOn(2, 33, 86); // Play The Note 33, at velocity 86 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 51, 110); // Play The Note 51, at velocity 110 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 51); // Turn off Note 51, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 52, 110); // Play The Note 52, at velocity 110 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 51, 110); // Play The Note 51, at velocity 110 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 55, 110); // Play The Note 55, at velocity 110 on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      player.noteOn(0, 53, 111); // Play The Note 53, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      player.noteOn(1, 57, 111); // Play The Note 57, at velocity 111 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(0, 53); // Turn off Note 53, on channel 0
      player.noteOn(0, 45, 110); // Play The Note 45, at velocity 110 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 51, 119); // Play The Note 51, at velocity 119 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 57); // Turn off Note 57, on channel 1
      player.noteOn(1, 45, 110); // Play The Note 45, at velocity 110 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 45, 108); // Play The Note 45, at velocity 108 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 45, 108); // Play The Note 45, at velocity 108 on channel 1
      Thread.Sleep(129); // Wait For The Next Note
      player.noteOn(0, 57, 117); // Play The Note 57, at velocity 117 on channel 0
      player.noteOn(1, 60, 117); // Play The Note 60, at velocity 117 on channel 1
      player.noteOn(2, 33, 83); // Play The Note 33, at velocity 83 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      player.noteOn(9, 51, 115); // Play The Note 51, at velocity 115 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 45, 111); // Play The Note 45, at velocity 111 on channel 0
      player.noteOn(1, 45, 111); // Play The Note 45, at velocity 111 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 57); // Turn off Note 57, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 60); // Turn off Note 60, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 45, 108); // Play The Note 45, at velocity 108 on channel 0
      player.noteOn(2, 33, 89); // Play The Note 33, at velocity 89 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 51, 119); // Play The Note 51, at velocity 119 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 108); // Play The Note 45, at velocity 108 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 55, 110); // Play The Note 55, at velocity 110 on channel 0
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 59, 110); // Play The Note 59, at velocity 110 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 55); // Turn off Note 55, on channel 0
      player.noteOn(0, 45, 114); // Play The Note 45, at velocity 114 on channel 0
      player.noteOn(2, 33, 98); // Play The Note 33, at velocity 98 on channel 2
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      player.noteOn(9, 51, 117); // Play The Note 51, at velocity 117 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 59); // Turn off Note 59, on channel 1
      player.noteOn(1, 45, 114); // Play The Note 45, at velocity 114 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 45, 115); // Play The Note 45, at velocity 115 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 115); // Play The Note 45, at velocity 115 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOn(0, 69, 112); // Play The Note 69, at velocity 112 on channel 0
      player.noteOn(2, 33, 104); // Play The Note 33, at velocity 104 on channel 2
      player.noteOn(9, 51, 113); // Play The Note 51, at velocity 113 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 64, 112); // Play The Note 64, at velocity 112 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 40, 82); // Play The Note 40, at velocity 82 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 69); // Turn off Note 69, on channel 0
      player.noteOn(0, 65, 105); // Play The Note 65, at velocity 105 on channel 0
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 62, 105); // Play The Note 62, at velocity 105 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 51); // Turn off Note 51, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 65); // Turn off Note 65, on channel 0
      player.noteOn(0, 64, 112); // Play The Note 64, at velocity 112 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 62); // Turn off Note 62, on channel 1
      player.noteOn(1, 60, 112); // Play The Note 60, at velocity 112 on channel 1
      player.noteOn(9, 36, 79); // Play The Note 36, at velocity 79 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 69, 103); // Play The Note 69, at velocity 103 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 60); // Turn off Note 60, on channel 1
      player.noteOn(1, 64, 103); // Play The Note 64, at velocity 103 on channel 1
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(0, 69); // Turn off Note 69, on channel 0
      player.noteOn(0, 64, 111); // Play The Note 64, at velocity 111 on channel 0
      player.noteOn(2, 33, 98); // Play The Note 33, at velocity 98 on channel 2
      player.noteOn(9, 40, 93); // Play The Note 40, at velocity 93 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 60, 111); // Play The Note 60, at velocity 111 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 60, 102); // Play The Note 60, at velocity 102 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 60); // Turn off Note 60, on channel 1
      player.noteOn(1, 57, 102); // Play The Note 57, at velocity 102 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 60); // Turn off Note 60, on channel 0
      player.noteOn(0, 64, 113); // Play The Note 64, at velocity 113 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 57); // Turn off Note 57, on channel 1
      player.noteOn(1, 60, 113); // Play The Note 60, at velocity 113 on channel 1
      player.noteOn(9, 36, 88); // Play The Note 36, at velocity 88 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 69, 103); // Play The Note 69, at velocity 103 on channel 0
      player.noteOn(9, 36, 86); // Play The Note 36, at velocity 86 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 60); // Turn off Note 60, on channel 1
      player.noteOn(1, 64, 103); // Play The Note 64, at velocity 103 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 69); // Turn off Note 69, on channel 0
      player.noteOn(0, 72, 111); // Play The Note 72, at velocity 111 on channel 0
      player.noteOn(2, 33, 92); // Play The Note 33, at velocity 92 on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 69, 111); // Play The Note 69, at velocity 111 on channel 1
      player.noteOn(9, 40, 93); // Play The Note 40, at velocity 93 on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 72); // Turn off Note 72, on channel 0
      player.noteOn(0, 69, 101); // Play The Note 69, at velocity 101 on channel 0
      player.noteOn(9, 40, 87); // Play The Note 40, at velocity 87 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 69); // Turn off Note 69, on channel 1
      player.noteOn(1, 64, 101); // Play The Note 64, at velocity 101 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 69); // Turn off Note 69, on channel 0
      player.noteOn(0, 64, 112); // Play The Note 64, at velocity 112 on channel 0
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 60, 112); // Play The Note 60, at velocity 112 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 36, 86); // Play The Note 36, at velocity 86 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 69, 103); // Play The Note 69, at velocity 103 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 60); // Turn off Note 60, on channel 1
      player.noteOn(1, 64, 103); // Play The Note 64, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 69); // Turn off Note 69, on channel 0
      player.noteOn(0, 64, 110); // Play The Note 64, at velocity 110 on channel 0
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 60, 110); // Play The Note 60, at velocity 110 on channel 1
      player.noteOn(2, 33, 104); // Play The Note 33, at velocity 104 on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 40, 93); // Play The Note 40, at velocity 93 on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 69, 100); // Play The Note 69, at velocity 100 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 60); // Turn off Note 60, on channel 1
      player.noteOn(1, 64, 100); // Play The Note 64, at velocity 100 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 69); // Turn off Note 69, on channel 0
      player.noteOn(0, 64, 113); // Play The Note 64, at velocity 113 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 60, 113); // Play The Note 60, at velocity 113 on channel 1
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 64); // Turn off Note 64, on channel 0
      player.noteOn(0, 60, 103); // Play The Note 60, at velocity 103 on channel 0
      player.noteOn(9, 36, 88); // Play The Note 36, at velocity 88 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 60); // Turn off Note 60, on channel 1
      player.noteOn(1, 57, 103); // Play The Note 57, at velocity 103 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 60); // Turn off Note 60, on channel 0
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 36, 118); // Play The Note 36, at velocity 118 on channel 9
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 57); // Turn off Note 57, on channel 1
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 52, 114); // Play The Note 52, at velocity 114 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 118); // Play The Note 40, at velocity 118 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 55, 114); // Play The Note 55, at velocity 114 on channel 1
      player.noteOn(9, 46, 85); // Play The Note 46, at velocity 85 on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(9, 46, 81); // Play The Note 46, at velocity 81 on channel 9
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(0, 50, 111); // Play The Note 50, at velocity 111 on channel 0
      player.noteOn(9, 36, 118); // Play The Note 36, at velocity 118 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 54, 111); // Play The Note 54, at velocity 111 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 54); // Turn off Note 54, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 104); // Play The Note 40, at velocity 104 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 104); // Play The Note 40, at velocity 104 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(9, 46, 81); // Play The Note 46, at velocity 81 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(129); // Wait For The Next Note
      player.noteOn(0, 48, 116); // Play The Note 48, at velocity 116 on channel 0
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 51, 116); // Play The Note 51, at velocity 116 on channel 1
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOff(1, 51); // Turn off Note 51, on channel 1
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 117); // Play The Note 40, at velocity 117 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 46, 110); // Play The Note 46, at velocity 110 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(108); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(9, 36, 121); // Play The Note 36, at velocity 121 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOn(0, 47, 110); // Play The Note 47, at velocity 110 on channel 0
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 78); // Play The Note 46, at velocity 78 on channel 9
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 48, 117); // Play The Note 48, at velocity 117 on channel 0
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 52, 117); // Play The Note 52, at velocity 117 on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      player.noteOn(9, 46, 68); // Play The Note 46, at velocity 68 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 52, 114); // Play The Note 52, at velocity 114 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 55, 114); // Play The Note 55, at velocity 114 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(0, 50, 106); // Play The Note 50, at velocity 106 on channel 0
      player.noteOn(9, 36, 117); // Play The Note 36, at velocity 117 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 54, 106); // Play The Note 54, at velocity 106 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOff(1, 54); // Turn off Note 54, on channel 1
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 48, 117); // Play The Note 48, at velocity 117 on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 52, 117); // Play The Note 52, at velocity 117 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 117); // Play The Note 40, at velocity 117 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      player.noteOn(9, 46, 69); // Play The Note 46, at velocity 69 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(0, 46, 114); // Play The Note 46, at velocity 114 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 49, 114); // Play The Note 49, at velocity 114 on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.pitchBend(0, -256); // Change The Pitch Offset On Channel 0 To -256
      player.pitchBend(1, -256); // Change The Pitch Offset On Channel 1 To -256
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 46, 73); // Play The Note 46, at velocity 73 on channel 9
      player.noteOn(9, 36, 121); // Play The Note 36, at velocity 121 on channel 9
      Thread.Sleep(58); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 640); // Change The Pitch Offset On Channel 0 To 640
      player.pitchBend(1, 640); // Change The Pitch Offset On Channel 1 To 640
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 2048); // Change The Pitch Offset On Channel 0 To 2048
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(16); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(16); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      player.noteOn(2, 40, 71); // Play The Note 40, at velocity 71 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1792); // Change The Pitch Offset On Channel 0 To 1792
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      player.noteOn(2, 40, 77); // Play The Note 40, at velocity 77 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 107); // Play The Note 40, at velocity 107 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 107); // Play The Note 40, at velocity 107 on channel 1
      Thread.Sleep(116); // Wait For The Next Note
      player.noteOn(9, 46, 69); // Play The Note 46, at velocity 69 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 52, 113); // Play The Note 52, at velocity 113 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 55, 113); // Play The Note 55, at velocity 113 on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 105); // Play The Note 40, at velocity 105 on channel 0
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 105); // Play The Note 40, at velocity 105 on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 46, 79); // Play The Note 46, at velocity 79 on channel 9
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 50, 110); // Play The Note 50, at velocity 110 on channel 0
      player.noteOn(9, 36, 115); // Play The Note 36, at velocity 115 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 54, 110); // Play The Note 54, at velocity 110 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      player.noteOff(1, 54); // Turn off Note 54, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 48, 118); // Play The Note 48, at velocity 118 on channel 0
      player.noteOn(2, 40, 98); // Play The Note 40, at velocity 98 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 51, 118); // Play The Note 51, at velocity 118 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(9, 46, 65); // Play The Note 46, at velocity 65 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      player.noteOff(1, 51); // Turn off Note 51, on channel 1
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 75); // Play The Note 46, at velocity 75 on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(0, 46, 115); // Play The Note 46, at velocity 115 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(1, 50, 115); // Play The Note 50, at velocity 115 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(116); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOn(0, 47, 110); // Play The Note 47, at velocity 110 on channel 0
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      player.noteOn(0, 48, 111); // Play The Note 48, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 52, 111); // Play The Note 52, at velocity 111 on channel 1
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      player.noteOn(9, 46, 72); // Play The Note 46, at velocity 72 on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(120); // Wait For The Next Note
      player.noteOn(9, 46, 73); // Play The Note 46, at velocity 73 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 52, 117); // Play The Note 52, at velocity 117 on channel 0
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 55, 117); // Play The Note 55, at velocity 117 on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOn(9, 46, 71); // Play The Note 46, at velocity 71 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 50, 110); // Play The Note 50, at velocity 110 on channel 0
      player.noteOn(1, 54, 110); // Play The Note 54, at velocity 110 on channel 1
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOn(2, 40, 98); // Play The Note 40, at velocity 98 on channel 2
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 54); // Turn off Note 54, on channel 1
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      player.noteOn(9, 46, 73); // Play The Note 46, at velocity 73 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 46); // Turn off Note 46, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 40, 115); // Play The Note 40, at velocity 115 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 115); // Play The Note 40, at velocity 115 on channel 1
      Thread.Sleep(125); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 48, 117); // Play The Note 48, at velocity 117 on channel 0
      player.noteOn(2, 40, 104); // Play The Note 40, at velocity 104 on channel 2
      player.noteOn(9, 38, 85); // Play The Note 38, at velocity 85 on channel 9
      player.noteOn(9, 40, 92); // Play The Note 40, at velocity 92 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      player.noteOn(1, 52, 117); // Play The Note 52, at velocity 117 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 38); // Turn off Note 38, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(95); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      player.noteOn(9, 36, 86); // Play The Note 36, at velocity 86 on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(9, 38, 82); // Play The Note 38, at velocity 82 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(9, 40, 92); // Play The Note 40, at velocity 92 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOn(2, 40, 98); // Play The Note 40, at velocity 98 on channel 2
      player.noteOff(9, 38); // Turn off Note 38, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(95); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(9, 36, 91); // Play The Note 36, at velocity 91 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 46, 114); // Play The Note 46, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 49, 114); // Play The Note 49, at velocity 114 on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.pitchBend(0, -256); // Change The Pitch Offset On Channel 0 To -256
      player.pitchBend(1, -256); // Change The Pitch Offset On Channel 1 To -256
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOn(2, 40, 92); // Play The Note 40, at velocity 92 on channel 2
      player.noteOn(9, 38, 79); // Play The Note 38, at velocity 79 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(9, 40, 88); // Play The Note 40, at velocity 88 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 38); // Turn off Note 38, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      player.noteOn(9, 38, 79); // Play The Note 38, at velocity 79 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 640); // Change The Pitch Offset On Channel 0 To 640
      player.pitchBend(1, 640); // Change The Pitch Offset On Channel 1 To 640
      player.noteOn(9, 40, 90); // Play The Note 40, at velocity 90 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      player.noteOff(9, 38); // Turn off Note 38, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 2048); // Change The Pitch Offset On Channel 0 To 2048
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      player.noteOn(9, 38, 87); // Play The Note 38, at velocity 87 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      player.noteOn(2, 40, 104); // Play The Note 40, at velocity 104 on channel 2
      player.noteOn(9, 40, 93); // Play The Note 40, at velocity 93 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      player.noteOff(9, 38); // Turn off Note 38, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1792); // Change The Pitch Offset On Channel 0 To 1792
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      player.noteOn(9, 36, 93); // Play The Note 36, at velocity 93 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(83); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      player.noteOn(0, 49, 108); // Play The Note 49, at velocity 108 on channel 0
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      player.noteOn(1, 49, 108); // Play The Note 49, at velocity 108 on channel 1
      player.noteOn(2, 37, 110); // Play The Note 37, at velocity 110 on channel 2
      player.noteOn(9, 36, 118); // Play The Note 36, at velocity 118 on channel 9
      player.noteOn(9, 57, 79); // Play The Note 57, at velocity 79 on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOn(0, 49, 114); // Play The Note 49, at velocity 114 on channel 0
      player.noteOff(2, 37); // Turn off Note 37, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 49, 114); // Play The Note 49, at velocity 114 on channel 1
      Thread.Sleep(120); // Wait For The Next Note
      player.noteOn(9, 53, 123); // Play The Note 53, at velocity 123 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 61, 114); // Play The Note 61, at velocity 114 on channel 0
      player.noteOn(2, 37, 98); // Play The Note 37, at velocity 98 on channel 2
      player.noteOn(9, 40, 118); // Play The Note 40, at velocity 118 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 67, 114); // Play The Note 67, at velocity 114 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 61); // Turn off Note 61, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 49, 110); // Play The Note 49, at velocity 110 on channel 0
      player.noteOff(1, 67); // Turn off Note 67, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 49, 110); // Play The Note 49, at velocity 110 on channel 1
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(2, 37); // Turn off Note 37, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 49, 110); // Play The Note 49, at velocity 110 on channel 0
      player.noteOn(2, 37, 89); // Play The Note 37, at velocity 89 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 49, 110); // Play The Note 49, at velocity 110 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(0, 59, 111); // Play The Note 59, at velocity 111 on channel 0
      player.noteOn(9, 36, 118); // Play The Note 36, at velocity 118 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 66, 111); // Play The Note 66, at velocity 111 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 37); // Turn off Note 37, on channel 2
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 59); // Turn off Note 59, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 66); // Turn off Note 66, on channel 1
      player.noteOn(9, 53, 122); // Play The Note 53, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 49, 104); // Play The Note 49, at velocity 104 on channel 0
      player.noteOn(2, 37, 104); // Play The Note 37, at velocity 104 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 49, 104); // Play The Note 49, at velocity 104 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(0, 49, 111); // Play The Note 49, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 49, 111); // Play The Note 49, at velocity 111 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 37); // Turn off Note 37, on channel 2
      Thread.Sleep(108); // Wait For The Next Note
      player.noteOn(0, 57, 116); // Play The Note 57, at velocity 116 on channel 0
      player.noteOn(2, 37, 114); // Play The Note 37, at velocity 114 on channel 2
      player.noteOn(9, 53, 124); // Play The Note 53, at velocity 124 on channel 9
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      player.noteOn(1, 64, 116); // Play The Note 64, at velocity 116 on channel 1
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 57); // Turn off Note 57, on channel 0
      player.noteOn(0, 49, 108); // Play The Note 49, at velocity 108 on channel 0
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 49, 108); // Play The Note 49, at velocity 108 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 37); // Turn off Note 37, on channel 2
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(87); // Wait For The Next Note
      player.noteOn(0, 49, 110); // Play The Note 49, at velocity 110 on channel 0
      player.noteOn(1, 49, 110); // Play The Note 49, at velocity 110 on channel 1
      player.noteOn(2, 37, 104); // Play The Note 37, at velocity 104 on channel 2
      player.noteOn(9, 40, 117); // Play The Note 40, at velocity 117 on channel 9
      player.noteOn(9, 53, 114); // Play The Note 53, at velocity 114 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(0, 55, 110); // Play The Note 55, at velocity 110 on channel 0
      player.noteOn(1, 61, 110); // Play The Note 61, at velocity 110 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 37); // Turn off Note 37, on channel 2
      Thread.Sleep(95); // Wait For The Next Note
      player.noteOff(0, 55); // Turn off Note 55, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 49, 110); // Play The Note 49, at velocity 110 on channel 0
      player.noteOff(1, 61); // Turn off Note 61, on channel 1
      player.noteOn(2, 37, 104); // Play The Note 37, at velocity 104 on channel 2
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      player.noteOn(9, 53, 120); // Play The Note 53, at velocity 120 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 49, 110); // Play The Note 49, at velocity 110 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(0, 49, 111); // Play The Note 49, at velocity 111 on channel 0
      player.noteOn(9, 36, 121); // Play The Note 36, at velocity 121 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 49, 111); // Play The Note 49, at velocity 111 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 37); // Turn off Note 37, on channel 2
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOn(9, 53, 124); // Play The Note 53, at velocity 124 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 56, 110); // Play The Note 56, at velocity 110 on channel 0
      player.noteOn(2, 37, 98); // Play The Note 37, at velocity 98 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 61, 110); // Play The Note 61, at velocity 110 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 56); // Turn off Note 56, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 57, 117); // Play The Note 57, at velocity 117 on channel 0
      player.noteOff(1, 61); // Turn off Note 61, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 64, 117); // Play The Note 64, at velocity 117 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 37); // Turn off Note 37, on channel 2
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 49); // Turn off Note 49, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 49); // Turn off Note 49, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 57); // Turn off Note 57, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 47, 111); // Play The Note 47, at velocity 111 on channel 0
      player.noteOn(2, 35, 77); // Play The Note 35, at velocity 77 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 49, 79); // Play The Note 49, at velocity 79 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 47, 111); // Play The Note 47, at velocity 111 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 49); // Turn off Note 49, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOn(0, 47, 111); // Play The Note 47, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 47, 111); // Play The Note 47, at velocity 111 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 35); // Turn off Note 35, on channel 2
      Thread.Sleep(91); // Wait For The Next Note
      player.noteOn(0, 59, 114); // Play The Note 59, at velocity 114 on channel 0
      player.noteOn(2, 35, 92); // Play The Note 35, at velocity 92 on channel 2
      player.noteOn(9, 53, 124); // Play The Note 53, at velocity 124 on channel 9
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 66, 114); // Play The Note 66, at velocity 114 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 59); // Turn off Note 59, on channel 0
      player.noteOff(1, 66); // Turn off Note 66, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 47, 106); // Play The Note 47, at velocity 106 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 47, 106); // Play The Note 47, at velocity 106 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 35); // Turn off Note 35, on channel 2
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 47, 108); // Play The Note 47, at velocity 108 on channel 0
      player.noteOn(2, 35, 104); // Play The Note 35, at velocity 104 on channel 2
      player.noteOn(9, 53, 119); // Play The Note 53, at velocity 119 on channel 9
      player.noteOn(9, 36, 116); // Play The Note 36, at velocity 116 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 47, 108); // Play The Note 47, at velocity 108 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(66); // Wait For The Next Note
      player.noteOn(0, 57, 106); // Play The Note 57, at velocity 106 on channel 0
      player.noteOn(1, 64, 106); // Play The Note 64, at velocity 106 on channel 1
      player.noteOn(9, 36, 117); // Play The Note 36, at velocity 117 on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOff(2, 35); // Turn off Note 35, on channel 2
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(9, 53, 124); // Play The Note 53, at velocity 124 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 57); // Turn off Note 57, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 47, 114); // Play The Note 47, at velocity 114 on channel 0
      player.noteOff(1, 64); // Turn off Note 64, on channel 1
      player.noteOn(1, 47, 114); // Play The Note 47, at velocity 114 on channel 1
      player.noteOn(2, 35, 86); // Play The Note 35, at velocity 86 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(0, 47, 106); // Play The Note 47, at velocity 106 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 47, 106); // Play The Note 47, at velocity 106 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(2, 35); // Turn off Note 35, on channel 2
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 55, 117); // Play The Note 55, at velocity 117 on channel 0
      player.noteOn(2, 33, 98); // Play The Note 33, at velocity 98 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      player.noteOn(1, 63, 117); // Play The Note 63, at velocity 117 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 55); // Turn off Note 55, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 63); // Turn off Note 63, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 46, 111); // Play The Note 46, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 46, 111); // Play The Note 46, at velocity 111 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(1, 46); // Turn off Note 46, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOn(0, 45, 114); // Play The Note 45, at velocity 114 on channel 0
      player.noteOn(2, 33, 98); // Play The Note 33, at velocity 98 on channel 2
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      player.noteOn(9, 40, 117); // Play The Note 40, at velocity 117 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 45, 114); // Play The Note 45, at velocity 114 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(0, 53, 114); // Play The Note 53, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 59, 114); // Play The Note 59, at velocity 114 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(29); // Wait For The Next Note
      player.pitchBend(0, -256); // Change The Pitch Offset On Channel 0 To -256
      player.pitchBend(1, -256); // Change The Pitch Offset On Channel 1 To -256
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1792); // Change The Pitch Offset On Channel 0 To 1792
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 256); // Change The Pitch Offset On Channel 0 To 256
      player.pitchBend(1, 256); // Change The Pitch Offset On Channel 1 To 256
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(2, 33, 86); // Play The Note 33, at velocity 86 on channel 2
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      player.noteOn(9, 36, 121); // Play The Note 36, at velocity 121 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 640); // Change The Pitch Offset On Channel 0 To 640
      player.pitchBend(1, 640); // Change The Pitch Offset On Channel 1 To 640
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 2048); // Change The Pitch Offset On Channel 0 To 2048
      player.pitchBend(1, 2048); // Change The Pitch Offset On Channel 1 To 2048
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 128); // Change The Pitch Offset On Channel 0 To 128
      player.pitchBend(1, 128); // Change The Pitch Offset On Channel 1 To 128
      player.noteOn(9, 36, 120); // Play The Note 36, at velocity 120 on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(50); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1920); // Change The Pitch Offset On Channel 0 To 1920
      player.pitchBend(1, 1920); // Change The Pitch Offset On Channel 1 To 1920
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 896); // Change The Pitch Offset On Channel 0 To 896
      player.pitchBend(1, 896); // Change The Pitch Offset On Channel 1 To 896
      player.noteOn(2, 33, 89); // Play The Note 33, at velocity 89 on channel 2
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 384); // Change The Pitch Offset On Channel 0 To 384
      player.pitchBend(1, 384); // Change The Pitch Offset On Channel 1 To 384
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.pitchBend(0, 768); // Change The Pitch Offset On Channel 0 To 768
      player.pitchBend(1, 768); // Change The Pitch Offset On Channel 1 To 768
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.pitchBend(1, 1408); // Change The Pitch Offset On Channel 1 To 1408
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1792); // Change The Pitch Offset On Channel 0 To 1792
      player.pitchBend(1, 1792); // Change The Pitch Offset On Channel 1 To 1792
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1536); // Change The Pitch Offset On Channel 0 To 1536
      player.pitchBend(1, 1536); // Change The Pitch Offset On Channel 1 To 1536
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1664); // Change The Pitch Offset On Channel 0 To 1664
      player.pitchBend(1, 1664); // Change The Pitch Offset On Channel 1 To 1664
      Thread.Sleep(12); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(2, 33); // Turn off Note 33, on channel 2
      Thread.Sleep(79); // Wait For The Next Note
      player.pitchBend(0, 512); // Change The Pitch Offset On Channel 0 To 512
      player.pitchBend(1, 512); // Change The Pitch Offset On Channel 1 To 512
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1024); // Change The Pitch Offset On Channel 0 To 1024
      player.noteOff(0, 45); // Turn off Note 45, on channel 0
      player.pitchBend(0, 1152); // Change The Pitch Offset On Channel 0 To 1152
      player.pitchBend(1, 1024); // Change The Pitch Offset On Channel 1 To 1024
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(1, 1152); // Change The Pitch Offset On Channel 1 To 1152
      player.noteOff(1, 45); // Turn off Note 45, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.pitchBend(0, 1280); // Change The Pitch Offset On Channel 0 To 1280
      player.pitchBend(1, 1280); // Change The Pitch Offset On Channel 1 To 1280
      Thread.Sleep(4); // Wait For The Next Note
      player.pitchBend(0, 1408); // Change The Pitch Offset On Channel 0 To 1408
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.pitchBend(0, 0); // Change The Pitch Offset On Channel 0 To 0
      player.pitchBend(1, 0); // Change The Pitch Offset On Channel 1 To 0
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      player.noteOn(2, 40, 80); // Play The Note 40, at velocity 80 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 57, 79); // Play The Note 57, at velocity 79 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 53); // Turn off Note 53, on channel 0
      player.noteOff(1, 59); // Turn off Note 59, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(9, 57); // Turn off Note 57, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOn(0, 40, 107); // Play The Note 40, at velocity 107 on channel 0
      player.noteOn(1, 40, 107); // Play The Note 40, at velocity 107 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 52, 113); // Play The Note 52, at velocity 113 on channel 0
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 40, 121); // Play The Note 40, at velocity 121 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 55, 113); // Play The Note 55, at velocity 113 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(0, 40, 105); // Play The Note 40, at velocity 105 on channel 0
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 105); // Play The Note 40, at velocity 105 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOn(0, 50, 110); // Play The Note 50, at velocity 110 on channel 0
      player.noteOn(9, 36, 115); // Play The Note 36, at velocity 115 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 54, 110); // Play The Note 54, at velocity 110 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOn(9, 53, 124); // Play The Note 53, at velocity 124 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      player.noteOff(1, 54); // Turn off Note 54, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(83); // Wait For The Next Note
      player.noteOn(9, 53, 124); // Play The Note 53, at velocity 124 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 48, 118); // Play The Note 48, at velocity 118 on channel 0
      player.noteOn(2, 40, 77); // Play The Note 40, at velocity 77 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 51, 118); // Play The Note 51, at velocity 118 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      player.noteOn(0, 40, 106); // Play The Note 40, at velocity 106 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 51); // Turn off Note 51, on channel 1
      player.noteOn(1, 40, 106); // Play The Note 40, at velocity 106 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(2, 40, 74); // Play The Note 40, at velocity 74 on channel 2
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOn(0, 46, 115); // Play The Note 46, at velocity 115 on channel 0
      player.noteOn(1, 50, 115); // Play The Note 50, at velocity 115 on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(104); // Wait For The Next Note
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 46); // Turn off Note 46, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(45); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(37); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(95); // Wait For The Next Note
      player.noteOn(0, 47, 110); // Play The Note 47, at velocity 110 on channel 0
      player.noteOn(2, 40, 83); // Play The Note 40, at velocity 83 on channel 2
      player.noteOn(9, 53, 119); // Play The Note 53, at velocity 119 on channel 9
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 50, 110); // Play The Note 50, at velocity 110 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(70); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 47); // Turn off Note 47, on channel 0
      player.noteOn(0, 48, 111); // Play The Note 48, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 50); // Turn off Note 50, on channel 1
      player.noteOn(1, 52, 111); // Play The Note 52, at velocity 111 on channel 1
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(0, 48); // Turn off Note 48, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(0, 40, 110); // Play The Note 40, at velocity 110 on channel 0
      player.noteOff(1, 52); // Turn off Note 52, on channel 1
      player.noteOn(2, 40, 86); // Play The Note 40, at velocity 86 on channel 2
      player.noteOn(9, 36, 123); // Play The Note 36, at velocity 123 on channel 9
      player.noteOn(9, 53, 124); // Play The Note 53, at velocity 124 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 110); // Play The Note 40, at velocity 110 on channel 1
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(33); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      Thread.Sleep(12); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(112); // Wait For The Next Note
      player.noteOn(0, 52, 117); // Play The Note 52, at velocity 117 on channel 0
      player.noteOn(2, 40, 98); // Play The Note 40, at velocity 98 on channel 2
      player.noteOn(9, 40, 123); // Play The Note 40, at velocity 123 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 55, 117); // Play The Note 55, at velocity 117 on channel 1
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOn(0, 40, 111); // Play The Note 40, at velocity 111 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOn(1, 40, 111); // Play The Note 40, at velocity 111 on channel 1
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 52); // Turn off Note 52, on channel 0
      player.noteOff(1, 55); // Turn off Note 55, on channel 1
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(75); // Wait For The Next Note
      player.noteOn(0, 40, 108); // Play The Note 40, at velocity 108 on channel 0
      player.noteOn(2, 40, 89); // Play The Note 40, at velocity 89 on channel 2
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 40, 108); // Play The Note 40, at velocity 108 on channel 1
      player.noteOn(9, 53, 124); // Play The Note 53, at velocity 124 on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOn(0, 50, 110); // Play The Note 50, at velocity 110 on channel 0
      player.noteOn(9, 36, 122); // Play The Note 36, at velocity 122 on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOn(1, 54, 110); // Play The Note 54, at velocity 110 on channel 1
      Thread.Sleep(25); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(0, 50); // Turn off Note 50, on channel 0
      player.noteOn(0, 40, 114); // Play The Note 40, at velocity 114 on channel 0
      player.noteOff(1, 54); // Turn off Note 54, on channel 1
      player.noteOn(1, 40, 114); // Play The Note 40, at velocity 114 on channel 1
      player.noteOn(2, 40, 104); // Play The Note 40, at velocity 104 on channel 2
      player.noteOn(9, 40, 120); // Play The Note 40, at velocity 120 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(16); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      Thread.Sleep(41); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(50); // Wait For The Next Note
      player.noteOn(0, 40, 115); // Play The Note 40, at velocity 115 on channel 0
      player.noteOn(1, 40, 115); // Play The Note 40, at velocity 115 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(2, 40); // Turn off Note 40, on channel 2
      Thread.Sleep(79); // Wait For The Next Note
      player.noteOff(0, 40); // Turn off Note 40, on channel 0
      player.noteOn(0, 71, 112); // Play The Note 71, at velocity 112 on channel 0
      player.noteOn(2, 28, 104); // Play The Note 28, at velocity 104 on channel 2
      player.noteOn(9, 38, 116); // Play The Note 38, at velocity 116 on channel 9
      player.noteOn(9, 36, 99); // Play The Note 36, at velocity 99 on channel 9
      player.noteOn(9, 53, 125); // Play The Note 53, at velocity 125 on channel 9
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 40); // Turn off Note 40, on channel 1
      player.noteOn(1, 69, 112); // Play The Note 69, at velocity 112 on channel 1
      player.noteOn(9, 40, 122); // Play The Note 40, at velocity 122 on channel 9
      Thread.Sleep(20); // Wait For The Next Note
      player.noteOff(9, 36); // Turn off Note 36, on channel 9
      player.noteOff(9, 38); // Turn off Note 38, on channel 9
      player.noteOff(9, 53); // Turn off Note 53, on channel 9
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(9, 40); // Turn off Note 40, on channel 9
      Thread.Sleep(29); // Wait For The Next Note
      player.noteOff(0, 71); // Turn off Note 71, on channel 0
      player.noteOn(0, 69, 105); // Play The Note 69, at velocity 105 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 69); // Turn off Note 69, on channel 1
      player.noteOn(1, 66, 105); // Play The Note 66, at velocity 105 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 69); // Turn off Note 69, on channel 0
      player.noteOn(0, 66, 112); // Play The Note 66, at velocity 112 on channel 0
      player.noteOff(2, 28); // Turn off Note 28, on channel 2
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 66); // Turn off Note 66, on channel 1
      player.noteOn(1, 63, 112); // Play The Note 63, at velocity 112 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(0, 66); // Turn off Note 66, on channel 0
      player.noteOn(0, 63, 103); // Play The Note 63, at velocity 103 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 63); // Turn off Note 63, on channel 1
      player.noteOn(1, 59, 103); // Play The Note 59, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 63); // Turn off Note 63, on channel 0
      player.noteOn(0, 59, 111); // Play The Note 59, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 59); // Turn off Note 59, on channel 1
      player.noteOn(1, 57, 111); // Play The Note 57, at velocity 111 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(0, 59); // Turn off Note 59, on channel 0
      player.noteOn(0, 57, 102); // Play The Note 57, at velocity 102 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 57); // Turn off Note 57, on channel 1
      player.noteOn(1, 54, 102); // Play The Note 54, at velocity 102 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 57); // Turn off Note 57, on channel 0
      player.noteOn(0, 54, 113); // Play The Note 54, at velocity 113 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 54); // Turn off Note 54, on channel 1
      player.noteOn(1, 51, 113); // Play The Note 51, at velocity 113 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 54); // Turn off Note 54, on channel 0
      player.noteOn(0, 51, 103); // Play The Note 51, at velocity 103 on channel 0
      player.noteOff(1, 51); // Turn off Note 51, on channel 1
      player.noteOn(1, 47, 103); // Play The Note 47, at velocity 103 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 51); // Turn off Note 51, on channel 0
      player.noteOn(0, 75, 111); // Play The Note 75, at velocity 111 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 47); // Turn off Note 47, on channel 1
      player.noteOn(1, 71, 111); // Play The Note 71, at velocity 111 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 75); // Turn off Note 75, on channel 0
      player.noteOn(0, 73, 101); // Play The Note 73, at velocity 101 on channel 0
      player.noteOff(1, 71); // Turn off Note 71, on channel 1
      player.noteOn(1, 69, 101); // Play The Note 69, at velocity 101 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 73); // Turn off Note 73, on channel 0
      player.noteOn(0, 71, 112); // Play The Note 71, at velocity 112 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 69); // Turn off Note 69, on channel 1
      player.noteOn(1, 66, 112); // Play The Note 66, at velocity 112 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 71); // Turn off Note 71, on channel 0
      player.noteOn(0, 69, 103); // Play The Note 69, at velocity 103 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 66); // Turn off Note 66, on channel 1
      player.noteOn(1, 63, 103); // Play The Note 63, at velocity 103 on channel 1
      Thread.Sleep(58); // Wait For The Next Note
      player.noteOff(0, 69); // Turn off Note 69, on channel 0
      player.noteOn(0, 66, 110); // Play The Note 66, at velocity 110 on channel 0
      Thread.Sleep(4); // Wait For The Next Note
      player.noteOff(1, 63); // Turn off Note 63, on channel 1
      player.noteOn(1, 59, 110); // Play The Note 59, at velocity 110 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 66); // Turn off Note 66, on channel 0
      player.noteOn(0, 63, 100); // Play The Note 63, at velocity 100 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 59); // Turn off Note 59, on channel 1
      player.noteOn(1, 57, 100); // Play The Note 57, at velocity 100 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(0, 63); // Turn off Note 63, on channel 0
      player.noteOn(0, 59, 113); // Play The Note 59, at velocity 113 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 57); // Turn off Note 57, on channel 1
      player.noteOn(1, 54, 113); // Play The Note 54, at velocity 113 on channel 1
      Thread.Sleep(62); // Wait For The Next Note
      player.noteOff(0, 59); // Turn off Note 59, on channel 0
      player.noteOn(0, 57, 103); // Play The Note 57, at velocity 103 on channel 0
      Thread.Sleep(8); // Wait For The Next Note
      player.noteOff(1, 54); // Turn off Note 54, on channel 1
      player.noteOn(1, 51, 103); // Play The Note 51, at velocity 103 on channel 1
      Thread.Sleep(54); // Wait For The Next Note
      player.noteOff(0, 57); // Turn off Note 57, on channel 0
      player.noteOff(1, 51); // Turn off Note 51, on channel 1
      Doom(player);
    }
    #endregion
  }
}
